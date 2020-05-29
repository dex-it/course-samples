using System;
using System.Collections.Generic;
using System.Text;

namespace TestGetHashCodeAndEquals
{
    class Person
    {
        public string FIO { get; set; }
        public DateTime DataRogdenia { get; set; }
        public string MestoRogdenia { get; set; }
        public int NomPasporta { get; set; }
        
        public Person(string FIO, DateTime DataRogdenia, string MestoRogdenia, int NomPasporta)
        {
            this.FIO = FIO;
            this.DataRogdenia = DataRogdenia;
            this.MestoRogdenia = MestoRogdenia;
            this.NomPasporta = NomPasporta;
        }

        public override int GetHashCode()
        {
            return (FIO+DataRogdenia+MestoRogdenia+NomPasporta).GetHashCode();
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
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals (p2);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals (p2);
        }
    }
}
