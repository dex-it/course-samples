using System;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class MyOopTest
    {
        [Test]
        public void Test1()
        {
            var student = new Student
            {
                Name = "Иванов",
                StudentGroup = "1Т5656"
            };

            var teacher = new Teacher
            {
                Name = "Медведев С.В",
                Post = "Старший преподаватель"
            };

            var persons = new Person[] { student, teacher };

            foreach (var person in persons)
            {
                person.Display();
            }
        }

        private abstract class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public abstract void Display();

        }

        private class Teacher : Person
        {
            public string Post { get; set; } = "Не указано";

            public override void Display()
            {
                Console.WriteLine("Имя - {0}, Должность - {1}", Name, Post);
            }
        }

        private class Student : Person
        {
            public string StudentGroup { get; set; }

            public override void Display()
            {
                Console.WriteLine("Имя - {0}, Группа - {1}", Name, StudentGroup);
            }
        }
    }
}