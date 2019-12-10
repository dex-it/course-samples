namespace Stage1Chapter3
{
    public class Satellite: AstronomicalObject
    {
        public Planet ParentPlanet { get; set; }

        public Satellite(string satelliteName, decimal radius) :base(satelliteName, radius, false)
        {
            
        }
        public Satellite()
        {

        }
    }
}
