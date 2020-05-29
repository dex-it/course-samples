using System;
using System.Collections.Generic;
using System.Text;

namespace TypeCastingAndConversion
{
    class FIO
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public FIO(string firstname, string middlename, string lastname)
        {
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
        }
    }
}
