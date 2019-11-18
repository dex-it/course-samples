namespace Stage1Chapter3
{
    class DwarfPlanet : Planet
    {
        protected override bool LightEmission => false;

        public DwarfPlanet(string dwarfPlanetName, decimal radius): base(dwarfPlanetName, radius)
        {
              
        }
    }
}
