using System;

namespace Books_Inventory
{

    class Program
    {
        public static bool stop = false;
        static void Main(string[] args)
        {
            // instantiate an instance of the context
            BooksContext context = new BooksContext();

            while (stop == false)
            {


                // makes sure that the table exists, 
                //and creates it if it does not already exist
                context.Database.EnsureCreated();
                // ask the user for a book to add
                Console.WriteLine("Enter book's title.");
                String bookTitle = Console.ReadLine();
                Console.WriteLine("Enter book's author.");
                String bookAuthor = Console.ReadLine();



                // create a new book object, notce that we do not 
                // select an id, we let the framework handle that
                Book newBook = new Book(bookTitle, bookAuthor);

                    // add the newly created book instance to the context
                    // notice how similar this is to adding a item to a list,
                    context.books.Add(newBook);

                    // ask the context to save any changes to the database 
                    context.SaveChanges();
                    Console.WriteLine("Added the book.");
                
               
                Console.WriteLine("Would you like to add another book? Y/N");
                String keepGoing = Console.ReadLine().ToUpper();
                if (keepGoing == "N")
                {
                    stop = true;
                }
            }


            Console.WriteLine("The Current List of books are: ");
            // use a for each loop to loop through the books in the context
            // notice how similar this is to looping through a list
            foreach (Book s in context.books)
            {
                Console.WriteLine("{0} - {1} by {2}",
                     s.Id, s.Title, s.Author);
            }
        }
    }
}
