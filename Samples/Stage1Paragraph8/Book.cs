using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph8
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int PageCount { get; set; }
        public bool HasCover { get; set; }

        public Book() { }

        public Book(string title, string author, DateTime publishDate,
            int pageCount, bool hasCover)
        {
            Title = title;
            Author = author;
            PublishDate = publishDate;
            PageCount = pageCount;
            HasCover = hasCover;
        }
    }
}
