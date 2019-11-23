using System;

namespace Stage1Chapter3
{
    public class AstronomicalObject
    {
        public string Name { get; set; }
        public decimal Radius { get; set; }
        public bool LightEmission { get; set; }


        public AstronomicalObject(string name = "No name", decimal radius = 0, bool lightEmission = false)
        {
            Name = name;
            Radius = radius;
            LightEmission = lightEmission;
        }

        public double GetSurfaceArea()
        {
            return 4 * Math.PI * (double)Radius * (double)Radius ;
        }
        
    }
}
