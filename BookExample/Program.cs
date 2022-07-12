using System;

namespace BookExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating chapters
            var ch1 = new Chapter("A long-expected travel", 1);
            var ch2 = new Chapter("The shadows of the realm", 2);
            var ch3 = new Chapter("I see light", 3);

            // Create a list which contains all the chapters
            var chapters = new List<Chapter>();
            chapters.Add(ch1);
            chapters.Add(ch3);  // adding the chapters in an unordered manner
            chapters.Add(ch2);  // they will appear in the list th eway we add them
                                // ch1, ch3, ch2

            // Create a book
            var book = new Book("Fellowship of the ring", "J.R.R. Tolkien", chapters);

            // printing info about the book
            Console.WriteLine($"Title: {book.Title}\n" + 
                                $"Author: {book.Author}\n\n");
            
            // printing the chapters in order
            var orderedChapters = book.GetAllChaptersOrdered();
            foreach (var chapter in orderedChapters)
            {
                Console.WriteLine($"Chapter {chapter.Number}: {chapter.Name}\n");
            }
        }
    }
}
