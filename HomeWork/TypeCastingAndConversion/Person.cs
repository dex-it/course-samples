using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCastingAndConversion
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected string pattern = @"^$";
        public static implicit operator Person (string str)
        {
            String[] words = str.Split(" ");
            if (words.Length == 2)
                return new Person { FirstName = words[0], LastName = words[1] };            
            else
                return new Person { FirstName = "", LastName = "" };
        }

        public static explicit operator Person (FIO fio)
        {
            return new Person { FirstName = fio.FirstName, LastName = fio.LastName };
        }

        public static explicit operator string (Person person)
        {
            return person.LastName + " " + person.FirstName;
        }
    }
}
