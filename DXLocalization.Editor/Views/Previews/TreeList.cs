using System;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Localization;
using DevExpress.XtraTreeList.Menu;
using DXLocalizationEditor.Views.Utils;

namespace DXLocalizationEditor.Views {
    [Preview("DevExpress.XtraTreeList")]
    public partial class TreeList : XtraUserControl, IPreview {
        public TreeList() {
            InitializeComponent();
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            treeList1.BeginUpdate();
            treeList1.CheckBoxFieldName = "IsActive";
            treeList1.DataSource = Data.HierarchicalRow.GetRows();
            treeList1.Columns["ParentID"].OptionsColumn.ShowInCustomizationForm = false;
            treeList1.Columns["SID"].SortOrder = System.Windows.Forms.SortOrder.Ascending;
            treeList1.Columns["SID"].SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count;
            treeList1.Columns["Age"].SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Average;
            treeList1.SetAutoFilterValue(treeList1.Columns["Age"], 35, DevExpress.XtraTreeList.Columns.AutoFilterCondition.GreaterOrEqual);
            treeList1.EndUpdate();
            treeList1.ExpandAll();
        }
        void IPreview.Show(Enum value) {
            if(value is TreeListStringId) {
                var name = Enum.GetName(typeof(TreeListStringId), value);
                var id = (TreeListStringId)value;
                // Menus
                if(name.StartsWith("MenuFooter")) {
                    ((TreeListPreview)treeList1).ShowMenu(TreeListMenuType.Summary, treeList1.Columns["Age"]);
                    return;
                }
                if(name.StartsWith("MenuColumn")) {
                    ((TreeListPreview)treeList1).ShowMenu(TreeListMenuType.Column, treeList1.Columns["Age"]);
                    return;
                }
                // Customization
                if(name.Contains("Customization"))
                    treeList1.ColumnsCustomization();
                else
                    treeList1.DestroyCustomization();
                // Filters
                if(name.StartsWith("PopupFilter"))
                    ((TreeListPreview)treeList1).ShowFilterPopup(treeList1.Columns["SID"], DevExpress.XtraTreeList.FilterPopupMode.CheckedList);
                if(name.StartsWith("FilterEditor"))
                    treeList1.ShowFilterEditor(treeList1.Columns["Age"]);
                HighlightPaint.InvalidateControls(treeList1);
            }
        }
        class TreeListPreview : DevExpress.XtraTreeList.TreeList {
            internal void ShowMenu(TreeListMenuType type, TreeListColumn column) {
                Rectangle columnBounds = Rectangle.Empty;
                if(type == TreeListMenuType.Column)
                    columnBounds = ViewInfo.ColumnsInfo[column].CaptionRect;
                if(type == TreeListMenuType.Summary)
                    columnBounds = ViewInfo.SummaryFooterInfo[column].ItemBounds;
                if(!columnBounds.IsEmpty) {
                    DestroyCustomization();
                    var args = new DevExpress.Utils.DXMouseEventArgs(System.Windows.Forms.MouseButtons.Right, 1,
                        columnBounds.Left + columnBounds.Width / 2, columnBounds.Top + columnBounds.Height / 2, 0);
                    Handler.OnMouseDown(args);
                    //
                    HighlightPaint.InvalidateControls(this);
                }
            }
            internal void ShowFilterPopup(TreeListColumn column, DevExpress.XtraTreeList.FilterPopupMode mode) {
                column.OptionsFilter.FilterPopupMode = mode;
                column.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.True;
                Focus(); 
                ShowFilterPopup(column);
                column.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.Default;
                column.OptionsFilter.FilterPopupMode = DevExpress.XtraTreeList.FilterPopupMode.Default;
            }
        }
    }
}