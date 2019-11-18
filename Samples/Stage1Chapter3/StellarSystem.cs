using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class StellarSystem
    {
        public int AmountStars => _stars.Count;

        public int AmountPlanets => _planets.Count;

        public int AmountDwarfPlanets => _dwarfPlanets.Count;

        public int AmountSatellites => _satellites.Count;
        private readonly List<Star> _stars = new List<Star>();
        private readonly List<Planet> _planets = new List<Planet>();
        private readonly List<DwarfPlanet> _dwarfPlanets = new List<DwarfPlanet>();
        private readonly List<Satellite> _satellites = new List<Satellite>();

        protected StellarSystem()
        {

        }

        protected void AddPlanet(Planet planet)
        {
            _planets.Add(planet);
        }
        public List<Planet> GetListPlanets()
        {
            return _planets;
        }

        protected void AddDwarfPlanet(DwarfPlanet dwarfPlanet)
        {
            _dwarfPlanets.Add(dwarfPlanet);
        }
        public List<DwarfPlanet> GetListDwarfPlanets()
        {
            return _dwarfPlanets;
        }

        protected void AddStar(Star star)
        {
            _stars.Add(star);
        }
        public List<Star> GetListStars()
        {
            return _stars;
        }
        public void AddSatellite(Satellite satellite)
        {
            _satellites.Add(satellite);
        }
        public List<Satellite> GetListSatellites()
        {
            return _satellites;
        }

    }
}
