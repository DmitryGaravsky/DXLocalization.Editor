namespace DXLocalizationEditor.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Threading.Tasks;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;

    public class StructureViewModel {
        public virtual bool IsLoading {
            get;
            protected set;
        }
        public IEnumerable<StructureItem> Items {
            get;
            protected set;
        }
        public virtual StructureItem SelectedItem {
            get;
            set;
        }
        protected void OnSelectedItemChanged() {
            if(SelectedItem != null)
                Messenger.Default.Send(new StringId(SelectedItem.Value, SelectedItem.LocalizerType));
            else
                Messenger.Default.Send(StringId.None);
        }
        //
        public Task LoadItems() {
            return Task.Factory.StartNew(state =>
            {
                IsLoading = true;
                var items = new List<StructureItem>();
                for(int i = 0; i < keyTypes.Length; i++)
                    Load(keyTypes[i].Assembly, items);
                var dispatcher = state as IDispatcherService;
                Items = items;
                dispatcher.BeginInvoke(() =>
                {
                    IsLoading = false;
                    this.RaisePropertyChanged(x => x.Items);
                });
            }, this.GetService<IDispatcherService>());
        }
        readonly static Type XtraLocalizerType = typeof(DevExpress.Utils.Localization.XtraLocalizer<>);
        readonly static Type[] keyTypes = new Type[] { 
            typeof(DevExpress.Data.ResFinder),
            typeof(DevExpress.Utils.ResFinder),
            typeof(DevExpress.Printing.ResFinder),
            typeof(DevExpress.XtraEditors.BaseEdit),
            typeof(DevExpress.XtraLayout.LayoutControl),
            typeof(DevExpress.XtraGrid.GridControl),
            typeof(DevExpress.XtraTreeList.TreeList),
        };
        protected void Load(Assembly assembly, IList<StructureItem> items) {
            if(assembly == null)
                return;
            var assemblyItem = new StructureItem(assembly.GetName().Name, -1);
            items.Add(assemblyItem);
            Type[] types = GetTypes(assembly);
            for(int i = 0; i < types.Length; i++)
                Load(assemblyItem, types[i], items);
        }
        protected void Load(StructureItem assemblyItem, Type type, IList<StructureItem> items) {
            Type baseType = type.BaseType;
            if(baseType == null || baseType == typeof(object) || !baseType.IsClass)
                return;
            if(!baseType.IsGenericType || baseType.GetGenericTypeDefinition() != XtraLocalizerType)
                return;
            var arguments = baseType.GetGenericArguments();
            if(arguments.Length == 1 && arguments[0].IsEnum) {
                var typeItem = new StructureItem(arguments[0], assemblyItem.ID);
                items.Add(typeItem);
                Array values = Enum.GetValues(arguments[0]);
                for(int i = 0; i < values.Length; i++) {
                    Enum value = (Enum)values.GetValue(i);
                    items.Add(new StructureItem(value, type, typeItem.ID));
                }
            }
        }
        static Type[] GetTypes(Assembly assembly) {
            try {
                return assembly.GetTypes();
            }
            catch(ReflectionTypeLoadException e) {
                return e.Types;
            }
        }
    }
}