using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20_RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Какой-то текст, который от другого текста не тексту отличается";
            using (WebClient webClient = new WebClient())
                line = webClient.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp");
            Match match = Regex.Match(line, "<Name>Доллар США</Name><Value>(.*?)</Value>");

            Console.WriteLine(match.Groups[1].Value);
           

            Console.ReadLine();
        }
    }
}
