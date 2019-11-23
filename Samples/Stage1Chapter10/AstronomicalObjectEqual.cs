using System;
using Stage1Chapter3;

namespace Stage1Chapter10
{
    public class AstronomicalObjectEqual : AstronomicalObject
    {
        public AstronomicalObjectEqual(string name,
                                       decimal radius,
                                       bool light) : base(name, radius, light)
        {

        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if (!(obj is AstronomicalObjectEqual))
            {
                return false;
            }

            var astro = (AstronomicalObjectEqual)obj;
            return astro.Name == Name && astro.Radius == Radius && astro.LightEmission == LightEmission;
        }
        
        public override int GetHashCode()
        {
            int lightEmision = Convert.ToInt32(LightEmission);
            int radius = (int)Radius;
            int name = NameToIntHash(Name);

            return lightEmision^radius^name;
        }
        
        
        private int NameToIntHash(string value)
        {
            int num = 5381;
            int num2 = num;
            for (int i = 0; i < value.Length; i += 2)
            {
                num = (((num << 5) + num) ^ value[i]);

                if (i + 1 < value.Length)
                    num2 = (((num2 << 5) + num2) ^ value[i + 1]);
            }
            return num + num2 * 1566083941;
        }



    }
}
