using System;
using System.Collections;

namespace Базовые_интерфейсы_Enuberable
{
    class Program
    {     
        static void Main(string[] args)
        {
            Machines machines = new Machines();
            for (int i = 1; i < 5; i++)
            {
                machines.Flag_vibora_machines = i;
                Console.Write("Модель №:"+i.ToString()+"--");
                foreach (var m in machines)
                {
                    Console.Write(m+" ");
                }
                Console.WriteLine("\n");


            }
            Console.Read();
        }
    }
        class Machines : IEnumerable
        {
            string[] nomera_bmv = { "bm_11", "bm_22", "bm_33"};
            string[] nomera_shkoda = { "sh_11", "sh_22", "sh_33","sh_43"};
            string[] nomera_ford = { "fr_11", "fr_22", "fr_33", "fr_83" };
           // string[] soobhenie = { "данный тип не найден" };
            public int Flag_vibora_machines { get; set; }

            public IEnumerator GetEnumerator()
            {
                switch (Flag_vibora_machines)
                {
                    case 1: return nomera_bmv.GetEnumerator(); break;
                    case 2: return nomera_shkoda.GetEnumerator(); break;
                    case 3: return nomera_ford.GetEnumerator(); break;
                    default: Console.WriteLine("Данной модели не существует"); return new object[0].GetEnumerator(); break;
                }
            }
        }
          
        
    }
