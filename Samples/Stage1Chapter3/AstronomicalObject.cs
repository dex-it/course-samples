using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class AstronomicalObject
    {
        public string Name { get; }
        public decimal Radius { get; }
        public decimal Weight { get; }
        public virtual bool LightEmission { get; }
        public AstronomicalObject(string name = "No name", decimal radius = 0, decimal weight = 0)
        {
            Name = name;
            Radius = radius;
            Weight = weight;
            
        }

        public double SurfaceArea()
        {
            return 4 * Math.PI * (Double)Radius * (Double)Radius ;
        }



    }
}
