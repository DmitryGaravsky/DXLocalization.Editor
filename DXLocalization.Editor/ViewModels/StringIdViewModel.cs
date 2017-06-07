namespace DXLocalizationEditor.ViewModels {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using DevExpress.Mvvm;
    using FastAccessors.Monads;

    public class StringIdViewModel {
        public StringIdViewModel() {
            Source = StringId.None;
        }
        public void OnLoad() {
            Messenger.Default.Register<StringId>(this, OnStringId);
        }
        void OnStringId(StringId id) {
            Source = id ?? StringId.None;
        }
        [Display(AutoGenerateField = false)]
        public virtual StringId Source {
            get;
            protected set;
        }
        protected void OnSourceChanged() {
            OriginalValue = GetString(Source);
            Value = OriginalValue; // TODO
        }
        public virtual string OriginalValue {
            get;
            protected set;
        }
        public virtual string Value {
            get;
            set;
        }
        protected void OnOriginalValueChanged() {
            DXLocalizationEditor.Views.Utils.HighlightPaint.SetHighlightString(OriginalValue);
        }
        #region GetString
        static string GetString(StringId id) {
            return GetString(id.Value, id.LocalizerType);
        }
        static string GetString(Enum value, Type localizerType) {
            if(value == null || localizerType == null)
                return string.Empty;
            IDictionary stringTable = GetStringTable(localizerType);
            return stringTable.Contains(value) ? (string)stringTable[value] : string.Empty;
        }
        readonly static IDictionary<Type, IDictionary> stringTables = new Dictionary<Type, IDictionary>();
        readonly static IDictionary EmptyTable = new Dictionary<object, string>();
        static IDictionary GetStringTable(Type localizerType) {
            IDictionary stringTable;
            if(!stringTables.TryGetValue(localizerType, out stringTable)) {
                var localizer = Activator.CreateInstance(localizerType);
                stringTable = localizer.@ƒ(localizerType.BaseType, "stringTable") as IDictionary;
                stringTables.Add(localizerType, stringTable ?? EmptyTable);
            }
            return stringTable ?? EmptyTable;
        }
        #endregion GetString
    }
}