using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_1_OOP_
{
    public interface ICreature
    {
        string Family { get; } // к кому  семейству отнсеться
        int NumberOfLegs { get; } // количество конечностей
        bool ItFlies { get; } //летает ли оно?

        bool ItIsHungry(int timeOfLastFeeding, int feedingFrequency);

        void ChangeCountOfLegs(int countOfLegs);
    }
}