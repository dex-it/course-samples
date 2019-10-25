using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph3
{
    public abstract class Phone
    {
        private int year;

        public string Company { get; set; }
        public string Model { get; set; }
        public int Year
        {
            get
            { return year; }
            set
            {
                year = (value < 1876 || value > DateTime.Today.Year)
                    ? value
                    : DateTime.Today.Year;
            }
        }

        public abstract void Call(int outputNumber);
        public abstract void Ring(int inputNumber);
    }
}
