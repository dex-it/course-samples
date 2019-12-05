using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Stage1Chapter14;

namespace Stage1Chapter19
{
    public class Serializer
    {
        public void SaveAstroInBinaryFormat(AstronomicalObject astro, string fileName)
        {
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, astro);

                Console.WriteLine("Объект сериализован");
            }
        }

        public void ReadAstroInBinaryFormat(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // десериализация из файла
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                AstronomicalObject newAstro = (AstronomicalObject)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название: {newAstro.Name} --- Радиус: {newAstro.Radius} --- Свечение: {newAstro.LightEmission}");
            }

            Console.ReadLine();
        }

    }
}
