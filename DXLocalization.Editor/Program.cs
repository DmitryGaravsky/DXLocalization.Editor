using System;
using System.Windows.Forms;
using DevExpress.Utils.Paint;
using DevExpress.XtraEditors;

namespace DXLocalizationEditor {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            WindowsFormsSettings.EnableFormSkins();
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2016 Colorful");
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