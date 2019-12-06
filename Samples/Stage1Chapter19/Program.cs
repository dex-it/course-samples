using System;
using Stage1Chapter14;

namespace Stage1Chapter19
{
    public class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            AstronomicalObject astro = new AstronomicalObject("Earth", 6371, false);
            Console.WriteLine("Объект создан");

            Serializer serial = new Serializer();
            serial.SaveAstroInBinaryFormat(astro, "astro.dat");
            Console.WriteLine("Сериализация объекта в Binary-формат");
            Console.ReadLine();

            AstronomicalObject newAstro = serial.ReadAstroInBinaryFormat("astro.dat");
            Console.WriteLine("Объект десериализован");
            Console.WriteLine($"Название: {newAstro.Name} --- Радиус: {newAstro.Radius} --- Свечение: {newAstro.LightEmission}");
            Console.ReadLine();

            serial.SaveAstroInXmlFormat(astro, "astro.xml");
            Console.WriteLine("Сериализация объекта в XML-формат");
            Console.ReadLine();

            serial.SaveAstroInJsonFormat(astro, "astro.json");
            Console.WriteLine("Сериализация объекта в JSON-формат");
            Console.ReadLine();
        }
    }
}
