using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Stage1Chapter14;

namespace Stage1Chapter19
{
    public class Serializer
    {
        public void SaveInBinaryFormat()
        {
            // объект для сериализации
            AstronomicalObject astro = new AstronomicalObject("Earth", 6371, false);

            Console.WriteLine("Объект создан");

            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("astro.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, astro);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream("astro.dat", FileMode.OpenOrCreate))
            {
                AstronomicalObject newAstro = (AstronomicalObject)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название: {newAstro.Name} --- Радиус: {newAstro.Radius} --- Свечение: {newAstro.LightEmission}");
            }

            Console.ReadLine();
        }
    }
}
