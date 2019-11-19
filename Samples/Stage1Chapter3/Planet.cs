namespace Stage1Chapter3
{
    class Planet: AstronomicalObject
    {
        protected virtual bool LightEmission => false;

        public Planet(string planetName, decimal radius) : base(planetName, radius)
        {
            
        }
    }
}
