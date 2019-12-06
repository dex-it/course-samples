using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            serial.ReadAstroInBinaryFormat("astro.dat");
            serial.SaveAstroInXmlFormat(astro, "astro.xml");
            Console.ReadLine();
        }
    }
}
