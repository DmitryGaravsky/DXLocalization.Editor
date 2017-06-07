namespace DXLocalizationEditor.Views.Data {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class HierarchicalRow : Row {
        HierarchicalRow(Row parent) {
            ParentID = (parent != null) ? parent.ID : -1;
        }
        [Display(Order = -1)]
        public int ParentID {
            get;
            private set;
        }
        public static HierarchicalRow CreateHierarchicalRow(HierarchicalRow parent, int seed) {
            return (HierarchicalRow)CreateRow(seed, () => new HierarchicalRow(parent));
        }
        public static object GetRows(int rows = 1000, int levels = 5) {
            var dataSource = new List<HierarchicalRow>(rows);
            int levelStep = (int)(Math.Log(rows, levels) + 0.5);
            int levelBegin = 0; int levelEnd = levelStep - 1;
            int parentLevelBegin = 0; int parentLevelEnd = 0;
            for(int i = 0; i < rows; i++) {
                if(i == levelEnd) {
                    parentLevelBegin = levelBegin;
                    parentLevelEnd = levelEnd;
                    levelEnd = levelBegin + (levelEnd - levelBegin) * levelStep;
                    levelBegin = i;
                }
                HierarchicalRow parent = null;
                if(parentLevelBegin >= 0 && parentLevelEnd > 0) {
                    int parentLevelSize = parentLevelEnd - parentLevelBegin;
                    parent = dataSource[parentLevelBegin + (i - levelBegin) % parentLevelSize];
                }
                dataSource.Add(HierarchicalRow.CreateHierarchicalRow(parent, i));
            }
            return dataSource;
        }
    }
}