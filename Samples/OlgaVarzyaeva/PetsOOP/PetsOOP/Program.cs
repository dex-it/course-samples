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
        //void Move();
        //еще один

    }

    public abstract class Pet : IAnimal
    {
        private string _name;
        private string _color;
        int _x;
        int _y;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract void MakeSound();

        public string Color
        {            
            get { return _color; }
            set
            {//проверка, существует ли указанный окрас в перечислении ColorType
                if (Enum.IsDefined(typeof(ColorType), value))
                {
                    _color = value;
                    Console.WriteLine("The {0} color is valid.", _color.ToString());
                }
                else { Console.WriteLine("Error! Please, choose valid color!"); }
            }

        }

        //виды окраса
        enum ColorType
        {
            spotted,//пятнистый
            striped,//в полосочку
            wholecoloured//одноцветный
        }


    }

    public class Cat : Pet
    {
        public Cat() { }

        public Cat(string name)
        {
            Name = name;
        }

        public override void  MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }

        
    }

    public class Dog : Pet
    {
        public Dog() { }

        public Dog(string name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

    }



    class Program
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
            Console.WriteLine("Hello!\nWhich pet would you like to add?\n1 - Cat, 2 - Dog");
            int pet_code = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your pet's name?");
            string pet_name = Console.ReadLine();
            AddPet(pets, pet_code, pet_name);
            



            //вывод на экран всех животных
            Console.WriteLine("\nCurrent list of pets:");
            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine(pets[i].GetType()+ ", name=" + pets[i].Name + " ");
                pets[i].MakeSound();
            }

           
            Console.ReadKey();
        }
    

        
    }
}
