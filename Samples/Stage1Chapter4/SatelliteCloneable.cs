using Stage1Chapter3;
using System;

namespace Stage1Chapter4
{
    public class SatelliteCloneable : Satellite, ICloneable
    {
        public SatelliteCloneable(string satelliteName, decimal radius) : base(satelliteName, radius)
        {

        }

        public object DeepClone()
        {
            SatelliteCloneable satelliteDeepClone = (SatelliteCloneable)MemberwiseClone();
            satelliteDeepClone.Name = String.Copy(Name);
            satelliteDeepClone.ParentPlanet = new Planet(ParentPlanet.Name, Radius);
            return satelliteDeepClone;
        }

        public object Clone()
        {
            return (SatelliteCloneable)MemberwiseClone();
        }
    }
}
