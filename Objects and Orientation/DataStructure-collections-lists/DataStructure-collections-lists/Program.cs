using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_collections_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //create strings for swtch statements
            string reply;
            string addBook;
            string deleteBook;
            string bookTitle;

            //create a list of books to show up on the screen.
            List<string> myBooks = new List<string>() { "Throne of Glass", "ACOMAF", "Harry Potter", "Game of Thrones" };

            //create a do function, create a message pop up and make it case sensitive.
            do
            {
                Console.WriteLine("Please press a letter of your choice A = Add the Book, D = Delete a Book, L = List the Book, S = Sort the Book, H = Search");
                Console.WriteLine("X = exit");
                reply = Console.ReadLine().ToLower();

                //create each switch statement for each letter in the options button. 
                switch (reply)
                {
                    case "a":
                        Console.WriteLine("Add a book title to the list");
                        addBook = Console.ReadLine();
                        myBooks.Add(addBook);
                        Console.WriteLine(addBook + " has been added to the list."); //tell the user that the book has been added.
                        break;
                    case "d":
                        Console.WriteLine("Delete a book from the list");
                        deleteBook = Console.ReadLine();
                        myBooks.Remove(deleteBook);
                        Console.WriteLine(deleteBook + " has been removed from the list."); //tell the user the book has been deleted.
                        break;
                    case "l":
                       for (int i=0; i < myBooks.Count; i++)
                        {
                            Console.WriteLine(myBooks[i]);
                        }
                        break;
                    case "s":
                        myBooks.Sort();
                        break;
                    case "h":
                        Console.WriteLine("Please enter a book name:"); //ask for a book name to search it through.
                        bookTitle = Console.ReadLine();
                        bool found = myBooks.Contains(bookTitle);
                        if (found)
                        {
                            Console.WriteLine("your title has been found"); //provide if statments for both options if either found or non existing.
                        }
                        else
                        {
                            Console.WriteLine(" you search has not been found");
                        }
                        break;
                    default:
                        break;

                }

            }
            while (reply != "x");
            

                    
               



        }
    }
}
