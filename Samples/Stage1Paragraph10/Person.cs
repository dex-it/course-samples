using System;

namespace Stage1Paragraph10
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string PlaceOfBirth { get; set; }
        public long PassportId { get; set; }

        public Person() {}

        public Person(string name, DateTime birthday, string placeOfBirth, long passportId)
        {
            Name = name;
            Birthday = birthday;
            PlaceOfBirth = placeOfBirth;
            PassportId = passportId;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person && obj != null)
            {
                Person temp = (Person)obj;

                if (temp.Name == this.Name
                    && temp.Birthday == this.Birthday
                    && temp.PlaceOfBirth == this.PlaceOfBirth
                    && temp.PassportId == this.PassportId)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return PassportId.GetHashCode();
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Name == p2.Name
                    && p1.Birthday == p2.Birthday
                    && p1.PlaceOfBirth == p2.PlaceOfBirth
                    && p1.PassportId == p2.PassportId;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
    }
}
