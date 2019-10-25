using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph3
{
    public class CellPhone : Phone
    {
        public int WorkInHours { get; set; }

        public override void Call(int outputNumber)
        {
            Console.WriteLine($"Звоню с мобильного телефона на номер {outputNumber}");
        }

        public override void Ring(int inputNumber)
        {
            Console.WriteLine($"Приймите вызов на ваш мобильный телефон от {inputNumber}");
        }
    }
}
