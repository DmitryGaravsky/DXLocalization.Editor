namespace DXLocalizationEditor.ViewModels {
    using System;
    using System.ComponentModel.DataAnnotations;

    public class PreviewItem {
        readonly Lazy<IPreview> previewCore;
        public PreviewItem(Type type) {
            this.Type = type;
            this.previewCore = new Lazy<IPreview>(() => Activator.CreateInstance(Type) as IPreview);
        }
        [Display(AutoGenerateField = false)]
        public bool IsTargetCreated {
            get { return previewCore.IsValueCreated; }
        }
        [Display(AutoGenerateField = false)]
        public IPreview Target {
            get { return previewCore.Value; }
        }
        [Display(AutoGenerateField = false)]
        public Type Type {
            get;
            private set;
        }
        public static bool Match(Type type) {
            return typeof(IPreview).IsAssignableFrom(type);
        }
        public static bool Match(Type type, System.Type localizerType) {
            if(localizerType == null)
                return true;
            var attributes = type.GetCustomAttributes(typeof(PreviewAttribute), true);
            return (attributes.Length > 0) && localizerType.Assembly.GetName().Name.StartsWith(((PreviewAttribute)attributes[0]).Assembly);
        }
    }
}