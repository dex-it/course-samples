using System;
using System.Linq;

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

        static void Main()
        {
            // Создаем библиотеку
            var myLibrary = CreateLibrary();

            // Используем оператор Where
            var newBooks = from b in myLibrary
                where b.PublishDate.Year == DateTime.Now.Year
                select b;

            Console.WriteLine("Использование оператора Where");
            foreach (var book in newBooks)
            {
                if (book.Title != null)
                {
                    Console.WriteLine(book.Title);
                }
            }
            
            // Используем оператор OrderBy
            var sortedBooks = from b in myLibrary
                orderby b.Title
                select b;

            Console.WriteLine("\nИспользование оператора OrderBy");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book.Title);
            }

            // Используем оператор GroupBy
            var groupsByAuthor = from b in myLibrary
                group b by b.Author;

            Console.WriteLine("\nИспользование оператора group by");
            foreach (var group in groupsByAuthor)
            {
                Console.WriteLine(group.Key);

                foreach (var book in group)
                {
                    Console.WriteLine($"\t{book.Title}");
                }
            }

            // Используем Min и Max
            var smallestBook = myLibrary.Min(b => b.PageCount);
            var largestBook = myLibrary.Max(b => b.PageCount);

            Console.WriteLine($"\nСамая маленькая книга:{smallestBook}, самая большая книга:{largestBook}");
            
            Console.ReadLine();
        }
    }
}
