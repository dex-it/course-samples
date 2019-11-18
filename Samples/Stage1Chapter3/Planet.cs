using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class Planet: AstronomicalObject
    {
        protected virtual bool LightEmission => false;

        public Planet(string planetName, decimal radius) : base(planetName, radius)
        {
            
        }
    }
}
