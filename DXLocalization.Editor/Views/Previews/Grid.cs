using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using DXLocalizationEditor.Views.Utils;

namespace DXLocalizationEditor.Views {
    [Preview("DevExpress.XtraGrid")]
    public partial class Grid : UserControl, IPreview {
        public Grid() {
            InitializeComponent();
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            gridControl1.DataSource = Data.Row.GetRows();
            gridView1.BeginDataUpdate();
            gridView1.Columns["IsActive"].GroupIndex = 1;
            gridView1.Columns["Open"].GroupIndex = 2;
            gridView1.Columns["Open"].GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateYear;
            gridView1.GroupSummary.Add(summaryType: DevExpress.Data.SummaryItemType.Count, fieldName: "Open");
            gridView1.Columns["SID"].Summary.Add(DevExpress.Data.SummaryItemType.Count);
            gridView1.Columns["Age"].Summary.Add(DevExpress.Data.SummaryItemType.Average);
            gridView1.SetAutoFilterValue(gridView1.Columns["Age"], 35, DevExpress.XtraGrid.Columns.AutoFilterCondition.GreaterOrEqual);
            gridView1.EndDataUpdate();
            gridView1.ExpandAllGroups();
            gridView1.Columns["SID"].OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.True;
            gridView1.Columns["Age"].OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.True;
        }
        void IPreview.Show(Enum value) {
            if(value is GridStringId) {
                var name = Enum.GetName(typeof(GridStringId), value);
                var id = (GridStringId)value;
                // Menus
                if(name.StartsWith("MenuFooter")) {
                    ((GridViewPreview)gridView1).ShowMenu(GridMenuType.Summary, gridView1.Columns["Age"]);
                    return;
                }
                if(name.StartsWith("MenuColumn")) {
                    if(name.StartsWith("MenuColumnGroup"))
                        ((GridViewPreview)gridView1).ShowMenu(GridMenuType.Group, gridView1.Columns["Open"]);
                    else
                        ((GridViewPreview)gridView1).ShowMenu(GridMenuType.Column, gridView1.Columns["Age"]);
                    return;
                }
                if(name.StartsWith("MenuGroupPanel")) {
                    if(id <= GridStringId.MenuGroupPanelHide)
                        ((GridViewPreview)gridView1).ShowMenu(GridMenuType.Group, null);
                    else
                        ((GridViewPreview)gridView1).ShowMenu(GridMenuType.Group, gridView1.Columns["IsActive"]);
                    return;
                }
                // Customization
                if(name.Contains("Customization"))
                    gridView1.ShowCustomization();
                else
                    gridView1.HideCustomization();
                // Filters
                if(name.StartsWith("PopupFilter"))
                    ((GridViewPreview)gridView1).ShowFilterPopup(gridView1.Columns["SID"], FilterPopupMode.CheckedList);
                if(name.StartsWith("FilterEditor"))
                    gridView1.ShowFilterEditor(gridView1.Columns["Age"]);
                if(name.StartsWith("CustomFilterDialog"))
                    gridView1.ShowCustomFilterDialog(gridView1.Columns["Age"]);
                HighlightPaint.InvalidateControls(gridControl1);
            }
        }
        class GridViewPreview : DevExpress.XtraGrid.Views.Grid.GridView {
            internal void ShowMenu(GridMenuType type, GridColumn column) {
                Rectangle columnBounds = Rectangle.Empty;
                if(type == GridMenuType.Column)
                    columnBounds = ViewInfo.ColumnsInfo[column].CaptionRect;
                if(type == GridMenuType.Group) {
                    if(column == null)
                        columnBounds = ViewInfo.GroupPanel.Rows[0].Bounds;
                    else
                        columnBounds = ViewInfo.GroupPanel.Rows[0].ColumnsInfo[column].CaptionRect;
                }
                if(type == GridMenuType.Summary)
                    columnBounds = ViewInfo.FooterInfo.Cells[column.VisibleIndex].Bounds;
                if(!columnBounds.IsEmpty) {
                    DestroyCustomization();
                    var args = new DevExpress.Utils.DXMouseEventArgs(System.Windows.Forms.MouseButtons.Right, 1,
                        columnBounds.Left + columnBounds.Width / 2, columnBounds.Top + columnBounds.Height / 2, 0);
                    Handler.ProcessEvent(DevExpress.Utils.Controls.EventType.MouseDown, args);
                    //
                    HighlightPaint.InvalidateControls(GridControl);
                }
            }
            internal void ShowFilterPopup(GridColumn column, FilterPopupMode mode) {
                column.OptionsFilter.FilterPopupMode = mode;
                column.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.True;
                ShowFilterPopup(column);
                column.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.Default;
                column.OptionsFilter.FilterPopupMode = FilterPopupMode.Default;
            }
        }
    }
}