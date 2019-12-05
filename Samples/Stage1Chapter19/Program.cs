using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Stage1Chapter14;

namespace Stage1Chapter19
{
    public class Program
    {
        static void Main(string[] args)
        {
            Serializer serial = new Serializer();
            serial.SaveInBinaryFormat();
        }
    }
}
