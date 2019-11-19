namespace Stage1Chapter3
{
    public class DwarfPlanet : Planet
    {
        protected override bool LightEmission => false;

        public DwarfPlanet(string dwarfPlanetName, decimal radius): base(dwarfPlanetName, radius)
        {
              
        }
    }
}
