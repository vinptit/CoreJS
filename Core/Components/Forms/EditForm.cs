﻿using Bridge.Html5;
using Core.Clients;
using Core.Components.Extensions;
using Core.Components.Framework;
using Core.Enums;
using Core.Extensions;
using Core.Models;
using Core.MVVM;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElementType = Core.MVVM.ElementType;
using History = Core.Models.History;

namespace Core.Components.Forms
{
    public partial class EditForm : EditableComponent
    {
        public const string NotDirtyMessage = "Dữ liệu chưa thay đổi";
        public const string ExpiredDate = "ExpiredDate";
        public const string BtnExpired = "btnExpired";
        public const string BtnSave = "btnSave";
        public const string BtnSend = "btnSend";
        public const string BtnApprove = "btnApprove";
        public const string BtnReject = "btnReject";
        public const string StatusIdField = "StatusId";
        public const string BtnCancel = "btnCancel";
        public const string BtnPrint = "btnPrint";
        public const string BtnPreview = "btnPreview";
        private const string SpecialEntryPoint = "entry";

        public static EditForm LastForm;

        protected readonly string _entity;
        protected URLSearchParams UrlSearch;
        protected Entity _entityEnum;
        public List<TabGroup> TabGroup;
        protected ConfirmDialog _confirm;
        private string _title;
        private string _icon;
        protected HTMLElement TitleElement;
        protected HTMLElement IconElement;
        public int CurrentUserId { get; private set; }
        public int? RegionId { get; set; }
        public string AllRoleIds { get; private set; }
        public string CenterIds { get; private set; }
        public string RoleIds { get; private set; }
        public int? CostCenterId { get; private set; }
        public string RoleNames { get; private set; }

        public bool ShouldUpdateParentForm { get; set; }
        public DateTime Now => DateTime.Now;
        public Action<bool> AfterSaved;
        public Func<bool> BeforeSaved;
        public Client Client { get; set; }
        public bool IsEditMode => Entity != null && Entity[IdField].As<int>() > 0;
        public static WebSocketClient NotificationClient;
        private int awaiter;
        protected ListView _currentListView;
        protected Component _componentCoppy;
        private HTMLElement InnerEntry => Document.GetElementById("entry");

        public bool IsLock { get; private set; }

        public HashSet<ListView> ListViews { get; set; }

        public Vendor UserVendor => Client.Token?.Vendor;
        public bool ShouldLoadEntity { get; set; }
        public Feature Feature { get; set; }
        public virtual string Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                if (IconElement != null)
                {
                    Html.Take(IconElement).IconForSpan(value);
                }
            }
        }
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                if (TitleElement != null)
                {
                    TitleElement.InnerHTML = null;
                    Html.Take(TitleElement).IText(value);
                }
            }
        }

        public bool Public { get; set; }
        public EditableComponent OpenFrom { get; set; }
        public EditForm ParentForm { get; set; }
        public static EditForm LayoutForm { get; set; }
        public string ReasonOfChange { get; set; }
        public static bool Portal { get; internal set; }
        public bool Config { get; set; }

        public EditForm(string entity) : base(null)
        {
            UrlSearch = new URLSearchParams(Window.Location.Search);
            if (entity is null)
            {
                return;
            }
            ListViews = new HashSet<ListView>();
            _entity = entity;
            Client = new Client(entity);
            var entityType = Type.GetType(Client.ModelNamespace + entity);
            if (entityType != null)
            {
                Entity = Activator.CreateInstance(entityType);
            }
            Window.AddEventListener(EventType.Resize, ResizeHandler);
            LayoutForm = LayoutForm ?? new EditForm(null);
        }

        private static bool ListViewItemFilter(object updatedData, EditableComponent x)
        {
            if (x is GroupViewItem)
            {
                return false;
            }

            return x.Entity != null && x.Entity.GetType().Name == updatedData.GetType().Name && x.Entity[IdField].ToString() == updatedData[IdField].ToString();
        }

        public void UpdateViewAwait(int millisecond = 100)
        {
            Window.ClearTimeout(awaiter);
            awaiter = Window.SetTimeout(() => UpdateView(), millisecond);
            Dirty = false;
        }

        public virtual async Task<bool> BulkUpdate()
        {
            var grid = this.FindActiveComponent<ListView>();
            if (!Dirty)
            {
                Toast.Warning(NotDirtyMessage);
                return false;
            }
            if (grid.Nothing())
            {
                return false;
            }
            var tasks = grid.Select(x => x.Dirty ? x.BatchUpdate() : null).Where(x => x != null);
            var rs = await Task.WhenAll(tasks);
            if (rs != null && rs.Any(x => x.HasElement()))
            {
                Toast.Success("Cập nhật thành công");
            }
            else
            {
                Toast.Warning(Client.ErrorMessage);
            }
            Dirty = false;
            return true;
        }

        public virtual async Task<bool> SaveWithouUpdateView(object entity)
        {
            if (Entity is null)
            {
                throw new InvalidOperationException("Entity is null");
            }

            bool res;
            var isValid = await IsFormValid();
            if (!isValid)
            {
                return false;
            }

            BeforeSaved?.Invoke();
            Entity.ClearReferences();
            await AddOrUpdate(entity);
            Dirty = false;
            res = true;
            AfterSaved?.Invoke(res);
            return res;
        }

        public PatchUpdate GetPathEntity()
        {
            var details = FilterChildren(child => child is EditableComponent editable && !(child.Parent is ListViewItem) && editable.Dirty && child.GuiInfo != null && child.GuiInfo.ComponentType != nameof(GridView) && child.GuiInfo.ComponentType != nameof(VirtualGrid))
                .Select(child =>
                {
                    var value = child.Entity.GetComplexPropValue(child.GuiInfo.FieldName);
                    var propType = child.Entity.GetType().GetComplexPropType(child.GuiInfo.FieldName, child.Entity);
                    return new PatchUpdateDetail
                    {
                        Field = child.GuiInfo.FieldName,
                        OldVal = (child.OldValue != null && propType.IsDate()) ? child.OldValue.ToString().DateConverter() : child.OldValue?.ToString(),
                        Value = (value != null && propType.IsDate()) ? value.ToString().DateConverter() : !EditForm.Feature.IgnoreEncode ? value?.ToString().Trim().EncodeSpecialChar() : value?.ToString().Trim(),
                    };
                }).ToList();
            details.Add(new PatchUpdateDetail { Field = Utils.IdField, Value = EntityId.ToString() });
            return new PatchUpdate { Changes = details };
        }

        public virtual async Task<bool> SavePatch(object entity = null)
        {
            if (!Dirty)
            {
                Toast.Warning(NotDirtyMessage);
                return false;
            }
            var pathModel = GetPathEntity();
            if (pathModel.Changes.Count == 1)
            {
                Toast.Warning(NotDirtyMessage);
                return false;
            }
            BeforeSaved?.Invoke();
            var rs = Entity;
            var updating = Entity[IdField].As<int>() > 0;
            if (updating)
            {
                try
                {
                    rs = await Client.PatchAsync<object>(pathModel);
                }
                catch
                {
                    Toast.Warning("Dữ liệu của bạn chưa được lưu vui lòng nhập lại!");
                    rs = (await Client.GetList<object>($"?$filter=Id eq {Entity[IdField]}")).Value.FirstOrDefault();
                    Entity.CopyPropFrom(rs);
                    UpdateView();
                    return false;
                }
            }
            else
            {
                Entity[IdField] = 0;
                rs = await Client.CreateAsync<object>(Entity);
            }
            Entity.CopyPropFrom(rs);
            await UpdateIndependantGridView();
            if (Feature.DeleteTemp)
            {
                await DeleteGridView();
            }
            var arr = FilterChildren<EditableComponent>(x => (!x.Dirty || x.GetValueText().IsNullOrWhiteSpace()) && x.GuiInfo != null).Select(x => x.GuiInfo.FieldName).ToArray();
            UpdateView(true, arr);
            var changing = BuildTextHistory().ToString();
            if (!changing.IsNullOrWhiteSpace())
            {
                await new Client(nameof(History)).CreateAsync<History>(new History
                {
                    ReasonOfChange = "Auto update",
                    TextHistory = changing.ToString(),
                    RecordId = EntityId,
                    EntityId = Utils.GetEntity(Client.EntityName).Id
                });
            }
            var prefix = updating ? "Cập nhật" : "Tạo mới";
            Toast.Success($"{prefix} thành công");
            Dirty = false;
            AfterSaved?.Invoke(true);
            return true;
        }

        public virtual async Task<bool> Save(object entity = null)
        {
            if (Entity is null)
            {
                throw new InvalidOperationException("Entity is null");
            }

            bool res;
            if (!Dirty)
            {
                Toast.Warning(NotDirtyMessage);
                return false;
            }
            var isValid = await IsFormValid(showMessage: entity != null);
            if (!isValid)
            {
                return false;
            }
            BeforeSaved?.Invoke();
            Entity.ClearReferences();
            var data = await AddOrUpdate(entity);
            res = data != null;
            AfterSaved?.Invoke(res);
            if (res)
            {
                Entity.CopyPropFrom(data);
                UpdateViewAwait(true);
            }
            if (ShouldUpdateParentForm)
            {
                ParentForm?.UpdateView(true);
            }
            return res;
        }

        public virtual async Task AddNew(object entity = null)
        {
            Dirty = true;
            Entity.SetPropValue(IdField, 0);
            var dirtyGrid = ListViews
                .Where(x => x.GuiInfo.IdField.HasAnyChar() && x.GuiInfo.CanAdd)
                .ToArray();
            dirtyGrid.ForEach(x =>
            {
                x.RowData.Data.ForEach(row =>
                {
                    row.SetPropValue(x.GuiInfo.IdField, null);
                    row.SetPropValue(IdField, 0);
                });
            });
            var rs = await Save(null);
            if (rs)
            {
                Toast.Success("Tạo mới thành công");
                await ParentForm.FindActiveComponent<GridView>().FirstOrDefault().ActionFilter();
            }
            else
            {
                Toast.Warning("Tạo mới lỗi");
            }
        }

        private void UpdateViewForm()
        {
            var parentForm = ParentForm ?? (this is TabEditor tab && tab.Popup ? tab.Parent : null);
            if (parentForm != null)
            {
                var openFrom = parentForm
                    .FilterChildren(x => x.Entity != null && x.Entity == Entity)
                    .FirstOrDefault();
                openFrom?.UpdateView();
            }
        }

        private ListView[] GetDirtyGrid()
        {
            return ListViews
                .Where(x => x.GuiInfo.IdField.HasAnyChar() && x.GuiInfo.CanAdd)
                .Where(x => x.FilterChildren<EditableComponent>(com => com._dirty, com => !com.PopulateDirty).Any())
                .ToArray();
        }

        private ListView[] GetDeleteGrid()
        {
            return ListViews
                .Where(x => x.GuiInfo.Id > 0)
                .Where(x => x.DeleteTempIds.Any())
                .ToArray();
        }

        public async Task<object> AddOrUpdate(object entity)
        {
            var showMessage = entity != null;
            var changedLog = BuildTextHistory().ToString();
            var updating = Entity[IdField].As<int>() > 0;
            var updated = await AddOrUpdateEntity(entity, updating);
            if (updated is null)
            {
                return null;
            }
            await UpdateHistory(changedLog);
            ReloadAndShowMessage(showMessage, updating);
            Dirty = false;
            return updated;
        }

        private async Task UpdateIndependantGridView()
        {
            var dirtyGrid = GetDirtyGrid();
            if (dirtyGrid.Nothing())
            {
                return;
            }
            var id = Entity[IdField].As<int>();
            dirtyGrid.ForEach(x =>
            {
                x.UpdatedRows.ForEach(row => row.SetPropValue(x.GuiInfo.IdField, id));
            });
            await Task.WhenAll(dirtyGrid.Select(x => x.BatchUpdate()));
        }

        private async Task DeleteGridView()
        {
            var dirtyGrid = GetDeleteGrid();
            if (dirtyGrid.Nothing())
            {
                return;
            }
            foreach (var item in dirtyGrid)
            {
                var client = new Client(item.GuiInfo.RefName);
                var success = await client.HardDeleteAsync(item.DeleteTempIds);
                if (success)
                {
                    item.DeleteTempIds.Clear();
                }
                else
                {
                    Toast.Warning("Lỗi xóa chi tiết vui lòng kiểm tra lại");
                }
            }
        }

        private async Task UpdateHistory(string changedLog)
        {
            if (changedLog.IsNullOrWhiteSpace())
            {
                return;
            }
            var history = new History
            {
                EntityId = Utils.GetEntity(Client.EntityName).Id,
                RecordId = int.Parse(Entity[IdField].ToString()),
                ReasonOfChange = ReasonOfChange ?? "Cập nhật thông tin",
                TextHistory = changedLog,
            };
            try
            {
                await new Client(nameof(History), typeof(User).Namespace).CreateAsync<History>(history);
                ReasonOfChange = null;
            }
            catch
            {
            }
        }

        private async Task<object> AddOrUpdateEntity(object entity, bool updating)
        {
            object data;
            try
            {
                if (updating)
                {
                    data = await Client.UpdateAsync<object>(Entity);
                }
                else
                {
                    Entity[IdField] = 0;
                    data = await Client.CreateAsync<object>(Entity);
                }
            }
            catch
            {
                if (entity is bool showMessage && showMessage)
                {
                    Toast.Warning(Client.ErrorMessage);
                }
                data = null;
            }
            Entity.CopyPropFrom(data);
            await UpdateIndependantGridView();
            if (Feature.DeleteTemp)
            {
                await DeleteGridView();
            }
            return data;
        }

        public async Task<bool> IsFormValid(bool showMessage = true, Func<EditableComponent, bool> predicate = null, Func<EditableComponent, bool> ignorePredicate = null)
        {
            if (predicate == null)
            {
                predicate = (EditableComponent x) => true;
            }
            if (ignorePredicate == null)
            {
                ignorePredicate = (EditableComponent x) => x.AlwaysValid;
            }
            var allValid = await FilterChildren(
                predicate: predicate,
                ignorePredicate: ignorePredicate
            ).ForEachAsync(x => x.ValidateAsync());
            var invalidFields = allValid.ToList().Where(x => !x.IsValid);
            if (invalidFields.Nothing())
            {
                return true;
            }

            if (showMessage)
            {
                invalidFields.ForEach(x => { x.Disabled = false; });
                invalidFields.FirstOrDefault().Focus();
                var message = string.Join("<br />", invalidFields.SelectMany(x => x.ValidationResult.Values));
                Toast.Warning(message);
            }
            return false;
        }

        protected void ReloadAndShowMessage(bool showMessage, bool updating)
        {
            var prefix = updating ? "Cập nhật" : "Tạo mới";
            if (showMessage)
            {
                Toast.Success($"{prefix} thành công");
            }

            UpdateView();
        }

        protected List<ComponentGroup> BuildTree(List<ComponentGroup> componentGroup)
        {
            var componentGroupMap = componentGroup.ToDictionary(x => x.Id);
            ComponentGroup parent;
            foreach (var item in componentGroup)
            {
                if (item.IsVertialTab && Element.ClientWidth < SmallScreen)
                {
                    item.IsVertialTab = false;
                }

                if (item.ParentId is null)
                {
                    continue;
                }

                if (!componentGroupMap.ContainsKey(item.ParentId.Value))
                {
                    Console.WriteLine($"The parent key {item.ParentId} of {item.Name} doesn't exist");
                    continue;
                }
                parent = componentGroupMap[item.ParentId.Value];
                if (parent.InverseParent == null)
                {
                    parent.InverseParent = new List<ComponentGroup>();
                }

                if (!parent.InverseParent.Contains(item))
                {
                    parent.InverseParent.Add(item);
                }

                item.Parent = parent;
            }
            foreach (var item in componentGroup)
            {
                if (item.Component == null || !item.Component.Any())
                {
                    continue;
                }

                foreach (var ui in item.Component)
                {
                    ui.ComponentGroup = item;
                }
                if (item.InverseParent != null)
                {
                    item.InverseParent = item.InverseParent.OrderBy(x => x.Order).ToList();
                }
            }
            componentGroup.ForEach(x => CalcItemInRow(x.InverseParent.ToList()));
            var res = componentGroup.Where(x => x.ParentId is null);
            if (res.Nothing())
            {
                Console.WriteLine("No component group is root component. Wrong feature name or the configuration is wrong");
            }
            return res.ToList();
        }

        private void CalcItemInRow(List<ComponentGroup> componentGroup)
        {
            var cumulativeColumn = 0;
            var itemInRow = 0;
            var startRowIndex = 0;
            for (var i = 0; i < componentGroup.Count; i++)
            {
                var group = componentGroup[i];
                var parentInnerCol = GetInnerColumn(group.Parent);
                var outerCol = GetOuterColumn(group);
                if (parentInnerCol <= 0)
                {
                    continue;
                }

                itemInRow++;
                cumulativeColumn += outerCol;
                if (cumulativeColumn % parentInnerCol == 0)
                {
                    var sameRow = i;
                    while (sameRow >= startRowIndex)
                    {
                        componentGroup[sameRow].ItemInRow = itemInRow;
                        sameRow--;
                    }
                    itemInRow = 0;
                    startRowIndex = i;
                }
            }
        }

        public override void Render()
        {
            if (Portal)
            {
                ParentForm = ParentForm ?? LastForm;
            }
            Task.Run(RenderAsync);
            LastForm = this;
        }

        public virtual Token Token
        {
            get => Client.Token;
            set => Client.Token = value;
        }

        protected virtual async Task RenderAsync()
        {
            var token = Client.Token;
            var featureTask = Feature != null ? Task.FromResult(Feature) : ComponentExt.LoadFeatureByName(Name, Public, Config);
            var entityTask = LoadEntity();
            await Task.WhenAll(featureTask, entityTask);
            var feature = featureTask.Result;
            var layout = feature.LayoutId is null || InnerEntry != null
                ? null
                : await new Client(nameof(Models.Feature), typeof(User).Namespace, Config).FirstOrDefaultAsync<Feature>(
                    $"/Public/?$filter=Active eq true and Id eq {feature.LayoutId} and {nameof(feature.Template)} ne null");
            Entity.CopyPropFrom(entityTask.Result);
            SetFeatureProperties(feature);
            CurrentUserId = token?.UserId ?? 0;
            RegionId = token?.RegionId ?? 0;
            AllRoleIds = token?.AllRoleIds != null ? string.Join(",", token.AllRoleIds) : string.Empty;
            CenterIds = token?.CenterIds != null ? string.Join(",", token.CenterIds) : string.Empty;
            RoleIds = token?.RoleIds != null ? string.Join(",", token.RoleIds) : string.Empty;
            CostCenterId = token?.CostCenterId;
            RoleNames = token?.RoleNames != null ? string.Join(",", token.RoleNames) : string.Empty;
            var groupTree = BuildTree(feature.ComponentGroup.ToList().OrderBy(x => x.Order).ToList());
            Element = RenderTemplate(layout, feature);
            SetFeatureStyleSheet(feature.StyleSheet);
            RenderTabOrSection(groupTree);
            ResizeHandler();
            LockUpdate();
            ToggleApprovalBtn();
            Html.Take(Element).TabIndex(-1).Trigger(EventType.Focus).Event(EventType.FocusIn, async () => await this.DispatchEventToHandlerAsync(Feature.Events, EventType.FocusIn, Entity))
                .Event(EventType.KeyDown, async (e) => await KeyDownIntro(e))
                .Event(EventType.FocusOut, async () => await this.DispatchEventToHandlerAsync(Feature.Events, EventType.FocusOut, Entity));
            DOMContentLoaded?.Invoke();
            await this.DispatchEventToHandlerAsync(Feature.Events, EventType.DOMContentLoaded, Entity);
        }

        private async Task KeyDownIntro(Event evt)
        {
            if (evt.KeyCode() == (int)KeyCodeEnum.H && evt.CtrlOrMetaKey())
            {
                evt.PreventDefault();
                await Client.LoadScript("https://unpkg.com/intro.js/intro.js");
                var intro = await new Client(nameof(Intro)).GetRawList<Intro>($"?$filter=FeatureId eq {Feature.Id}&$orderby=Order asc");
                var script = @"(x) => {
                                debugger;
                                introJs().setOptions({
                                  steps: [
                                  {
                                    intro: ""Hướng dẫn sử dụng chức năng!""
                                  }";
                foreach (var item in intro)
                {
                    script += @",{
                                    intro: '" + item.Label + @"',
                                    element: Core.Components.Extensions.ComponentExt.FindComponentByName(Core.Components.EditableComponent, x, '" + item.FieldName + @"').Element
                                  }";
                }
                script += @"]}).start();}";
                if (Utils.IsFunction(script, out Function fn))
                {
                    fn.Call(this, this);
                }
            }
        }

        private HTMLElement RenderTemplate(Feature layout, Feature feature)
        {
            HTMLElement entryPoint = Document.GetElementById(SpecialEntryPoint) ?? Document.GetElementById("template") ?? Element;
            if (ParentForm != null && Portal)
            {
                ParentForm.Element = null;
                ParentForm.Dispose();
                ParentForm = null;
            }
            if (layout != null)
            {
                var root = Document.GetElementById("template");
                Html.Take(root).InnerHTML(layout.Template);
                var style = Document.CreateElement(ElementType.style.ToString());
                style.AppendChild(new Text(layout.StyleSheet));
                root.AppendChild(style);
                BindingTemplate(root, this, isLayout: true);
                entryPoint = root.FilterElement(x => x.Id == SpecialEntryPoint).FirstOrDefault();
                ResetEntryPoint(entryPoint);
            }
            else
            {
                entryPoint.InnerHTML = null;
            }
            if (!feature.Template.HasAnyChar())
            {
                return entryPoint;
            }
            Html.Take(entryPoint).InnerHTML(feature.Template);
            BindingTemplate(entryPoint, this);
            var innerEntry = entryPoint.FilterElement(x => x.Id == "inner-entry").FirstOrDefault();
            ResetEntryPoint(innerEntry);
            var res = innerEntry ?? entryPoint;
            if (res.Style.Display.ToString() == Display.None.ToString())
            {
                res.Style.Display = string.Empty;
            }
            return res;
        }

        private void ResetEntryPoint(HTMLElement entryPoint)
        {
            if (entryPoint != null)
            {
                entryPoint.InnerHTML = string.Empty;
            }
        }

        public void BindingTemplate(HTMLElement ele, EditableComponent parent, bool isLayout = false, object entity = null,
            Func<HTMLElement, Component, EditableComponent, bool, object, EditableComponent> factory = null, HashSet<HTMLElement> visited = null)
        {
            if (visited is null)
            {
                visited = new HashSet<HTMLElement>();
            }
            if (ele is null || visited.Contains(ele))
            {
                return;
            }
            visited.Add(ele);
            if (ele.Children.Length == 0 && RenderCellText(ele, entity, isLayout) != null)
            {
                return;
            }
            Component component = null;
            foreach (var prop in typeof(Component).GetProperties().Where(x => x.CanRead && x.CanWrite))
            {
                var value = ele.Dataset[prop.Name.ToLower()];
                if (value == null)
                {
                    continue;
                }
                object propVal = null;
                try
                {
                    propVal = prop.PropertyType == typeof(string) ? value : Utils.ChangeType(value, prop.PropertyType);
                    component = component ?? new Component();
                    component.SetPropValue(prop.Name, propVal);
                }
                catch
                {
                    continue;
                }
            }
            var newCom = factory?.Invoke(ele, component, parent, isLayout, entity) ?? BindingData(ele, component, parent, isLayout, entity);
            parent = newCom is Section ? newCom : parent;
            ele.Children.ForEach(child => BindingTemplate(child, parent, isLayout, entity, factory, visited));
        }

        private static CellText RenderCellText(HTMLElement ele, object entity, bool isLayout)
        {
            var text = ele.TextContent?.Trim();
            if (text.HasAnyChar() && text.StartsWith("{") && text.EndsWith("}"))
            {
                var cellText = new CellText(new Component
                {
                    FieldName = text.SubStrIndex(1, text.Length - 1)
                }, ele)
                { Entity = entity };
                if (isLayout && LayoutForm != null)
                {
                    LayoutForm.AddChild(cellText);
                }
                else
                {
                    cellText.Render();
                }
                return cellText;
            }
            return null;
        }

        public EditableComponent BindingData(HTMLElement ele, Component com, EditableComponent parent, bool isLayout, object entity)
        {
            EditableComponent child = null;
            if (ele is null)
            {
                return null;
            }
            if (com is null || com.ComponentType.IsNullOrEmpty())
            {
                return null;
            }
            if (com.ComponentType == nameof(Section))
            {
                child = new Section(ele)
                {
                    GuiInfo = com,
                };
            }
            else if (child is null)
            {
                var comType = com.ComponentType.IndexOf(".") >= 0 ? com.ComponentType : typeof(EditableComponent).Namespace + "." + com.ComponentType;
                /*@
                var typeConstuctor = eval(comType);
                if (typeConstuctor == null) return null;
                child = new typeConstuctor(com, ele);
                 */
            }
            child.ParentElement = child.ParentElement ?? ele.ParentElement;
            child.Entity = entity ?? child.EditForm?.Entity ?? LayoutForm.Entity;
            if (isLayout)
            {
                child.EditForm = parent as EditForm;
                child.Render();
                LayoutForm.Children.Add(child);
                child.ToggleShow(com.ShowExp);
                child.ToggleDisabled(com.DisabledExp);
            }
            else
            {
                parent.AddChild(child);
            }
            return child;
        }

        protected virtual async Task<object> LoadEntity()
        {
            if (!ShouldLoadEntity || Entity is null)
            {
                return null;
            }
            var id = Entity[IdField].As<int?>();
            if (id is null || id <= 0)
            {
                return null;
            }
            var entity = (await Client.LoadById($"{id.Value}")).Value.FirstOrDefault() ?? Entity;
            return entity;
        }

        private void LockUpdate()
        {
            var generalRule = Feature.FeaturePolicy.Where(x => x.RecordId == 0).ToArray();
            if (!Feature.IsPublic &&
                (generalRule.All(x => !x.CanWrite)
                || !Utils.IsOwner(Entity) && generalRule.All(x => !x.CanWriteAll)))
            {
                LockUpdateButCancel();
                return;
            }
            if (Entity is null)
            {
                return;
            }

            var insertedDate = Entity[nameof(Component.InsertedDate)].As<DateTime?>();
            var hardLock = Entity["Lock"].As<bool?>();
            if (insertedDate is null || insertedDate == DateTime.MinValue)
            {
                return;
            }

            var lockUpdatePolicy = Feature.FeaturePolicy
                .Where(x => x.EntityId == null && x.RoleId.HasValue && x.LockUpdateAfterCreated.HasValue)
                .Where(x => Client.Token.RoleIds.Contains(x.RoleId.Value));
            var lockUpdate = 0;
            if (lockUpdatePolicy.HasElement())
            {
                lockUpdate = lockUpdatePolicy.Max(x => x.LockUpdateAfterCreated.Value);
            }
            if (lockUpdate > 0 && DateTimeExt.GetBusinessDays(insertedDate.Value) > lockUpdate || hardLock.HasValue && hardLock.Value)
            {
                IsLock = true;
                LockUpdateButCancel();
            }
        }

        protected virtual void LockUpdateButCancel()
        {
            Disabled = true;
            this.SetDisabled(false, BtnCancel, BtnPrint);
        }

        private void SetFeatureProperties(Feature feature)
        {
            if (feature is null)
            {
                return;
            }

            Feature = feature;
            Element.AddClass(feature.ClassName);
            Html.Take(Element).Style(feature.Style);
            if (Icon.IsNullOrEmpty())
            {
                Icon = feature.Icon;
            }
            if (Title.IsNullOrEmpty())
            {
                Title = feature.Label;
            }
        }

        private void SetFeatureStyleSheet(string styleSheet)
        {
            if (styleSheet.IsNullOrWhiteSpace())
            {
                return;
            }
            var style = Document.CreateElement(ElementType.style.ToString()) as HTMLStyleElement;
            style.AppendChild(new Text(styleSheet));
            style.SetAttribute("source", "feature");
            Element.AppendChild(style);
        }

        public void RenderTabOrSection(IEnumerable<ComponentGroup> componentGroup)
        {
            foreach (var group in componentGroup.OrderBy(x => x.Order))
            {
                group.Disabled = Disabled || group.Disabled;
                if (group.IsTab)
                {
                    Section.RenderTabGroup(this, group);
                }
                else
                {
                    Section.RenderSection(this, group);
                }
            }
        }

        public int GetInnerColumn(ComponentGroup group)
        {
            if (group is null)
            {
                return 0;
            }

            var screenWidth = Element.ClientWidth;
            int? res;
            if (screenWidth < ExSmallScreen && group.XsCol > 0)
            {
                res = group.XsCol;
            }
            else if (screenWidth < SmallScreen && group.SmCol > 0)
            {
                res = group.SmCol;
            }
            else if (screenWidth < MediumScreen && group.Column > 0)
            {
                res = group.Column;
            }
            else if (screenWidth < LargeScreen && group.LgCol > 0)
            {
                res = group.LgCol;
            }
            else if (screenWidth < ExLargeScreen && group.XlCol > 0)
            {
                res = group.XlCol;
            }
            else
            {
                res = group.XxlCol ?? group.Column;
            }

            return res ?? 0;
        }

        internal int GetOuterColumn(ComponentGroup group)
        {
            var screenWidth = Element.ClientWidth;
            int? res;
            if (screenWidth < ExSmallScreen && group.XsOuterColumn > 0)
            {
                res = group.XsOuterColumn;
            }
            else if (screenWidth < SmallScreen && group.SmOuterColumn > 0)
            {
                res = group.SmOuterColumn;
            }
            else if (screenWidth < MediumScreen && group.OuterColumn > 0)
            {
                res = group.OuterColumn;
            }
            else if (screenWidth < LargeScreen && group.LgOuterColumn > 0)
            {
                res = group.LgOuterColumn;
            }
            else if (screenWidth < ExLargeScreen && group.XlOuterColumn > 0)
            {
                res = group.XlOuterColumn;
            }
            else
            {
                res = group.XxlOuterColumn ?? group.OuterColumn;
            }

            return res ?? 0;
        }

        public virtual void SysConfigMenu(Event e, Component component, ComponentGroup group)
        {
            if (!Client.SystemRole)
            {
                return;
            }
            var menuItems = new List<ContextMenuItem>()
            {
                new ContextMenuItem { Icon = "fas fa-link mt-2", Text = "Add Link", Click = AddComponent, Parameter = new { group = group, action = "AddLink" } },
                new ContextMenuItem { Icon = "fas fa-plus-circle mt-2", Text = "Add Input", Click = AddComponent, Parameter = new { group = group, action = "AddInput" } },
                new ContextMenuItem { Icon = "fas fa-plus-circle mt-2", Text = "Add Timepicker", Click = AddComponent, Parameter = new { group = group, action = "AddTimepicker" } },
                new ContextMenuItem { Icon = "fas fa-lock mt-2", Text = "Add Password", Click = AddComponent, Parameter = new { group = group, action = "AddPassword" } },
                new ContextMenuItem { Icon = "fas fa-plus-circle mt-2", Text = "Add Label", Click = AddComponent, Parameter = new { group = group, action = "AddLabel" } },
                new ContextMenuItem { Icon = "fas fa-plus-circle mt-2", Text = "Add Textarea", Click = AddComponent, Parameter = new { group = group, action = "AddTextarea" } },
                new ContextMenuItem { Icon = "fas fa-plus-circle mt-2", Text = "Add Dropdown", Click = AddComponent, Parameter = new { group = group, action = "AddDropdown" } },
                new ContextMenuItem { Icon = "fas fa-images mt-2", Text = "Add Image", Click = AddComponent, Parameter = new { group = group, action = "AddImage" } },
                new ContextMenuItem { Icon = "fas fa-plus-circle mt-2", Text = "Add GridView", Click = AddComponent, Parameter = new { group = group, action = "AddGridView" } },
                new ContextMenuItem { Icon = "fas fa-plus-circle mt-2", Text = "Add ListView", Click = AddComponent, Parameter = new { group = group, action = "AddListView" } },
            };
            e.PreventDefault();
            e.StopPropagation();
            var ctxMenu = ContextMenu.Instance;
            ctxMenu.Top = e.Top();
            ctxMenu.Left = e.Left();
            ctxMenu.MenuItems = new List<ContextMenuItem>
            {
                    component is null ? null : new ContextMenuItem { Icon = "fal fa-cog", Text = "Tùy chọn dữ liệu", Click = ComponentProperties, Parameter = component },
                    component is null ? null : new ContextMenuItem { Icon = "fal fa-clone", Text = "Sao chép", Click = CoppyComponent, Parameter = component },
                    _componentCoppy is null ? null : new ContextMenuItem { Icon = "fal fa-paste", Text = "Dán", Click = PasteComponent, Parameter = group },
                    new ContextMenuItem { Icon = "fal fa-cogs", Text = "Thêm Component", MenuItems = menuItems },
                    new ContextMenuItem { Icon = "fal fa-cogs", Text = "Tùy chọn vùng dữ liệu", Click = SectionProperties, Parameter = group },
                    new ContextMenuItem { Icon = "fal fa-clone", Text = "Clone vùng dữ liệu", Click = CloneProperties, Parameter = group },
                    new ContextMenuItem { Icon = "fal fa-folder-open", Text = "Thiết lập chung", Click = FeatureProperties },
                    new ContextMenuItem { Icon = "fal fa-clone", Text = "Clone feature", Click = CloneFeature, Parameter = Feature },
            };
            ctxMenu.Render();
        }

        public void CloneFeature(object ev)
        {
            var feature = ev as Feature;
            var confirmDialog = new ConfirmDialog
            {
                Content = "Bạn có muốn clone feature này?",
                Title = "Xác nhận"
            };
            confirmDialog.YesConfirmed += async () =>
            {
                var client = new Client(nameof(Feature));
                await client.CloneFeatureAsync(feature.Id);
            };
            AddChild(confirmDialog);
        }

        public FeaturePolicy[] GetElementPolicies(int[] recordIds, int entityId = Utils.ComponentGroupId) // Default of component group
        {
            var hasHidden = Feature.FeaturePolicy
                    .Where(x => x.RoleId.HasValue && Client.Token.AllRoleIds.Contains(x.RoleId.Value) || (x.UserId.HasValue && Client.Token.UserId == x.UserId))
                    .Where(x => x.EntityId == entityId && recordIds.Contains(x.RecordId))
                    .ToArray();
            return hasHidden;
        }

        public FeaturePolicy[] GetGridPolicies(int[] recordIds, int entityId = Utils.ComponentGroupId) // Default of component group
        {
            var hasHidden = Feature.FeaturePolicy
                    .Where(x => x.RoleId.HasValue && Client.Token.AllRoleIds.Contains(x.RoleId.Value) || (x.UserId.HasValue && Client.Token.UserId == x.UserId))
                    .Where(x => x.EntityId == entityId && recordIds.Contains(x.RecordId))
                    .ToArray();
            return hasHidden;
        }

        public FeaturePolicy[] GetElementPolicies(int recordId, int entityId = Utils.ComponentId) // Default of component
        {
            var hasHidden = Feature.FeaturePolicy
                    .Where(x => x.RoleId.HasValue && Client.Token.AllRoleIds.Contains(x.RoleId.Value) || (x.UserId.HasValue && Client.Token.UserId == x.UserId))
                    .Where(x => x.EntityId == entityId && recordId == x.RecordId)
                    .ToArray();
            return hasHidden;
        }

        public FeaturePolicy[] GetGridPolicies(int recordId, int entityId = Utils.ComponentId) // Default of component
        {
            var hasHidden = Feature.FeaturePolicy
                    .Where(x => (x.RoleId.HasValue && Client.Token.AllRoleIds.Contains(x.RoleId.Value)) || (x.UserId.HasValue && Client.Token.UserId == x.UserId))
                    .Where(x => x.EntityId == entityId && recordId == x.RecordId)
                    .ToArray();
            return hasHidden;
        }

        public void HeaderProperties(object arg)
        {
            var editor = new HeaderEditor() { Entity = arg, ParentElement = Element };
            AddChild(editor);
        }

        public void ComponentProperties(object arg)
        {
            var component = arg.CastProp<Component>();
            component.ComponentGroup = null;
            var editor = new ComponentBL()
            {
                Entity = component,
                ParentElement = Element,
                OpenFrom = this.FindClosest<EditForm>(),
            };
            AddChild(editor);
        }

        public void CoppyComponent(object arg)
        {
            var component = arg.CastProp<Component>();
            _componentCoppy = component;
        }

        public void PasteComponent(object arg)
        {
            var componentGroup = arg.CastProp<ComponentGroup>();
            _componentCoppy.ComponentGroupId = componentGroup.Id;
            Task.Run(async () =>
            {
                _componentCoppy.Id = 0;
                var client = await new Client(nameof(Component)).CreateAsync(_componentCoppy);
                _componentCoppy = null;
                Toast.Success("Sao chép thành công!");
            });
        }

        public void AddComponent(object arg)
        {
            var action = arg["action"].CastProp<string>();
            var componentGroup = arg["group"].CastProp<ComponentGroup>();
            var com = new Component();
            var childComponent = Feature.ComponentGroup.FirstOrDefault(x => x.Id == componentGroup.Id);
            var lastOrder = childComponent.Component.Max(x => x.Order);

            switch (action)
            {
                case "AddLink":
                    com.ComponentType = nameof(Link);
                    com.Visibility = true;
                    com.Order = lastOrder;
                    com.ComponentGroupId = componentGroup.Id;
                    com.FieldName = "";
                    com.Label = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
                case "AddInput":
                    com.ComponentType = "Input";
                    com.Visibility = true;
                    com.Order = lastOrder;
                    com.ComponentGroupId = componentGroup.Id;
                    com.FieldName = "";
                    com.Label = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
                case "AddTimepicker":
                    com.ComponentType = nameof(Timepicker);
                    com.Visibility = true;
                    com.Order = lastOrder;
                    com.ComponentGroupId = componentGroup.Id;
                    com.FieldName = "";
                    com.Label = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
                case "AddPassword":
                    com.ComponentType = "Password";
                    com.Visibility = true;
                    com.Order = lastOrder;
                    com.ComponentGroupId = componentGroup.Id;
                    com.FieldName = "";
                    com.Label = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
                case "AddLabel":
                    com.ComponentType = "Label";
                    com.Visibility = true;
                    com.Order = lastOrder;
                    com.ComponentGroupId = componentGroup.Id;
                    com.FieldName = "";
                    com.ShowLabel = true;

                    var confirm = new ConfirmDialog
                    {
                        NeedAnswer = true,
                        ComType = nameof(Textbox),
                        Content = "Hãy nhập label?",
                    };

                    confirm.Render();
                    confirm.YesConfirmed += () =>
                    {
                        com.Label = confirm.Textbox?.Text;
                        Task.Run(async () =>
                        {
                            var client = await new Client(nameof(Component)).CreateAsync<Component>(com);
                            UpdateRender(client, componentGroup);
                            Toast.Success("Tạo thành công!");
                        });
                    };
                    break;
                case "AddTextarea":
                    com.ComponentType = "Textarea";
                    com.Visibility = true;
                    com.Order = lastOrder;
                    com.ComponentGroupId = componentGroup.Id;
                    com.FieldName = "";
                    com.Label = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
                case "AddDropdown":
                    com.ComponentType = "Dropdown";
                    com.Visibility = true;
                    com.Order = lastOrder;
                    com.ComponentGroupId = componentGroup.Id;
                    com.FieldName = "";
                    com.Label = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
                case "AddImage":
                    com.ComponentType = "Image";
                    com.Visibility = true;
                    com.Order = lastOrder;
                    com.ComponentGroupId = componentGroup.Id;
                    com.FieldName = "";
                    com.Label = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
                case "AddGridView":
                    com.ComponentType = nameof(GridView);
                    com.Visibility = true;
                    com.DataSourceFilter = "?$filter=Active eq true";
                    com.Label = "";
                    com.ComponentGroupId = componentGroup.Id;
                    com.Order = lastOrder;
                    com.FieldName = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
                case "AddListView":
                    com.ComponentType = nameof(ListView);
                    com.Visibility = true;
                    com.DataSourceFilter = "?$filter=Active eq true";
                    com.Label = "";
                    com.ComponentGroupId = componentGroup.Id;
                    com.Order = lastOrder;
                    com.FieldName = "";
                    Task.Run(async () =>
                    {
                        var client = await new Client(nameof(Component)).CreateAsync(com);
                        UpdateRender(com, componentGroup);
                        Toast.Success("Tạo thành công!");
                    });
                    break;
            }
        }

        private void UpdateRender(Component component, ComponentGroup componentGroup)
        {
            var section = this.FindComponentByName<Section>(componentGroup.Name);
            var childComponent = ComponentFactory.GetComponent(component, EditForm);
            childComponent.ParentElement = section.Element;
            section.AddChild(childComponent);
        }

        public void SectionProperties(object arg)
        {
            var group = arg.CastProp<ComponentGroup>();
            group.InverseParent = null;
            var editor = new ComponentGroupBL
            {
                Entity = group,
                ParentElement = Element,
                OpenFrom = this.FindClosest<EditForm>()
            };
            AddChild(editor);
        }

        public void CloneProperties(object arg)
        {
            var group = arg.CastProp<ComponentGroup>();
            ConfirmDialog.RenderConfirm($"Clone the section CG{group.Id:0000000}?", async () =>
            {
                group.InverseParent = null;
                group.Component = null;
                group.Id = 0;
                await new Client(nameof(ComponentGroup)).CreateAsync(group);
                Toast.Success("Clone thành công");
            });
        }

        public void FeatureProperties(object arg)
        {
            var editor = new FeatureDetailBL()
            {
                Entity = Feature,
                ParentElement = this.FindClosest<EditForm>().Element,
                OpenFrom = this.FindClosest<EditForm>(),
            };
            AddChild(editor);
        }

        public void SecurityRecord(object arg)
        {
            var security = new SecurityBL
            {
                Entity = arg,
                ParentElement = Element
            };
            TabEditor.AddChild(security);
        }

        public virtual void Cancel()
        {
            DirtyCheckAndCancel();
        }

        public virtual void CancelWithoutAsk() => Dispose();

        public override void Dispose()
        {
            Client = null;
            Window.RemoveEventListener(EventType.Resize, ResizeHandler);
            base.Dispose();
        }

        public virtual void DirtyCheckAndCancel() => DirtyCheckAndCancel(null);
        public virtual void DirtyCheckAndCancel(Action closeCallback)
        {
            Dispose();
            //if (!Dirty)
            //{
            //    Dispose();
            //    return;
            //}
            //_confirm = new ConfirmDialog()
            //{
            //    Content = "Bạn có muốn lưu dữ liệu trước khi đóng?"
            //};
            //_confirm.YesConfirmed += async () =>
            //{
            //    await SaveAndLeaveAsync();
            //    closeCallback?.Invoke();
            //};
            //_confirm.NoConfirmed += () =>
            //{
            //    Dispose();
            //    closeCallback?.Invoke();
            //};
            //_confirm.IgnoreCancelButton = true;
            //_confirm.Render();
        }

        private async Task SaveAndLeaveAsync()
        {
            var success = await Save();
            if (!success)
            {
                return;
            }

            Dispose();
        }

        public virtual async Task EmailPdf(EmailVM email, params string[] pdfSelector)
        {
            if (email is null)
            {
                throw new ArgumentNullException(nameof(email));
            }
            if (pdfSelector.HasElement())
            {
                var pdfText = pdfSelector.Select(x =>
                {
                    var ele = Element.QuerySelector(x) as HTMLElement;
                    return PrintSection(ele, false);
                });
                email.PdfText.AddRange(pdfText);
            }
            var sucess = await Client.PostAsync<bool>(email, "EmailAttached", allowNested: true);
            if (sucess)
            {
                Toast.Success("Gởi email thành công!");
            }
        }

        public virtual void Print(string selector = ".printable")
        {
            var printable = Element.QuerySelector(selector) as HTMLElement;
            PrintSection(printable);
        }

        public string PrintSection(HTMLElement ele, bool openWindow = true, List<string> styles = null, bool printPreview = false, Component component = null)
        {
            if (ele is null)
            {
                return null;
            }
            if (!openWindow)
            {
                return ele.InnerHTML;
            }
            var printWindow = Window.Open("", "_blank");
            printWindow.Document.Body.InnerHTML = ele.InnerHTML;
            printWindow.Document.Close();
            if (printPreview)
            {
                Window.SetTimeout(() =>
                {
                    printWindow.AddEventListener(EventType.BeforePrint, e =>
                    {
                        var pageStyle = printWindow.Document.CreateElement(MVVM.ElementType.style.ToString());
                        pageStyle.InnerHTML = component.Style;
                        printWindow.Document.Head.AppendChild(pageStyle);
                    });
                    printWindow.Print();
                    printWindow.AddEventListener(EventType.AfterPrint, async e =>
                    {
                        await this.DispatchEventToHandlerAsync(component.Events, EventType.AfterPrint, this);
                    });
                    printWindow.AddEventListener(EventType.MouseMove, e => printWindow.Close());
                    printWindow.AddEventListener(EventType.Click, e => printWindow.Close());
                    printWindow.AddEventListener(EventType.KeyUp, e => printWindow.Close());
                }, 250);
            }
            return ele.InnerHTML;
        }

        public override void Focus()
        {
            var ele = this.FirstOrDefault(x => x.GuiInfo != null && x.GuiInfo.Focus);
            if (ele is null)
            {
                Element.Focus();
            }
            else
            {
                ele.Focus();
            }
            ResizeHandler();
        }

        protected void UpdateViewByName(params string[] fieldNames)
        {
            if (fieldNames.Nothing())
            {
                return;
            }

            this.FilterChildren(x =>
            {
                if (fieldNames.Contains(x.Name))
                {
                    x.UpdateView();
                }

                return false;
            });
        }

        protected virtual void ResizeHandler()
        {
            ResizeTabGroup();
            ResizeListView();
        }

        public void ResizeListView()
        {
            var visibleListView = ListViews.FirstOrDefault(x => !x.Element.Hidden());
            if (visibleListView is null)
            {
                return;
            }

            var allListView = visibleListView.Parent.Children.Where(x => typeof(ListView).IsAssignableFrom(x.GetType()));
            var responsive = allListView.Any(x => x.Name.Contains("Mobile"));
            allListView.ForEach(x =>
            {
                if (responsive)
                {
                    x.Show = IsSmallUp ? !x.Name.Contains("Mobile") : x.Name.Contains("Mobile");
                    if (x.Show)
                    {
                        _currentListView = x as ListView;
                    }
                }
                else
                {
                    _currentListView = x as ListView;
                }
            });
        }

        public void ResizeTabGroup()
        {
            if (Element != null && Element.HasClass("mobile") || TabGroup.Nothing())
            {
                return;
            }

            TabGroup.ForEach(tg =>
            {
                if (tg is null || tg.Element is null)
                {
                    return;
                }

                if (IsLargeUp && tg.ComponentGroup.Responsive && tg.Element.ParentElement.HasClass("tab-horizontal"))
                {
                    tg.Element.ParentElement.ReplaceClass("tab-horizontal", "tab-vertical");
                }
                else if (!IsLargeUp && tg.ComponentGroup.Responsive && tg.Element.ParentElement.HasClass("tab-vertical"))
                {
                    tg.Element.ParentElement.ReplaceClass("tab-vertical", "tab-horizontal");
                }
            });
        }

        public void SetExpired()
        {
            var confirm = new ConfirmDialog
            {
                Content = "Bạn có chắc chắn muốn cài đặt hết hạn?",
            };
            confirm.Render();
            confirm.YesConfirmed += async () =>
            {
                Entity.ClearReferences();
                Entity.SetPropValue(ExpiredDate, DateTime.Now);
                UpdateView(componentNames: ExpiredDate);
                await AddOrUpdate(true);
            };
        }

        public virtual async Task RequestApprove()
        {
            var isValid = await IsFormValid();
            if (!isValid)
            {
                return;
            }
            var confirm = new ConfirmDialog
            {
                Content = "Bạn có chắc chắn gửi yêu cầu phê duyệt?",
            };
            confirm.Render();
            confirm.YesConfirmed += async () =>
            {
                Entity.ClearReferences();
                if (Entity[IdField].As<int>() <= 0)
                {
                    await Save();
                }
                var res = await RequestApprove(Entity);
                ProcessEnumMessage(res);
            };
        }

        public virtual void Delete()
        {
            var confirm = new ConfirmDialog
            {
                Content = "Bạn có chắc chắn xóa không?",
            };
            confirm.Render();
            confirm.YesConfirmed += async () =>
            {
                var success = await Client.HardDeleteAsync(new List<int>() { int.Parse(Entity[IdField].ToString()) });
                if (success)
                {
                    ParentForm.UpdateView(true);
                    Dispose();
                    Toast.Success("Xóa dữ liệu thành công");
                }
                else
                {
                    Toast.Warning("Xóa không thành công");
                }
            };
        }

        protected async Task<bool> RequestApprove(object entity)
        {
            entity.SetPropValue(StatusIdField, (int)ApprovalStatusEnum.Approving);
            var res = await Client.PostAsync<bool>(entity, "RequestApprove");
            return res;
        }

        protected virtual void ProcessEnumMessage(object res, bool showMessage = true)
        {
            if (res is null)
            {
                return;
            }
            if (showMessage)
            {
                Toast.Success(ResponseApproveEnum.Success.GetEnumDescription());
            }
            if (!(res is bool))
            {
                Entity.CopyPropFrom(res);
            }
            ParentForm?.UpdateView(true);
            Dispose();
        }

        public virtual async Task Approve()
        {
            var isValid = await IsFormValid();
            if (!isValid)
            {
                return;
            }
            var confirm = new ConfirmDialog
            {
                Content = "Bạn có chắc chắn muốn duyệt?",
            };
            confirm.Render();
            confirm.YesConfirmed += async () =>
            {
                await ApproveConfirmed();
            };
        }

        protected virtual async Task ApproveConfirmed()
        {
            await Approve(Entity);
        }

        protected async Task Approve(object entity)
        {
            var res = await Client.CreateAsync<bool>(entity, "Approve");
            ProcessEnumMessage(res);
        }

        public virtual void Reject()
        {
            var confirm = new ConfirmDialog
            {
                NeedAnswer = true,
                ComType = nameof(Textbox),
                Content = $"Bạn có chắc chắn muốn trả về?<br />" +
                    "Hãy nhập lý do trả về",
            };
            confirm.Render();
            confirm.YesConfirmed += async () =>
            {
                Entity.ClearReferences();
                var res = await Client.CreateAsync<object>(Entity, "Reject?reasonOfChange=" + confirm.Textbox?.Text);
                ProcessEnumMessage(res);
            };
        }

        protected virtual void ToggleApprovalBtn(object entity = null)
        {
            entity = entity ?? Entity;
            if (entity is null)
            {
                return;
            }
            var statusId = entity[StatusIdField].As<int>();
            this.SetShow(false, BtnSend, BtnApprove, BtnReject, BtnExpired);
            if (statusId == (int)ApprovalStatusEnum.Approved && !Feature.IsPublic)
            {
                LockUpdateButCancel();
                this.SetShow(false, BtnSave, BtnSend, BtnApprove, BtnReject);
                var expiredDate = entity[ExpiredDate].As<DateTime?>();
                if (expiredDate is null)
                {
                    this.SetShow(true, BtnExpired);
                    this.SetDisabled(false, BtnExpired);
                }
            }
            else if (statusId == (int)ApprovalStatusEnum.Approving && !Feature.IsPublic)
            {
                this.SetShow(true, BtnApprove, BtnReject);
                this.SetShow(false, BtnSend);
            }
            else
            {
                this.SetShow(true, BtnSend);
            }
        }

        public void CreateFeaturePolicyHeader(GridPolicy arg) => CreateFeaturePolicy(arg, arg.FeatureId, arg.Id);

        public void CreateFeaturePolicySection(ComponentGroup arg) => CreateFeaturePolicy(arg, arg.FeatureId);
        public async Task CreateFeaturePolicyComponent(Component arg)
        {
            var section = await new Client(nameof(ComponentGroup), typeof(User).Namespace).GetAsync<ComponentGroup>(arg.ComponentGroupId);
            CreateFeaturePolicy(arg, section.FeatureId);
        }

        public void CreateFeaturePolicy(object arg, int? featureId = null, int? recordId = null)
        {
            var isSecurityVM = arg is SecurityVM;
            var originalModel = arg is SecurityVM security ? security : null;
            var entityId = arg is Component ? Utils.ComponentId
                        : arg is ComponentGroup ? Utils.ComponentGroupId
                        : Utils.GridPolicyId;
            var detail = new SecurityEditorBL
            {
                Entity = originalModel ?? new SecurityVM
                {
                    FeatureId = featureId,
                    EntityId = entityId,
                    RecordIds = new int[] { recordId ?? arg[IdField].As<int?>() ?? 0 }
                },
            };
            detail.DOMContentLoaded += () =>
            {
                this.SetShow(false, nameof(FeaturePolicy.RecordId));
            };
            detail.AfterSaved += async (success) =>
            {
                if (isSecurityVM)
                {
                    return;
                }
                arg.SetPropValue(nameof(Component.IsPrivate), true);
                UpdateView(componentNames: nameof(Component.IsPrivate));
                await Save(false);
            };
            TabEditor.ActiveTab.AddChild(detail);
        }

        public void SignIn()
        {
            Client.UnAuthorizedEventHandler?.Invoke(null);
        }

        public async Task SignOut()
        {
            var e = Window.Instance["event"] as Event;
            e.PreventDefault();
            var client = new Client(nameof(User));
            await client.CreateAsync<bool>(Client.Token, "SignOut");
            Toast.Success("Bạn đã đăng xuất!", 3000);
            Client.SignOutEventHandler?.Invoke();
            Client.Token = null;
            NotificationClient?.Close();
            await Task.Delay(1000);
            LayoutForm?.UpdateView();
            Window.Location.Reload();
        }
    }
}
