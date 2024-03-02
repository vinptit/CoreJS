using Bridge.Html5;
using Core.Clients;
using Core.Components.Extensions;
using Core.Components.Forms;
using Core.Enums;
using Core.Extensions;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ElementType = Core.MVVM.ElementType;

namespace Core.Components
{
    internal class AdvancedDateSearch : PopupEditor
    {
        private GridView _filterGrid;
        private GridView _orderByGrid;
        private Datepicker _fromDateState;
        private Datepicker _toDateState;
        private readonly Type _entityType;
        private List<GridPolicy> _headers;

        public ListView ParentListView;
        public string ModelNameSpace { get; }
        private ListViewSearchVM SearchVM => Entity as ListViewSearchVM;
        public int _orderById = Client.Entities.Values.FirstOrDefault(x => x.Name == nameof(OrderBy)).Id;
        public int _fieldConditionId = Client.Entities.Values.FirstOrDefault(x => x.Name == nameof(FieldCondition)).Id;
        public int _gridPolicyId = Client.Entities.Values.FirstOrDefault(x => x.Name == nameof(GridPolicy)).Id;
        public int _entityId = Client.Entities.Values.FirstOrDefault(x => x.Name == nameof(Entity)).Id;

        public AdvancedDateSearch(ListView parent) : base(nameof(GridPolicy))
        {
            Name = "AdvancedSearch";
            Title = "Tìm kiếm nâng cao";
            Icon = "fa fa-search-plus";
            ParentListView = parent;
            _entityType = Type.GetType((ParentListView.GuiInfo.Reference?.Namespace ?? Client.ModelNamespace) + ParentListView.GuiInfo.RefName);
            DOMContentLoaded += LocalRender;
        }

        public void LocalRender()
        {
            Entity = ParentListView.ListViewSearch.EntityVM;
            AddSection();
        }

        private Section AddSection()
        {
            var section = new Section(ElementType.div)
            {
                ComponentGroup = new ComponentGroup
                {
                    Column = 12,
                    Label = "Bộ lọc",
                    Active = true,
                    ClassName = "box-shadow",
                    Component = new List<Component>
                    {
                        new Component()
                        {
                            ComponentType = nameof(Datepicker),
                            Label = "Từ ngày",
                            ShowLabel = true,
                            FieldName = nameof(ParentListView.ListViewSearch.EntityVM.StartDate),
                            Column = 6,
                            Visibility = true,
                            Active = true,
                            Events = "{\"change\":\"ChangeDate\"}"
                        },
                        new Component()
                        {
                            ComponentType = nameof(Datepicker),
                            Label = "Đến ngày",
                            ShowLabel = true,
                            FieldName = nameof(ParentListView.ListViewSearch.EntityVM.EndDate),
                            Column = 6,
                            Visibility = true,
                            Active = true,
                            Events = "{\"change\":\"ChangeDate\"}"
                        },
                        new Component()
                        {
                            ComponentType = nameof(Number),
                            ShowLabel = true,
                            Label = "Giá trị",
                            FieldName = nameof(ParentListView.ListViewSearch.EntityVM.Value),
                            Column = 6,
                            Visibility = true,
                            Active = true,
                            Events = "{\"change\":\"ChangeDate\"}"
                        },
                        new Component()
                        {
                            ComponentType = nameof(Number),
                            ShowLabel = true,
                            Label = "Năm",
                            FieldName = nameof(ParentListView.ListViewSearch.EntityVM.Year),
                            Column = 6,
                            Visibility = true,
                            Active = true,
                            Events = "{\"change\":\"ChangeDate\"}"
                        },
                        new Component()
                        {
                            ComponentType = nameof(Checkbox),
                            Label = "Ngày",
                            ShowLabel = true,
                            FieldName = nameof(ParentListView.ListViewSearch.EntityVM.IsDay),
                            Column = 3,
                            Visibility = true,
                            Active = true,
                            Events = "{\"change\":\"ChangeDay\"}"
                        },
                        new Component()
                        {
                            ComponentType = nameof(Checkbox),
                            Label = "Tháng",
                            ShowLabel = true,
                            FieldName = nameof(ParentListView.ListViewSearch.EntityVM.IsMonth),
                            Column = 3,
                            Visibility = true,
                            Active = true,
                            Events = "{\"change\":\"ChangeMonth\"}"
                        },
                        new Component()
                        {
                            ComponentType = nameof(Checkbox),
                            Label = "Quý",
                            ShowLabel = true,
                            FieldName = nameof(ParentListView.ListViewSearch.EntityVM.IsWa),
                            Column = 3,
                            Visibility = true,
                            Active = true,
                            Events = "{\"change\":\"ChangeWa\"}"
                        },
                        new Component()
                        {
                            ComponentType = nameof(Checkbox),
                            Label = "Năm",
                            ShowLabel = true,
                            FieldName = nameof(ParentListView.ListViewSearch.EntityVM.IsYear),
                            Column = 3,
                            Visibility = true,
                            Active = true,
                            Events = "{\"change\":\"ChangeYear\"}"
                        }
                    }
                }
            };
            AddChild(section);
            section.ClassName = "box-shadow panel group";
            return section;
        }

        public void ChangeMonth()
        {
            SearchVM.IsDay = false;
            SearchVM.IsYear = false;
            SearchVM.IsWa = false;
            SearchVM.Value = null;
            ChangeDate();
        }

        public void ChangeDay()
        {
            SearchVM.IsYear = false;
            SearchVM.IsMonth = false;
            SearchVM.IsWa = false;
            SearchVM.Year = null;
            SearchVM.Value = null;
            ChangeDate();
        }

        public void ChangeWa()
        {
            SearchVM.IsYear = false;
            SearchVM.IsMonth = false;
            SearchVM.IsDay = false;
            SearchVM.Value = null;
            ChangeDate();
        }

        public void ChangeDate()
        {
            if (SearchVM.IsDay)
            {
                SearchVM.StartDate = DateTime.Now.Date;
                SearchVM.EndDate = DateTime.Now.Date;
                this.SetDisabled(true, nameof(SearchVM.Value), nameof(SearchVM.Year));
            }
            else if (SearchVM.IsMonth)
            {
                SearchVM.Value = SearchVM.Value ?? DateTime.Now.Month;
                SearchVM.Year = SearchVM.Year ?? DateTime.Now.Year;
                SearchVM.StartDate = new DateTime(SearchVM.Year.Value, SearchVM.Value.Value, 1);
                SearchVM.EndDate = (new DateTime(SearchVM.Year.Value, SearchVM.Value.Value, 1)).AddMonths(1).AddDays(-1);
                this.SetDisabled(false, nameof(SearchVM.Value), nameof(SearchVM.Year));
            }
            else if (SearchVM.IsWa)
            {
                SearchVM.Value = SearchVM.Value ?? (DateTime.Now.Month - 1) / 3 + 1;
                SearchVM.Year = SearchVM.Year ?? DateTime.Now.Year;
                SearchVM.StartDate = new DateTime(SearchVM.Year.Value, (SearchVM.Value.Value - 1) * 3 + 1, 1);
                SearchVM.EndDate = SearchVM.StartDate.Value.AddMonths(3).AddDays(-1);
                this.SetDisabled(false, nameof(SearchVM.Value), nameof(SearchVM.Year));
            }
            else if (SearchVM.IsYear)
            {
                SearchVM.Year = SearchVM.Year ?? DateTime.Now.Year;
                SearchVM.StartDate = new DateTime(SearchVM.Year.Value, 1, 1);
                SearchVM.EndDate = (new DateTime(SearchVM.Year.Value, 1, 1)).AddYears(1).AddDays(-1);
                this.SetDisabled(false, nameof(SearchVM.Year));
            }
            UpdateView();
        }

        public void ChangeYear()
        {
            SearchVM.IsDay = false;
            SearchVM.IsMonth = false;
            SearchVM.IsWa = false;
            SearchVM.Year = null;
            SearchVM.Value = null;
            ChangeDate();
        }

        private void AddFilters(Section section)
        {
            _fromDateState = new Datepicker(new Component
            {
                FieldName = nameof(ParentListView.ListViewSearch.EntityVM.StartDate),
                Column = 4,
                Label = "Từ ngày",
                ShowLabel = true,
                Validation = "[{\"Rule\": \"required\", \"Message\": \"{0} is required\"}]",
            });
            section.AddChild(_fromDateState);
            _toDateState = new Datepicker(new Component
            {
                FieldName = nameof(ParentListView.ListViewSearch.EntityVM.EndDate),
                Column = 4,
                Label = "Đến ngày",
                ShowLabel = true,
                Validation = "[{\"Rule\": \"required\", \"Message\": \"{0} is required\"}]",
            });
            section.AddChild(_toDateState);
        }

        public override void DirtyCheckAndCancel()
        {
            base.Dispose();
        }

        public async Task ApplyFilter()
        {
            ParentListView.ListViewSearch.UpdateView();
            await ParentListView.ActionFilter();
            base.Dispose();
        }
    }
}