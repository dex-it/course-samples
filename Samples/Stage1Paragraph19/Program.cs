using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Stage1Paragraph19
{
    class Program
    {
        static Document CreateDocument()
        {
            Font headFont = new Font { Size = 16, Color = Colors.Orange, isItalic = false, isBold = true };
            Font contFont = new Font { Size = 12, Color = Colors.Black, isItalic = false, isBold = false };

            string headText = "Сериализация";
            string contText = "Сериализация - процесс перевода какой-либо структуры данных в форму удобную для" +
                              " сохранения или передачи(байты или текст).";

            Header header = new Header { HeaderFont = headFont, Text = headText };
            Content content = new Content { ContentFont = contFont, Text = contText };

            return new Document { docHeader = header, docContent = content };
        }

        static void Main(string[] args)
        {
            Document myDocument = CreateDocument();
            BinaryFormatter bf = new BinaryFormatter();

            // сериализация
            using (var fs = new FileStream("myDocument.dat", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                bf.Serialize(fs, myDocument);
            }

            // десериализация
            using (var fs = new FileStream("myDocument.dat", FileMode.Open))
            {
                Document newDocument = (Document)bf.Deserialize(fs);
            }
        }
    }
}