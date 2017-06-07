using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXLocalizationEditor.ViewModels;

namespace DXLocalizationEditor.Views {
    public partial class PreviewView : XtraUserControl, IPreviewService {
        public PreviewView() {
            InitializeComponent();
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            if(!mvvmContext.IsDesignMode) {
                mvvmContext.RegisterService(this);
                //
                var fluent = mvvmContext.OfType<PreviewViewModel>();
                fluent.WithEvent(this, "Load")
                    .EventToCommand(x => x.OnLoad());
            }
        }
        void IPreviewService.Show(IPreview preview) {
            var previewControl = preview as Control;
            previewControl.Dock = DockStyle.Fill;
            previewControl.Parent = hostPanel;
            previewControl.BringToFront();
        }
    }
}