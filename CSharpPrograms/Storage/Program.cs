using System;

namespace Storage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book Inventory in Order by Title in ascending order
            IEnumerable<Book> bookCollection = context.books.OrderBy(x => x.Title);
            //descending order
            IEnumerable<Book> bookCollection = context.books.OrderByDesending(x => x.Title);
            //By Author
            IEnumerable<Book> bookCollection = context.books.OrderBy(book => book.Author);
            //Query version
            IEnumerable<Book> bookCollection = from book in ContextBoundObject.books
                                               orderby book.Title ascending
                                               select book;
            //another way
            where book.Id == 1



            foreach (Book b in bookCollection)
            {
                Console.WriteLine($"{b.id} - {b.Title} by {b.Author});
            }
        }
    }
}
