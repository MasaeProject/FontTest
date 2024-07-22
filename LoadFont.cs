using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontTest
{
    internal class LoadFont
    {
        public PrivateFontCollection privateFonts = new PrivateFontCollection();
        public Font CurrentFont = null;
        public Exception LoadFontFromFile(string fontFilePath)
        {
            try
            {
                privateFonts.AddFontFile(fontFilePath);
                FontFamily fontFamily = privateFonts.Families[0];
                CurrentFont = new Font(fontFamily, 24);
            }
            catch (Exception ex)
            {
                return ex;
            }
            return null;
        }
        public string FontInfo()
        {
            if (CurrentFont != null)
            {
                return $"{CurrentFont.Name}, {CurrentFont.SizeInPoints}pt, {CurrentFont.Style}";
            }
            return "null";
        }
    }
}
