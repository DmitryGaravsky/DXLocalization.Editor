namespace DXLocalizationEditor.Views {
    partial class StringIdView {
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ValueTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.stringIdViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OriginalValueTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForOriginalValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringIdViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalValueTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOriginalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ValueTextEdit);
            this.dataLayoutControl1.Controls.Add(this.OriginalValueTextEdit);
            this.dataLayoutControl1.DataSource = this.stringIdViewModelBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(22, 122, 650, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 150);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ValueTextEdit
            // 
            this.ValueTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stringIdViewModelBindingSource, "Value", true));
            this.ValueTextEdit.Location = new System.Drawing.Point(12, 85);
            this.ValueTextEdit.Name = "ValueTextEdit";
            this.ValueTextEdit.Size = new System.Drawing.Size(776, 53);
            this.ValueTextEdit.StyleController = this.dataLayoutControl1;
            this.ValueTextEdit.TabIndex = 6;
            // 
            // stringIdViewModelBindingSource
            // 
            this.stringIdViewModelBindingSource.DataSource = typeof(DXLocalizationEditor.ViewModels.StringIdViewModel);
            // 
            // OriginalValueTextEdit
            // 
            this.OriginalValueTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stringIdViewModelBindingSource, "OriginalValue", true));
            this.OriginalValueTextEdit.Location = new System.Drawing.Point(12, 12);
            this.OriginalValueTextEdit.Name = "OriginalValueTextEdit";
            this.OriginalValueTextEdit.Properties.ReadOnly = true;
            this.OriginalValueTextEdit.Size = new System.Drawing.Size(776, 53);
            this.OriginalValueTextEdit.StyleController = this.dataLayoutControl1;
            this.OriginalValueTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForOriginalValue,
            this.ItemForValue});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 150);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // ItemForOriginalValue
            // 
            this.ItemForOriginalValue.Control = this.OriginalValueTextEdit;
            this.ItemForOriginalValue.Location = new System.Drawing.Point(0, 0);
            this.ItemForOriginalValue.Name = "ItemForOriginalValue";
            this.ItemForOriginalValue.Size = new System.Drawing.Size(780, 57);
            this.ItemForOriginalValue.Text = "Original Value";
            this.ItemForOriginalValue.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForOriginalValue.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForOriginalValue.TextVisible = false;
            // 
            // ItemForValue
            // 
            this.ItemForValue.Control = this.ValueTextEdit;
            this.ItemForValue.Location = new System.Drawing.Point(0, 57);
            this.ItemForValue.Name = "ItemForValue";
            this.ItemForValue.Size = new System.Drawing.Size(780, 73);
            this.ItemForValue.Text = "Value";
            this.ItemForValue.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForValue.TextSize = new System.Drawing.Size(26, 13);
            // 
            // mvvmContext1
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXLocalizationEditor.ViewModels.StringIdViewModel);
            // 
            // StringIdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "StringIdView";
            this.Size = new System.Drawing.Size(800, 150);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValueTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringIdViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalValueTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOriginalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource stringIdViewModelBindingSource;
        private DevExpress.XtraEditors.MemoEdit ValueTextEdit;
        private DevExpress.XtraEditors.MemoEdit OriginalValueTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOriginalValue;
        private DevExpress.XtraLayout.LayoutControlItem ItemForValue;
    }
}
