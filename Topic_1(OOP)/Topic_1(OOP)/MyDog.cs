using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_1_OOP_
{
    class MyDog : ICreature
    {
        public string Family { get; set; }
        public string Name { get; set; }
        int ICreature.NumberOfLegs { get; }
        bool ICreature.ItFlies { get; }

        public MyDog(string Name)
        {
            this.Name = Name;
        }

        bool ICreature.ItIsHungry(int timeOfLastFeeding, int FeedingFrequency)
        {
            if (timeOfLastFeeding <= FeedingFrequency)
            {
                Console.WriteLine(Name + " is not hungry");
                return false;
            }
            else
            {
                Console.WriteLine(Name + " is hungry");
                return true;
            }
        }

        public void ChangeCountOfLegs(int countOfLegs)
        {
            throw new NotImplementedException();
        }
    }
}