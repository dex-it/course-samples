using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter7
{
    class StellarSystem
    {

        class AstroEnumerator : IEnumerator
        {
            readonly AstronomicalObject[] astro;
            int position = -1;
            public AstroEnumerator(AstronomicalObject[] astro)
            {
                this.astro = astro;
            }
            public object Current
            {
                get
                {
                    return astro[position];
                }
            }

            public bool MoveNext()
            {
                if (position < astro.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }
        }
        class SolarSystem
        {

            readonly AstronomicalObject[] astro = {
                    new AstronomicalObject("Солнце", true),
                    new AstronomicalObject("Меркурий", false),
                    new AstronomicalObject("Венера", false),
                    new AstronomicalObject("Земля", false),
                    new AstronomicalObject("Марс", false),
                    new AstronomicalObject("Юпитер", false),
                    new AstronomicalObject("Сатурн", false),
                    new AstronomicalObject("Уран", false),
                    new AstronomicalObject("Нептун", false) };

            public IEnumerator GetEnumerator()
            {
                return new AstroEnumerator(astro);
            }
        }

        static void Main(string[] args)
        {
            SolarSystem solarSystem = new SolarSystem();
            
            foreach (AstronomicalObject a in solarSystem)
            {

                if (a.LightEmission) {
                    Console.WriteLine(a.Name + " - это звезда." );
                }
                else
                {
                    Console.WriteLine(a.Name + " - это планета.");
                }
                    
            }

            Console.ReadLine();
        }
    }
}
