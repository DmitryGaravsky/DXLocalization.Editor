namespace DXLocalizationEditor.Views {
    using System;
    using DevExpress.XtraLayout.Utils;
    using DXLocalizationEditor.ViewModels;

    public partial class StringIdView : DevExpress.XtraEditors.XtraUserControl {
        public StringIdView() {
            InitializeComponent();
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            if(!mvvmContext.IsDesignMode) {
                var fluent = mvvmContext.OfType<StringIdViewModel>();
                fluent.WithEvent(this, "Load")
                    .EventToCommand(x => x.OnLoad());
                fluent.SetObjectDataSourceBinding(stringIdViewModelBindingSource);
                //
                layoutControlGroup1.Visibility = CalcVisibility(fluent.ViewModel.Source);
                fluent.SetTrigger(x => x.Source, value =>
                    layoutControlGroup1.Visibility = CalcVisibility(value));
            }
        }
        //
        static LayoutVisibility CalcVisibility(StringId msg) {
            if(msg == null || msg == StringId.None)
                return LayoutVisibility.Never;
            return LayoutVisibility.Always;
        }
    }
}