using System.Collections;

namespace Stage1Chapter7
{
    public class SolarSystem
    {

        readonly AstronomicalObject[] _astro = {
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
            return new AstroEnumerator(_astro);
        }
    }
}