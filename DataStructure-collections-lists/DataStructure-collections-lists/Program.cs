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
            string reply;
            string addBook;
            List<string> myBooks = new List<string>() { "Throne of Glass", "ACOMAF", "Harry Potter", "Game of Thrones" };
           

            do
            {
                Console.WriteLine("Please press a letter of your choice A = Add the Book, D = Delete a Book, L = List the Book, S = Sort the Book, X = Exit");
                reply = (Console.ReadLine()).ToLower();
                switch(reply)
                {
                    case "a":
                        Console.WriteLine("Add a book title to the list");
                        addBook = Console.ReadLine();
                        myBooks.Add(addBook);
                        break;
                    default:
                        break;

                }
            }
            while (reply != "x");
            

                    
               



        }
    }
}
