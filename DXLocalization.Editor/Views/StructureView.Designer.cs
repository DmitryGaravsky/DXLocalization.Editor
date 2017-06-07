namespace DXLocalizationEditor.Views {
    partial class StructureView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.layout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXLocalizationEditor.ViewModels.StructureViewModel);
            // 
            // treeList
            // 
            this.treeList.Appearance.Empty.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.Empty.Options.UseBackColor = true;
            this.treeList.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treeList.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeList.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.Row.Options.UseBackColor = true;
            this.treeList.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Location = new System.Drawing.Point(2, 38);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsFilter.ExpandNodesOnFiltering = true;
            this.treeList.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.treeList.OptionsView.ShowColumns = false;
            this.treeList.OptionsView.ShowHorzLines = false;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.OptionsView.ShowVertLines = false;
            this.treeList.Size = new System.Drawing.Size(196, 400);
            this.treeList.TabIndex = 0;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.treeList;
            this.searchControl1.Location = new System.Drawing.Point(8, 8);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.treeList;
            this.searchControl1.Size = new System.Drawing.Size(184, 20);
            this.searchControl1.StyleController = this.layout;
            this.searchControl1.TabIndex = 1;
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.Color.Transparent;
            this.layout.Controls.Add(this.treeList);
            this.layout.Controls.Add(this.searchControl1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Root = this.layoutControlGroup1;
            this.layout.Size = new System.Drawing.Size(200, 440);
            this.layout.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(200, 440);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem1.Name = "treeListitem";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 404);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.searchControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "searchControl1item";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 36);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // StructureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Name = "StructureView";
            this.Size = new System.Drawing.Size(200, 440);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraLayout.LayoutControl layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
