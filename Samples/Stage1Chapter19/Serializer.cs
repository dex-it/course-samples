using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Stage1Chapter14;

namespace Stage1Chapter19
{
    public class Serializer
    {
        public void SaveAstroInBinaryFormat(AstronomicalObject astro, string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fStream, astro);
            }
        }

        public AstronomicalObject ReadAstroInBinaryFormat(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                AstronomicalObject newAstro = (AstronomicalObject)formatter.Deserialize(fStream);
                return newAstro;
            }
            
        }

        public void SaveAstroInXmlFormat(AstronomicalObject astro, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(AstronomicalObject));
            using (FileStream fStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlFormat.Serialize(fStream, astro);
            }
        }

        public void SaveAstroInJsonFormat(AstronomicalObject astro, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(astro, options);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
