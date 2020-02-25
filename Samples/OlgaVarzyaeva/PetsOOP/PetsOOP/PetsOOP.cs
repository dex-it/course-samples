using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsOOP
{
    interface IAnimal
    {
        void MakeSound();
        void Move(int distance);
        //еще один

    }

    public abstract class Pet : IAnimal
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract void MakeSound();
        public abstract void Move(int distance);
    }

    public class Cat : Pet
    {
        public Cat()
        {
            this.Name = "NoName";
            Console.WriteLine("Cat was succesfully added!");
        }

        public Cat(string name)
        {            
            Name = name;
        }

        public override void  MakeSound()
        {
            Console.WriteLine("Cat says: \"Meow! Meow!\"");
        }
        public override void Move(int distance)
        {
            Console.WriteLine("Cat ran {0} meters", distance);
        }
    }

    public class Dog : Pet
    {
        public Dog()
        {
            this.Name = "NoName";
            Console.WriteLine("Dog was succesfully added!");
        }
        public Dog(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Dog says: \"Woof! Woof!\"");
        }
        public override void Move(int distance)
        {
            Console.WriteLine("Dog ran {0} meters", distance);
        }

    }

    public class Fish : Pet
    {
        public Fish()
        {
            this.Name = "NoName";
            Console.WriteLine("Dog was succesfully added!");
        }
        public Fish(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Fish don't speak, silly :)");
        }
        public override void Move(int distance)
        {
            Console.WriteLine("Fish swam {0} meters", distance);
        }

    }


    class PetsOOP
    {
        public static void AddPet(List<Pet> pets, int code, string name)
        {
            switch (code)
            {
                case 1:
                    {
                        pets.Add(new Cat(name));                        
                        break;
                    }
                case 2:
                    {
                        pets.Add(new Dog(name));                        
                        break;
                    }
                case 3:
                    {
                        pets.Add(new Fish(name));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error! Please, choose valid number.");
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();
            Console.WriteLine("Hello!\nHow many pets do you want to add? ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Which pet would you like to add?\n1 - Cat, 2 - Dog, 3 - Fish ");
                int pet_code = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is your pet's name?");
                string pet_name = Console.ReadLine();
                AddPet(pets, pet_code, pet_name);
            }   

            //вывод на экран всех животных
            Console.WriteLine("\nCurrent list of pets:");
            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine("Class:"+pets[i].GetType());
                Console.WriteLine("name: " + pets[i].Name);                
                pets[i].MakeSound();
                pets[i].Move(5);
                Console.WriteLine("\n");
            }

           
            Console.ReadKey();
        }
    

        
    }
}
