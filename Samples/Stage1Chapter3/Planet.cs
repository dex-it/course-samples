namespace Stage1Chapter3
{
    public class Planet: AstronomicalObject
    {
        protected new virtual bool LightEmission => false;

        public Planet(string planetName, decimal radius) : base(planetName, radius)
        {
            
        }
    }
}
