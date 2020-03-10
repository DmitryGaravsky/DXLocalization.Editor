using System;
using System.Windows.Forms;
using DevExpress.Utils.Paint;
using DevExpress.XtraEditors;

namespace DXLocalizationEditor {
    static class Program {
        [STAThread]
        static void Main() {
            WindowsFormsSettings.SetPerMonitorDpiAware();
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Office2019Colorful);
            WindowsFormsSettings.FilterCriteriaDisplayStyle = FilterCriteriaDisplayStyle.Visual;
            //
            using(var paint = Views.Utils.HighlightPaint.Instance) {
                XPaint.CreateCustomPainter(paint);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainView());
            }
        }
    }
}