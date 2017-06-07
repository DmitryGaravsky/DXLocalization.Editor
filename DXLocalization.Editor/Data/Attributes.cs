namespace DXLocalizationEditor {
    using System;

    public sealed class PreviewAttribute : Attribute {
        public PreviewAttribute(string assembly) {
            Assembly = assembly;
        }
        public string Assembly {
            get;
            private set;
        }
    }
}