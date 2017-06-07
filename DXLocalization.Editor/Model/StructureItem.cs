namespace DXLocalizationEditor.ViewModels {
    using System;
    using System.ComponentModel.DataAnnotations;

    public class StructureItem {
        static int IDGenerator = 0;
        public StructureItem(string name, int parentId) {
            this.ID = (IDGenerator++);
            this.ParentID = parentId;
            this.Name = name;
        }
        public StructureItem(Type localizerType, int parentId)
            : this(localizerType.Name, parentId) {
            this.LocalizerType = localizerType;
        }
        public StructureItem(Enum value, Type localizerType, int parentId)
            : this(value.ToString(), parentId) {
            this.Value = value;
            this.LocalizerType = localizerType;
        }
        public int ID {
            get;
            private set;
        }
        public int ParentID {
            get;
            private set;
        }
        public string Name {
            get;
            private set;
        }
        [Display(AutoGenerateField = false)]
        public Enum Value {
            get;
            private set;
        }
        [Display(AutoGenerateField = false)]
        public Type LocalizerType {
            get;
            private set;
        }
    }
}