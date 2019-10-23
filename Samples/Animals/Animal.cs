using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        string name = "Unknown";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
