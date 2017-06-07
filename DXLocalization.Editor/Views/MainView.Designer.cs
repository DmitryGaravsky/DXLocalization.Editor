namespace DXLocalizationEditor {
    partial class MainView {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.structureView1 = new DXLocalizationEditor.Views.StructureView();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.stringIdView1 = new DXLocalizationEditor.Views.StringIdView();
            this.hintView1 = new DXLocalizationEditor.Views.PreviewView();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.structureView1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(300, 713);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // structureView1
            // 
            this.structureView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structureView1.Location = new System.Drawing.Point(0, 0);
            this.structureView1.Name = "structureView1";
            this.structureView1.Size = new System.Drawing.Size(299, 713);
            this.structureView1.TabIndex = 0;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DXLocalizationEditor.ViewModels.MainViewModel);
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.AllowMoveTabsToOuterForm = false;
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.Size = new System.Drawing.Size(1366, 50);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 2;
            this.tabFormControl1.TabLeftItemLinks.Add(this.barButtonItem1);
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.TitleTabVerticalOffset = 10;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage1.Text = "Main";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.hintView1);
            this.tabFormContentContainer1.Controls.Add(this.sidePanel2);
            this.tabFormContentContainer1.Controls.Add(this.sidePanel1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 50);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1366, 713);
            this.tabFormContentContainer1.TabIndex = 3;
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowSnap = false;
            this.sidePanel2.Controls.Add(this.stringIdView1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel2.Location = new System.Drawing.Point(300, 563);
            this.sidePanel2.MinimumSize = new System.Drawing.Size(0, 100);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1066, 150);
            this.sidePanel2.TabIndex = 1;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // stringIdView1
            // 
            this.stringIdView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stringIdView1.Location = new System.Drawing.Point(0, 1);
            this.stringIdView1.Name = "stringIdView1";
            this.stringIdView1.Size = new System.Drawing.Size(1066, 149);
            this.stringIdView1.TabIndex = 0;
            // 
            // hintView1
            // 
            this.hintView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintView1.Location = new System.Drawing.Point(300, 0);
            this.hintView1.Name = "hintView1";
            this.hintView1.Size = new System.Drawing.Size(1066, 563);
            this.hintView1.TabIndex = 2;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 763);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "DXLocalization Editor";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private Views.StructureView structureView1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private Views.StringIdView stringIdView1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private Views.PreviewView hintView1;
    }
}

