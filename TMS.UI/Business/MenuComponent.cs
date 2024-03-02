﻿using Bridge.Html5;
using Core.Models;
using Core.Clients;
using Core.Components;
using Core.Components.Extensions;
using Core.Components.Forms;
using Core.Components.Framework;
using Core.Extensions;
using Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElementType = Core.MVVM.ElementType;

namespace TMS.UI.Business
{
    public partial class MenuComponent : EditableComponent
    {
        public List<Feature> _feature;
        private const string ActiveClass = "active";
        public const string ASIDE_WIDTH = "44px";
        private static MenuComponent _instance;
        private bool _hasRender;
        private MenuComponent() : base(null)
        {

        }
        public static MenuComponent Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new MenuComponent();
                }

                return _instance;
            }
        }

        private void BuildFeatureTree(List<Feature> features)
        {
            var dic = features.Where(f => f.IsMenu).ToDictionary(f => f.Id);
            foreach (var menu in dic.Values)
            {
                if (menu.ParentId != null && dic.ContainsKey(menu.ParentId.Value))
                {
                    var parent = dic[menu.ParentId.Value];
                    if (parent.InverseParent is null)
                    {
                        parent.InverseParent = new List<Feature>();
                    }
                    else
                    {
                        parent.InverseParent.Add(menu);
                    }
                }
            }
            _feature = features.Where(f => f.ParentId == null && f.IsMenu).ToList();
        }

        public override void Render()
        {
            if (_hasRender)
            {
                return;
            }

            _hasRender = true;
            Task.Run(async () =>
            {
                var featureTask = new Client(nameof(Feature)).GetRawList<Feature>(
                    "?$expand=Entity($select=Name)&$filter=Active eq true and IsMenu eq true&$orderby=Order");
                var roles = string.Join("\\", Client.Token.RoleIds);
                var startAppTask = new Client(nameof(UserSetting)).GetRawList<UserSetting>("?$filter=Name eq 'StartApp'");
                await Task.WhenAll(featureTask, startAppTask);
                var feature = featureTask.Result;
                var startApps = startAppTask.Result.Combine(x => x.Value).Split(",").Select(x => x.TryParseInt() ?? 0).Distinct();
                BuildFeatureTree(feature);
                RenderKeyMenuItems(_feature);
                SearchMenu();
                var featureParam = Window.Location.PathName.Replace("/", "").Replace("-", " ");
                if (!featureParam.IsNullOrWhiteSpace())
                {
                    var currentFeature = feature.FirstOrDefault(x => x.Name == featureParam);
                    var id = Utils.GetUrlParam("Id");
                    if (currentFeature is null)
                    {
                        currentFeature = await new Client(nameof(Feature)).FirstOrDefaultAsync<Feature>($"?$expand=Entity&$filter=Name eq '{featureParam}'");
                        if (currentFeature is null)
                        {
                            return;
                        }
                        var entity = (await new Client(currentFeature.Entity.Name).GetRawList<object>($"?$filter=Id eq {id}", entityName: currentFeature.Entity.Name)).FirstOrDefault();
                        if (entity is null)
                        {
                            entity = new object();
                        }
                        var toret = Activator.CreateInstance(Type.GetType("TMS.API.Models." + currentFeature.Entity.Name));
                        toret.CopyPropFrom(entity);
                        await this.OpenTab(
                            id: currentFeature.Name + id,
                            featureName: currentFeature.Name,
                            factory: () =>
                            {
                                var type = Type.GetType(currentFeature.ViewClass);
                                var instance = Activator.CreateInstance(type) as TabEditor;
                                instance.Title = currentFeature.Label;
                                instance.SetPropValue("Entity", toret);
                                return instance;
                            });
                    }
                    else
                    {
                        await OpenFeature(currentFeature);
                    }
                }
                else
                {
                    await feature.Where(x => startApps.Contains(x.Id) || x.StartUp).ForEachAsync(OpenFeature);
                }
                DOMContentLoaded?.Invoke();
            });
            _btnBack = Document.GetElementById("btnBack");
            _btnToggle = Document.GetElementsByClassName("sidebar-toggle").ToArray();
            if (_btnBack is null)
            {
                return;
            }

            _btnBack.AddEventListener(EventType.Click, RoutingHandler);
            _btnToggle.ForEach(btn =>
            {
                btn.AddEventListener(EventType.Click, () => Show = !Show);
            });
        }

        private static DateTime _lastTimeBackPress;
        private const int _timeperiodToExit = 2000;
        private const string TranslateY50 = "translateY(-50%)";

        private void RoutingHandler()
        {
            PressToExit();
            if (TabEditor.ActiveTab is TabEditor currentTab)
            {
                currentTab.DirtyCheckAndCancel();
            }
        }

        private static void PressToExit()
        {
            /*@
            if (typeof(navigator.app) === 'undefined') return;
            */
            var time = DateTime.Now - _lastTimeBackPress;
            if (time.TotalMilliseconds < 2000)
            {
                /*@
                navigator.app.exitApp();
                */
                return;
            }
            _lastTimeBackPress = DateTime.Now;
            Toast.Small("Bấm quay lại 2 lần để thoát", 1000);
        }

        private void HideAll(HTMLElement current = null)
        {
            if (current is null)
            {
                current = Document.Body;
            }
            var activea = current.QuerySelectorAll("a.active");
            var activeLi = current.QuerySelectorAll("li.menu-open");
            activea.ForEach(x => x.RemoveClass(ActiveClass));
            activeLi.ForEach(x => x.RemoveClass("menu-open"));
        }

        private void AlterMainSectionWidth()
        {
            Element.TabIndex = -1;
            Element.Focus();
            Element.AddEventListener(EventType.FocusOut, () =>
            {
                Show = IsSmallUp;
            });
            Show = IsSmallUp;
        }

        private void HideAside()
        {
            Element.Style.Left = $"-{ASIDE_WIDTH}";
        }

        private void SearchMenu()
        {
            var search = Document.QuerySelector(".form-control-sidebar") as HTMLInputElement;
            search.AddEventListener(EventType.Input, (e) =>
            {
                e.PreventDefault();
                e.StopPropagation();
                Window.ClearTimeout(timeOut);
                timeOut = Window.SetTimeout(async () =>
                {
                    var features = await new Client(nameof(Feature)).GetRawList<Feature>(
                    $"?$expand=Entity($select=Name)&$filter=Active eq true and IsMenu eq true and Contains(Label,'{search.Value.Trim().ToLower()}')&$orderby=Order");
                    var dic = features.Where(f => f.IsMenu).ToDictionary(f => f.Id);
                    foreach (var menu in dic.Values)
                    {
                        if (menu.ParentId != null && dic.ContainsKey(menu.ParentId.Value))
                        {
                            var parent = dic[menu.ParentId.Value];
                            if (parent.InverseParent is null)
                            {
                                parent.InverseParent = new List<Feature>();
                            }
                            else
                            {
                                parent.InverseParent.Add(menu);
                            }
                        }
                    }
                    if (search.Value.IsNullOrWhiteSpace())
                    {
                        _feature = features.Where(f => f.ParentId == null && f.IsMenu).ToList();
                    }
                    else
                    {
                        _feature = features.Where(x => x.InverseParent.Nothing()).ToList();
                        _feature.ForEach(k => k.ParentId = null);
                    }
                    RenderKeyMenuItems(_feature);
                }, 300);
            });
        }

        private void RenderKeyMenuItems(IEnumerable<Feature> menuItems, bool nested = false)
        {
            Html.Take("#menu");
            Html.Instance.Clear();
            Html.Instance.Ul.ClassName("nav nav-pills nav-sidebar flex-column nav-child-indent").DataAttr("widget", "treeview").Attr("role", "menu").DataAttr("accordion", "false").ForEach(menuItems, (item, index) =>
            {
                if (item.IsGroup)
                {
                    Html.Instance.Li.ClassName("nav-header").Title(item.Label).End.Render();
                }
                else
                {
                    var check = item.InverseParent != null && item.InverseParent.Count > 0;
                    Html.Instance.Li.ClassName("nav-item")
                    .A.ClassName("nav-link")
                    .AsyncEvent(EventType.Click, MenuItemClick, item)
                    .Event(EventType.ContextMenu, FeatureContextMenu, item)
                    .Icon(item.Icon).ClassName("nav-icon").End.P.IText(item.Label);
                    if (check)
                    {
                        Html.Instance.I.ClassName("right fas fa-angle-left").End.Render();
                    }
                    Html.Instance.EndOf(ElementType.a).Render();
                    if (check)
                    {
                        RenderMenuItems(item.InverseParent.ToList(), nested: true);
                    }
                }
            });
        }

        private void RenderMenuItems(IEnumerable<Feature> menuItems, bool nested = false)
        {
            Html.Instance.Ul.ClassName("nav nav-treeview").ForEach(menuItems, (item, index) =>
            {
                var check = item.InverseParent != null && item.InverseParent.Count > 0;
                Html.Instance.Li.ClassName("nav-item")
                .A.ClassName("nav-link")
                .AsyncEvent(EventType.Click, MenuItemClick, item)
                .Event(EventType.ContextMenu, FeatureContextMenu, item)
                .Icon(item.Icon).ClassName("nav-icon").End.P.IText(item.Label);
                if (check)
                {
                    Html.Instance.I.ClassName("right fas fa-angle-left").End.Render();
                }
                Html.Instance.EndOf(ElementType.a).Render();
                if (check)
                {
                    RenderMenuItems(item.InverseParent.ToList(), nested: true);
                }
            });
        }

        private HTMLElement FindMenuItemByID(int id)
        {
            var activeLi = Document.QuerySelectorAll(".sidebar-items li");
            foreach (HTMLElement active in activeLi)
            {
                if (active.GetAttribute("data-feature").Equals(id.ToString()))
                {
                    return active;
                }
            }
            return null;
        }

        private HTMLElement _btnBack;
        private HTMLElement[] _btnToggle;
        private int timeOut;

        private void FeatureContextMenu(Event e, Feature feature)
        {
            if (!Client.SystemRole)
            {
                return;
            }

            e.PreventDefault();
            var ctxMenu = ContextMenu.Instance;
            {
                ctxMenu.Top = e.Top();
                ctxMenu.Left = e.Left();
                ctxMenu.MenuItems = new List<ContextMenuItem>
                {
                    new ContextMenuItem { Icon = "fa fa-plus", Text = "New feature", Click = EditFeature, Parameter = new Feature() },
                    new ContextMenuItem { Icon = "mif-unlink", Text = "Deactivate this feature", Click = Deactivate, Parameter = feature },
                    new ContextMenuItem { Icon = "fa fa-clone", Text = "Clone this feature", Click = CloneFeature, Parameter = feature },
                    new ContextMenuItem { Icon = "fa fa-list", Text = "Manage features", Click = FeatureManagement },
                    new ContextMenuItem { Icon = "fa fa-wrench", Text = "Properties", Click = EditFeature, Parameter = feature },
                };
            };
            ctxMenu.Render();
        }

        private void EditFeature(object ev)
        {
            var feature = ev as Feature;
            var editor = new FeatureDetailBL()
            {
                Entity = feature,
                ParentElement = Document.Body,
                OpenFrom = this.FindClosest<EditForm>(),
            };
            AddChild(editor);
        }

        private void CloneFeature(object ev)
        {
            var feature = ev as Feature;
            var confirmDialog = new ConfirmDialog
            {
                Content = "Bạn có muốn clone feature này?"
            };
            confirmDialog.YesConfirmed += async () =>
            {
                var client = new Client(nameof(Feature), typeof(Feature).Namespace);
                await client.CloneFeatureAsync(feature.Id);
            };
            AddChild(confirmDialog);
        }

        private void FeatureManagement(object ev)
        {
            var editor = new FeatureBL()
            {
                ParentElement = Document.Body,
                OpenFrom = this.FindClosest<EditForm>(),
            };
            AddChild(editor);
        }

        private void Deactivate(object ev)
        {
            var feature = ev as Feature;
            var confirmDialog = new ConfirmDialog();
            confirmDialog.Content = "Bạn có muốn deactivate feature này?";
            confirmDialog.YesConfirmed += async () =>
            {
                var client = new Client(nameof(Feature));
                await client.DeactivateAsync(new List<int> { feature.Id });
            };
            AddChild(confirmDialog);
        }

        private async Task MenuItemClick(Feature feature, Event e)
        {
            var a = e.Target as HTMLElement;
            if (!(a is HTMLAnchorElement))
            {
                a = a.Closest("a") as HTMLAnchorElement;
            }
            var li = a.Closest(ElementType.li.ToString());
            if (li.HasClass("menu-open"))
            {
                li.RemoveClass("menu-open");
                return;
            }
            HideAll(a.Closest("ul"));
            a.Focus();
            if (a.HasClass(ActiveClass))
            {
                a.RemoveClass(ActiveClass);
            }
            else
            {
                a.AddClass(ActiveClass);
            }
            if (li.HasClass("menu-open"))
            {
                li.RemoveClass("menu-open");
            }
            else
            {
                li.AddClass("menu-open");
            }
            await OpenFeature(feature);
        }

        private static void AlterPositionSubMenu(float top, HTMLElement li)
        {
            if (li is null)
            {
                return;
            }
            var ul = li.QuerySelector(ElementType.ul.ToString()) as HTMLElement;
            if (ul is null)
            {
                return;
            }
            ul.Style.Top = (top - 20) + Utils.Pixel;
            ul.Style.Bottom = null;
            ul.Style.Transform = null;
            var outOfVp = ul.OutOfViewport();
            if (outOfVp.Bottom)
            {
                ul.Style.Top = null;
                ul.Style.Bottom = (Document.Body.ClientHeight - top) + Utils.Pixel;
                outOfVp = ul.OutOfViewport();
                if (outOfVp.Top)
                {
                    ul.Style.Top = "50%";
                    ul.Style.Bottom = null;
                    ul.Style.Transform = TranslateY50;
                }
            }
        }

        private void FocusFeature(int parentFeatureID)
        {
            var li = FindMenuItemByID(parentFeatureID);
            if (li != null)
            {
                var activeLi = Document.QuerySelectorAll(".sidebar-items li.active");
                foreach (HTMLElement active in activeLi)
                {
                    if (active.Contains(li))
                    {
                        continue;
                    }
                    active.RemoveClass("active");
                }
                li.AddClass(ActiveClass);
                li.ParentElement.AddClass(ActiveClass);
            }
        }

        public static async Task OpenFeature(Feature feature)
        {
            if (feature is null || feature.ViewClass is null && feature.Entity is null)
            {
                return;
            }

            feature = await ComponentExt.LoadFeatureByName(feature.Name);
            Type type;
            if (feature.ViewClass != null)
            {
                type = Type.GetType(feature.ViewClass);
            }
            else
            {
                type = typeof(TabEditor);
            }
            var id = feature.Name + feature.Id;
            var exists = TabEditor.Tabs.FirstOrDefault(x => x.Id == id);
            if (exists != null)
            {
                exists.Focus();
            }
            else
            {
                var instance = Activator.CreateInstance(type) as EditForm;
                instance.Name = feature.Name;
                instance.Id = id;
                instance.Icon = feature.Icon;
                instance.Feature = feature;
                instance.Render();
            }
            if (!IsSmallUp)
            {
                Instance.Show = false;
            }
        }

        protected override void RemoveDOM()
        {
            Html.Take(".sidebar-wrapper").Clear();
        }

        public override void UpdateView(bool force = false, bool? dirty = null, params string[] componentNames)
        {
            // Not to do anything here
        }
    }
}
