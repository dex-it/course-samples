using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class Satellite: AstronomicalObject
    {
        protected bool LightEmission => false;

        public Satellite(string satelliteName):base(satelliteName)
        {
            
        }
    }
}
