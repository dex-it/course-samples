using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace TestList
{
    class Person
    {
        public string FIO { get; set; }
        public DateTime DataRogdenia { get; set; }
        public string MestoRogdenia { get; set; }
        public string NomPasporta { get; set; }
        
        public Person(string FIO, DateTime DataRogdenia, string MestoRogdenia, string NomPasporta)
        {
            this.FIO = FIO;
            this.DataRogdenia = DataRogdenia;
            this.MestoRogdenia = MestoRogdenia;
            this.NomPasporta = NomPasporta;
        }
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Person)) return false;
            Person person = (Person)obj;
            return person.FIO == this.FIO &&
                   person.MestoRogdenia == this.MestoRogdenia &&
                   person.DataRogdenia == this.DataRogdenia &&
                   person.NomPasporta == this.NomPasporta;
        }
        public override int GetHashCode()
        {
            return (FIO + DataRogdenia + MestoRogdenia + NomPasporta).GetHashCode();
        }
        public override string ToString()
        {
            return FIO +" "+ DataRogdenia.ToString("D") + " "+ NomPasporta;
        }
    }
}
