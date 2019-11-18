using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class Star: AstronomicalObject
    {
        protected bool LightEmission => true;

        public Star(string starName, decimal radius):base(starName, radius)
        {
            
        }
    }
}
