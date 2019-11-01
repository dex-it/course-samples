using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter7
{
    class AstronomicalObject
    {
        public string Name { get; }
        public bool LightEmission { get; }
        public AstronomicalObject(string name = "No name", bool lightEmission = false)
        {
            Name = name;
            LightEmission = lightEmission;
        }

    }
}
