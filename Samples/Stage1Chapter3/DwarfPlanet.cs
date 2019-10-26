using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class DwarfPlanet : Planet
    {
        public override bool LightEmission
        {
            get
            {
                return false;
            }
        }
        public DwarfPlanet(string dwarfPlanetName, decimal radius): base(dwarfPlanetName, radius)
        {
              
        }
    }
}
