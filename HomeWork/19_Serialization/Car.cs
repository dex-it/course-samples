using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _19_Serialization
{
    [Serializable]
    public class Car
    {
        public Colors? Color { get; set; }
        public int YearOfIssue { get; set; }
        public Engine Engine { get; set; }
        

        public override string ToString()
        {
            return string.Format("Год выпуска {0}; " +
                                 "Цвет: {1}; " +
                                 "Объем двигателя {2}; " +
                                 "Тип топлива: {3}", 
                YearOfIssue, Color, Engine.Volume, Engine.TypeOfFuel);
        }
    }

    public class Engine
    {
        public double Volume { get; set; }
        public TypeOfFuel TypeOfFuel { get; set; }
    }

    public enum TypeOfFuel
    {
        Petrol95,
        Petrol92,
        Diesel
    }

    public enum Colors
    {
        Red,
        White,
        Black,
        Silver
    }
}
