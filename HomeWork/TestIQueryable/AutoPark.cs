using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestIQueryable
{
    class AutoPark 
    {
        public List<Automobile> Automobiles { get; }
        private string[] marki = {"Audi", "Mercedes", "BMW", "Wolksvagen", "Toyota" };
        private int[] qwe = { 1,2,3,4,5 };

        public AutoPark ()
        {
            Automobiles = new List<Automobile>();
        }
                
        public void Add (string _marka, int _godVipuska, bool _tehOsmotr)
        {
            Automobiles.Add(new Automobile { Marka = _marka, 
                                             GodVipuska = _godVipuska, 
                                             TehOsmotr = _tehOsmotr });
        }
        public void AddRandom()
        {
            Random rnd = new Random();
            string marka = marki[rnd.Next(0, marki.Length-1)];
            int godVipuska = rnd.Next(1980, 2020);
            bool tehOsmotr = rnd.Next(100) < 50 ? true : false;
            Add(marka, godVipuska, tehOsmotr);
        }
                
        public class Automobile
        {
            public string Marka { get; set; }
            public int GodVipuska { get; set; }
            public bool TehOsmotr { get; set; }
        }

    }
            
}
