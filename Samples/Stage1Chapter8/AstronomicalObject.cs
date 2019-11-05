using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter8
{
    class AstronomicalObject
    {
        public string Name { get; set; }
        public long Weight { get; set; }
        public bool LightEmission { get; set; }


        public AstronomicalObject(string name = "No name", long weight = 0, bool lightEmission = false)
        {
            Name = name;
            Weight = weight;
            LightEmission = lightEmission;
        }

    }
}
