using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_1_OOP_
{
    public abstract class Cat : ICreature
    {
        private int _countOfLegs = 4;
        public string Family { get; set; }
        public string CatName { get; set; }

        public int NumberOfLegs => _countOfLegs;

        public bool ItFlies
        {
            get { return false; }
        }

        public bool ItIsHungry(int timeOfLastFeeding, int feedingFrequency)
        {
            if (timeOfLastFeeding <= feedingFrequency)
            {
                Console.WriteLine(CatName + " is not hungry");
                return false;
            }
            else
            {
                Console.WriteLine(CatName + " is hungry");
                return true;
            }
        }

        public void ChangeCountOfLegs(int countOfLegs)
        {
            // validate
            _countOfLegs = countOfLegs;
        }

        public abstract void PlayWithTheCat();
    }
}