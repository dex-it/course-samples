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
    public interface IQueryable : IEnumerable
    {

        Type ElementType { get; } // возвращаемый тип элемента перечисления
        Expression Expression { get; } // выражение описывающее запрос к источнику данных
        IQueryProvider Provider { get; } // класс который преобразует Expression в запрос на языке понятном источнику данных, (например sql, cql...)
    }
    class Product
    {
        static private int counter = 0;
        private int _code;
        private string _name;
        //private double _price;
        //private bool _isInStock;
        //private DateTime _date;
        public Product()
        {
            Code = ++counter;
        }
        public int Code
        {             
            get { return _code; }
            set { _code = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
    class Program
    {
        private static Random random = new Random();
        public static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder(size);
            for (int i = 0; i < size; i++)
                builder.Append((char)random.Next(0x41, 0x5A));
            return builder.ToString();
        }
        static void Main(string[] args)
        {
           
            Product[] products = new Product[10];

            for (int i = 0; i < products.Length; i++)
            {
                products[i]= new Product();
                products[i].Name = RandomString(10);
            }
            //string p = RandomString(12);
            for (int i = 0; i < products.Length; i++)

            {
                Console.WriteLine(products[i].Code+" "+ products[i].Name);

            }

            //var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t).ToArray();
            //foreach (string s in selectedTeams) // вычисление 1
            //{
            //    Console.WriteLine(s);
            //}
            
            Console.Read();
        }
    }
}
