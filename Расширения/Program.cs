using System;

namespace Расширения
{
    class Program
    {
       
        static void Main(string[] args)
        {
          
            Console.WriteLine("Вывод 5 секунд: "+5.Seconds());
            Console.WriteLine("Вывод 5 минут: " + 5.Hours());
            Console.WriteLine("Вывод 5 дней: " + 5.Days());
            TimeSpan time = new TimeSpan();
            

            
        }
      
    }
    public static class StringExtensions
    {
        public static TimeSpan Seconds(this int k)
        {
             if (k == null) throw new ArgumentNullException(nameof(k));

            return new TimeSpan(0, 0, k);
        }
        public static TimeSpan Hours(this int k)
        {
            if (k == null) throw new ArgumentNullException(nameof(k));

            return new TimeSpan(0, k, 0);
        }
        public static TimeSpan Days(this int k)
        {
            if (k == null) throw new ArgumentNullException(nameof(k));

            return new TimeSpan(k, 0, 0);
        }
        
           
    }
}
