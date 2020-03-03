using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IQueryable
{
    class Product
    {
        static private int counter = 0;              
        public Product()
        {
            Code = ++counter;
        }
        public int Code {get; private set;}
        public string Name { get; set; }
        public double Price { get; set; }        
        public DateTime Date { get; set; }
        public bool IsInStock { get; set; }

    }
   
    class Program
    {
        private static Random random = new Random();
        public static string RandomString(int size)//можно поиграться еще
        {
            StringBuilder builder = new StringBuilder(size);
            for (int i = 0; i < size; i++)
                builder.Append((char)random.Next(0x41, 0x5A));
            return builder.ToString();
        }
        

        static void Main(string[] args)
        {
            Product[] products = new Product[100];
            Random rnd = new Random();
            for (int i = 0; i < products.Length; i++)
            {
                products[i] = new Product();
                products[i].Name = RandomString(10);
                products[i].Price = random.Next(5, 150);
                DateTime start = new DateTime(2019, 6, 1);
                products[i].Date = start.AddDays(rnd.Next((DateTime.Today - start).Days));                
                products[i].IsInStock = (random.Next(2) == 1) ? true : false;
            }

            for (int i = 0; i < products.Length; i++)

            {
                Console.WriteLine("Code="+products[i].Code + ", Name=" + products[i].Name+", Price="+ products[i].Price+", Date="+products[i].Date.ToShortDateString()+", IsInStock="+products[i].IsInStock);

            }
            var query1 = products.Where(t=>t.Price>100).OrderBy(t => t.Name);
            Console.WriteLine("----------------------------------\nСортировка по возрастанию (по Name), продуктов, у которых Price>100");
            foreach (Product p in query1)
            {
                Console.WriteLine("Code="+p.Code+", Name="+p.Name + ", Price=" + p.Price);
            }
            Console.WriteLine("----------------------------------\nГруппировка по наличию (IsInStock)");
            var query2 = from p in products
                         group p by p.IsInStock;
            foreach(var group in query2)
            {
                Console.WriteLine("Is in stock:"+group.Key);
                foreach (Product p in group)
                    Console.WriteLine("Code=" + p.Code + ", Name=" + p.Name + ", IsInStock=" + p.IsInStock);
            }
            Console.WriteLine("----------------------------------\nЕсть ли хотя бы один, у которого Price<50?");
            bool b1 = products.Any(t => t.Price < 50);
            Console.WriteLine(b1);
            Console.WriteLine("----------------------------------\nУ всех ли Price<50?");
            bool b2 = products.All(t => t.Price < 50);
            Console.WriteLine(b2);
            Console.WriteLine("----------------------------------\nСтоимость всех продуктов, которые есть в наличии");
            var query3 = products.Where(t=>t.IsInStock=true).Sum(t=>t.Price);
            Console.WriteLine(query3);
            Console.WriteLine("----------------------------------\nПродукт с минимальной ценой");
            var query4 = products.Min(t => t.Price);
            Console.WriteLine(query4);
            Console.WriteLine("----------------------------------\nПродукт с максимальной ценой");
            var query5 = products.Max(t => t.Price);
            Console.WriteLine(query5);




            Console.Read();
        }
    }
}
