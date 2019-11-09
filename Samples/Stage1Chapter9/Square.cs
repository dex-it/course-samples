using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter9
{
    class Square : Rectangle
    {
        private const string name = "Квадрат";
        
        protected override string Name
        {
            get
            {
                return name;
            }
        }   

        public Square(decimal height = 0):base(height, height)
        {
            
        }


    }
}
