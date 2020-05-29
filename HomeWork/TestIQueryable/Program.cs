using System;
using System.Linq;

namespace TestIQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            int god = 1985;
            AutoPark autoPark = new AutoPark();
            for (int i = 0; i < 100; i++)
            {
                autoPark.AddRandom();
            }

            Console.WriteLine("Прошли тех. осмотр");
            var automobilesGroups = 
                autoPark.Automobiles.Where (w => w.TehOsmotr == true)
                                    .GroupBy(t => t.Marka)
                                    .Select(g => new { Name = g.Key, Count = g.Count() })
                                    .OrderBy(o => o.Count);
            foreach (var g in automobilesGroups)
            {
                Console.WriteLine(g.Name + " " + g.Count);                
            }
            Console.WriteLine();

            Console.WriteLine("Список машин старше "+ god.ToString()+ " года");
            var selectedTeamsArray = autoPark.Automobiles.Where(t => t.GodVipuska <= god)
                                                         .OrderByDescending(t => t.GodVipuska)
                                                         .ToList();

            Console.WriteLine("Марка           Год    Тех. осмотр");
            foreach (var s in selectedTeamsArray)
            {
                Console.WriteLine("{0}      {1}     {2}", MarkaProbeli(s.Marka), 
                                                          s.GodVipuska, 
                                                          s.TehOsmotr);
            }
            Console.WriteLine();

            bool result1 =
                selectedTeamsArray.Any(u => u.TehOsmotr == true && u.Marka == "Audi");
            if (result1)
                Console.WriteLine("Есть Ауди старше " + god.ToString() + " года, прошедшие тех. осмотр");
            else
                Console.WriteLine("Нет Ауди старше " + god.ToString() + " года, прошедшие тех. осмотр");
            Console.WriteLine();

            var minGodVipuska = autoPark.Automobiles.Where(w => w.TehOsmotr = true)
                                                    .Min(t => t.GodVipuska);
            Console.WriteLine("Минимальынй год выпуска прошедший тех. осмотр "+ minGodVipuska);



            Console.ReadLine();
        }

        public static string MarkaProbeli (string marka)
        {
            while (marka.Length != 10)
            {
                marka += " ";
            }
            return marka;
        }


    }
}
