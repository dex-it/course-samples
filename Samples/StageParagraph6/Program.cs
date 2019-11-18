using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph6
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterTemperature celsiusТemperature = new WaterTemperature();
            celsiusТemperature.Value = 10;

            // Тест упаковки
            var watch = new Stopwatch();
            watch.Start();

            object boxedTemperature = celsiusТemperature;

            watch.Stop();
            Console.WriteLine($"Время упаковки: {watch.ElapsedMilliseconds}");

            // Тест распаковки
            watch = new Stopwatch();
            watch.Start();

            WaterTemperature unboxedTemperature = (WaterTemperature)boxedTemperature;

            watch.Stop();
            Console.WriteLine($"Время распаковки: {watch.ElapsedMilliseconds}");

            Console.ReadLine();
        }
    }
}
