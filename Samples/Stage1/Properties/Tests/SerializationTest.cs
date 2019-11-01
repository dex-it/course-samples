using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Stage1
{
    public class SerializationTest
    {
        [Serializable]
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }

            public int Age
            {
                get
                {
                    var dateNow = DateTime.Now;
                    var year = dateNow.Year - DateOfBirth.Year;
                    if (dateNow.Month < DateOfBirth.Month || 
                        dateNow.Month == DateOfBirth.Month && dateNow.Day < DateOfBirth.Day)
                    {
                        year--;
                    }

                    return year;
                }
            }

            public override string ToString()
            {
                return $"Имя: {Name} --- Возраст: {Age}";
            }
        }

        private User[] GetUsers()
        {
            User user1 = new User {Id = 1, Name = "Tom", DateOfBirth = new DateTime(1987, 2, 25)};
            User user2 = new User {Id = 2, Name = "Bill", DateOfBirth = new DateTime(1990, 5, 14)};

            return new[] {user1, user2};
        }

        private void UsersPrint(User[] users)
        {
            foreach (var u in users)
            {
                Console.WriteLine(u);
            }
        }

        [Test]
        public void BinaryTest()
        {
            var users = GetUsers();
            BinaryFormatter formatter = new BinaryFormatter();

            User[] deserilizeUsers;
            using (var stream = new MemoryStream())
            {
                // сериализация
                formatter.Serialize(stream, users);


                var base64 = Convert.ToBase64String(stream.ToArray());
                Console.WriteLine("Сериализованные данные:\n{0}",base64);
                stream.Position = 0;

                // десериализация
                deserilizeUsers = (User[]) formatter.Deserialize(stream);
            }

            Console.WriteLine();
            Console.WriteLine("Десериализованные данные:");
            UsersPrint(deserilizeUsers);
        }

        [Test]
        public void XmlTest()
        {
            var users = GetUsers();
            XmlSerializer formatter = new XmlSerializer(typeof(User[]));
 
            User[] deserilizeUsers;
            using (var stream = new MemoryStream())
            {
                // сериализация
                formatter.Serialize(stream, users);

                var text = Encoding.Default.GetString(stream.ToArray());
                Console.WriteLine("Сериализованные данные:\n{0}",text);
                stream.Position = 0;

                // десериализация
                deserilizeUsers = (User[]) formatter.Deserialize(stream);
            }
            
            Console.WriteLine();
            Console.WriteLine("Десериализованные данные:");
            UsersPrint(deserilizeUsers);
        }

        [Test]
        public void JsonTest()
        {
            var users = GetUsers();
            
            string json = JsonConvert.SerializeObject(users);
            Console.WriteLine("Сериализованные данные:");
            Console.WriteLine(json);
            
            User[] deserilizeUsers = JsonConvert.DeserializeObject<User[]>(json);
            Console.WriteLine();
            Console.WriteLine("Десериализованные данные:");
            UsersPrint(deserilizeUsers);
        }
    }
}