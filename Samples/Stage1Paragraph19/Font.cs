using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph19
{
    public enum Colors
    {
        Black,
        Red,
        Yellow,
        Blue,
        Orange
    }

    [Serializable]
    public class Font
    {
        public int Size { get; set; }
        public Colors Color { get; set; }
        public bool isItalic { get; set; }
        public bool isBold { get; set; }
    }
}
