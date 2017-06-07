namespace DXLocalizationEditor.ViewModels {
    using System;
    using System.Linq;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;

    public class PreviewViewModel {
        public void OnLoad() {
            var types = typeof(PreviewViewModel).Assembly.GetTypes();
            Items = types
                .Where(t => t.IsPublic && !t.IsAbstract && !t.IsInterface && PreviewItem.Match(t))
                .Select(x => new PreviewItem(x)).ToArray();
            Messenger.Default.Register<StringId>(this, OnStringId);
        }
        public virtual PreviewItem SelectedItem {
            get;
            set;
        }
        public virtual PreviewItem[] Items {
            get;
            protected set;
        }
        protected virtual void OnItemsChanged() {
            SelectedItem = Items.FirstOrDefault();
        }
        protected virtual void OnSelectedItemChanged() {
            var previewService = this.GetService<IPreviewService>();
            if(previewService != null && SelectedItem != null)
                previewService.Show(SelectedItem.Target);
        }
        void OnStringId(StringId id) {
            Type localizerType = (id ?? StringId.None).LocalizerType;
            SelectedItem = Items.FirstOrDefault(x => PreviewItem.Match(x.Type, localizerType));
            if(SelectedItem != null && SelectedItem.IsTargetCreated) {
                if(!object.ReferenceEquals(StringId.None, id) && id.Value != null) {
                    var dispatcher = this.GetService<IDispatcherService>();
                    dispatcher.BeginInvoke(() =>
                    {
                        SelectedItem.Target.Show(id.Value);
                    });
                }
            }
        }
    }
}