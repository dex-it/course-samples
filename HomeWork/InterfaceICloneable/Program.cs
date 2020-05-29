using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct
            {
                value1 = 1.5,
                value2 = 35,
                valueClass = new ValueClass { valueInClass = true }
            };
            MyStruct myStructNew;
            myStructNew = (MyStruct)myStruct.Clone();
            Console.WriteLine("value1= {0}, value2= {1}, valueInClass= {2}",
                myStructNew.value1,myStructNew.value2, myStructNew.valueClass.valueInClass);
            Console.ReadLine();
        }
    }

    struct MyStruct: ICloneable
    {
        public ValueType value1;
        public ValueType value2;
        public ValueClass valueClass;
        public object Clone()
        {
            return this.MemberwiseClone();
        }  
    }

    public class ValueClass
    {
        public ValueType valueInClass { get; set; }
    }
}
