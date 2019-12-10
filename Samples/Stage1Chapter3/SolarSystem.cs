﻿namespace Stage1Chapter3
{
    public class SolarSystem: StellarSystem
    {
        public SolarSystem()
        {
            var star = new Star("Sun", 695510);
            var mercury = new Planet("Mercury", 2439);
            var venus = new Planet("Venus", 6051);
            var earth = new Planet("Earth", 6371);
            var mars = new Planet("Mars", 3389);
            var jupiter = new Planet("Jupiter", 69911);
            var saturn = new Planet("Saturn", 58232);
            var uranus = new Planet("Uranus", 25362);
            var neptune = new Planet("Neptune", 24622);
            var pluto = new DwarfPlanet("Pluto", 1188);

            AddStar(star);
            AddPlanet(mercury);
            AddPlanet(venus);
            AddPlanet(earth);
            AddPlanet(mars);
            AddPlanet(jupiter);
            AddPlanet(saturn);
            AddPlanet(uranus);
            AddPlanet(neptune);
            AddDwarfPlanet(pluto);

        }
        
    }
}
