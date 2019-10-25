using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph3
{
    class WiredPhone : Phone
    {
        public override void Call(int outputNumber)
        {
            Console.WriteLine($"Звоню с проводного телефона на номер {outputNumber}");
        }

        public override void Ring(int inputNumber)
        {
            Console.WriteLine($"Приймите вызов на ваш проводной телефон от {inputNumber}");
        }
    }
}
