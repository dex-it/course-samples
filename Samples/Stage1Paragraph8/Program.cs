using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph8
{
    class Program
    {
        static Book[] CreateLibrary()
        {
            return new[]
            {
                new Book(
                    title: "Сибирская сага. История семьи",
                    author: "Людмила Хворостовская",
                    publishDate: new DateTime(2019, 10, 01),
                    pageCount: 400,
                    hasCover: false),
                new Book("Сулажин", "Борис Акунин", new DateTime(2018, 02, 01), 224, true),
                new Book("Каменная ночь", "Кэтрин Мерридейл", new DateTime(2018, 02, 01), 512, false),
                new Book("Исчезновение Стефани Мейлер", "Жоэль Диккер", new DateTime(2016, 12, 01), 672, true),
                new Book("Военный свет", "Майкл Ондатже", new DateTime(2019, 03, 01), 250, false),
                new Book("Моя семья и другие звери", "Джеральд Даррелл", new DateTime(2017, 07, 01), 550, false),
                new Book("Турецкий гамбит", "Борис Акунин", new DateTime(2017, 07, 01), 250, false)
            };
        }

        static void Main(string[] args)
        {
            var myLibrary = CreateLibrary();

            // оператор where и метод Count() 
            var newBooksCount = (from b in myLibrary
                                 where b.PublishDate.Year == 2019
                                 select b).Count();

            Console.WriteLine($"Количество новых книг {newBooksCount}");

            // оператор order by
            var orderedByAuthor = from b in myLibrary
                                  orderby b.Title
                                  select b.Title;

            Console.WriteLine("\nНазвания книг в алфавитном порядке");
            foreach (var e in orderedByAuthor)
            {
                Console.WriteLine(e);
            }



            // Метод group by
            Console.WriteLine("\nКоличество книг по авторам");
            var groupsByYears = from b in myLibrary
                                group b by b.Author into g
                                select new { Year = g.Key, Count = g.Count() };
            foreach (var group in groupsByYears)
            {
                Console.WriteLine($"{group.Year} : {group.Count}");
            }

            Console.ReadLine();
        }


    }
}
