namespace DXLocalizationEditor.Views.Utils {
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.Utils.Drawing;
    using DevExpress.Utils.Paint;

    sealed class HighlightPaint : XPaint {
        public static readonly XPaint Instance = new HighlightPaint();
        HighlightPaint() { }
        //
        string HighlightString;
        protected override void InternalDrawString(GraphicsCache cache, string s, Font font, Rectangle r, Brush foreBrush, StringFormat strFormat) {
            if(!string.IsNullOrEmpty(HighlightString) && s == HighlightString)
                cache.DrawRectangle(Pens.Red, r);
            base.InternalDrawString(cache, s, font, r, foreBrush, strFormat);
        }
        //
        internal static void SetHighlightString(string value) {
            ((HighlightPaint)Instance).HighlightString = value;
        }
        internal static void InvalidateControls(Control control) {
            if(control != null)
                control.Invalidate();
            foreach(Control child in control.Controls) 
                InvalidateControls(child);
        }
    }
}