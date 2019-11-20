namespace Stage1Chapter5
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName = "", string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Неявное преобразование типа Person к string
        public static implicit operator string(Person obj)
        {
            return obj.FirstName + " " + obj.LastName;
        }

        // Явное преобразование типа string к Person
        public static explicit operator Person(string obj)
        {
            string[] words = obj.Split(' ');

            if (words.Length == 2 )
            {
                return new Person(words[0], words[1]);
            }
            else if(words.Length == 1)
            {
                return new Person(words[0], "");
            }
            else
            {
                return new Person();
            }
            
            
        }
    }
}
