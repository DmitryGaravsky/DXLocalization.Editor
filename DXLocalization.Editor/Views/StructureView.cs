namespace DXLocalizationEditor.Views {
    using DevExpress.XtraTreeList;
    using DXLocalizationEditor.ViewModels;

    public partial class StructureView : DevExpress.XtraEditors.XtraUserControl {
        public StructureView() {
            InitializeComponent();
        }
        protected override void OnHandleCreated(System.EventArgs e) {
            base.OnHandleCreated(e);
            if(!mvvmContext.IsDesignMode) {
                var fluent = mvvmContext.OfType<StructureViewModel>();
                fluent.SetBinding(treeList, tree => tree.DataSource, x => x.Items);
                fluent.WithEvent(this, "Load")
                    .EventToCommand(x => x.LoadItems());
                fluent.SetTrigger(x => x.Items, _ =>
                    treeList.ExpandToLevel(0));
                fluent.WithEvent<FocusedNodeChangedEventArgs>(treeList, "FocusedNodeChanged")
                    .SetBinding(x => x.SelectedItem, args => GetStructureItem(args));
            }
        }
        StructureItem GetStructureItem(FocusedNodeChangedEventArgs args) {
            if(args.Node == null)
                return null;
            return treeList.GetRow(args.Node.Id) as StructureItem;
        }
    }
}