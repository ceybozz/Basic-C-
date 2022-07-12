using System;

namespace BookExample
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public List<Chapter> Chapters { get; set; }

        public Book(string title, string author, List<Chapter> chapters)
        {
            Title = title;
            Author = author;
            Chapters = chapters;
        }

        public List<Chapter> GetAllChaptersOrdered()
        {
            // Using LINQ to order chapters by the property Number
            return Chapters.OrderBy(o => o.Number).ToList();
        }
    }
}
