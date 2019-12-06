using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
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
            using (FileStream fStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fStream, astro);

                Console.WriteLine("Объект сериализован");
            }
        }

        public void ReadAstroInBinaryFormat(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // десериализация из файла
            using (FileStream fStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                AstronomicalObject newAstro = (AstronomicalObject)formatter.Deserialize(fStream);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название: {newAstro.Name} --- Радиус: {newAstro.Radius} --- Свечение: {newAstro.LightEmission}");
            }
        }

        public void SaveAstroInXmlFormat(AstronomicalObject astro, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(AstronomicalObject));
            using (FileStream fStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlFormat.Serialize(fStream, astro);
            }
            Console.WriteLine("--> Сохранение объекта в XML-формат");
        }

    }
}
