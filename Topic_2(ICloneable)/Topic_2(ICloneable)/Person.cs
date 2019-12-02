using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_2_ICloneable_
{
    public class Person : ICloneable
    {
        public FullName FullName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime DateOfBirth { get; set; }

        public object Clone()
        {
            return new Person
            {
                FullName = FullName.DeepCopy(),
                BirthPlace = BirthPlace, 
                DateOfBirth = DateOfBirth
            };
        }
    }
}