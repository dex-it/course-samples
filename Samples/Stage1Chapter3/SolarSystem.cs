using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class SolarSystem: StellarSystem
    {

        public SolarSystem()
        {

            
            Star star = new Star("Sun", 695510);
            this.AddStar(star);

            DwarfPlanet pluto = new DwarfPlanet("Pluto", 1188);
            this.AddDwarfPlanet(pluto);

            Planet mercury = new Planet("Mercury", 2439);
            Planet venus = new Planet("Venus", 6051);
            Planet earth = new Planet("Earth", 6371);
            Planet mars = new Planet("Mars", 3389);
            Planet jupiter = new Planet("Jupiter", 69911);
            Planet saturn = new Planet("Saturn", 58232);
            Planet uranus = new Planet("Uranus", 25362);
            Planet neptune = new Planet("Neptune", 24622);

            this.AddPlanet(mercury);
            this.AddPlanet(venus);
            this.AddPlanet(earth);
            this.AddPlanet(mars);
            this.AddPlanet(jupiter);
            this.AddPlanet(saturn);
            this.AddPlanet(uranus);
            this.AddPlanet(neptune);



        }
    }
}
