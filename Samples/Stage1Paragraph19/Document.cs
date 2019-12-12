using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph19
{
    [Serializable]
    public class Document
    {
        public Header docHeader { get; set; }
        public Content docContent { get; set; }

    }
}
