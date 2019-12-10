namespace Stage1Chapter3
{
    public class Satellite: AstronomicalObject
    {
        //protected new bool LightEmission => false;

        public Planet ParentPlanet { get; set; }

        public Satellite(string satelliteName, decimal radius) :base(satelliteName, radius, false)
        {
            
        }
        public Satellite()
        {

        }
    }
}
