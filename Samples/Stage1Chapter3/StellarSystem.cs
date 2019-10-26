using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class StellarSystem
    {
        public int AmountStars {
            get
            {
                return stars.Count;
            }
                
        }
        public int AmountPlanets {
            get
            {
                return planets.Count;
            }
        }
        public int AmountDwarfPlanets {
            get
            {
                return dwarfPlanets.Count;
            }
        }
        public int AmountSatellites {
            get
            {
                return satellites.Count;
            } 
        }
        private readonly List<Star> stars = new List<Star>();
        private readonly List<Planet> planets = new List<Planet>();
        private readonly List<DwarfPlanet> dwarfPlanets = new List<DwarfPlanet>();
        private readonly List<Satellite> satellites = new List<Satellite>();
        public StellarSystem()
        {

        }
        public void AddPlanet(Planet planet)
        {
            planets.Add(planet);
        }
        public List<Planet> GetListPlanets()
        {
            return planets;
        }
        public void AddDwarfPlanet(DwarfPlanet dwarfPlanet)
        {
            dwarfPlanets.Add(dwarfPlanet);
        }
        public List<DwarfPlanet> GetListDwarfPlanets()
        {
            return dwarfPlanets;
        }
        public void AddStar(Star star)
        {
            stars.Add(star);
        }
        public List<Star> GetListStars()
        {
            return stars;
        }
        public void AddSatellite(Satellite satellite)
        {
            satellites.Add(satellite);
        }
        public List<Satellite> GetListSatellites()
        {
            return satellites;
        }

    }
}
