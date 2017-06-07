namespace DXLocalizationEditor.ViewModels {
    using System;

    public sealed class StringId {
        readonly Enum id;
        readonly Type localizerType;
        public StringId(Enum id, Type localizerType) {
            this.id = id;
            this.localizerType = localizerType;
        }
        public Enum Value {
            get { return id; }
        }
        public Type LocalizerType {
            get { return localizerType; }
        }
        //
        public static readonly StringId None = new StringId(null, null);
    }
}