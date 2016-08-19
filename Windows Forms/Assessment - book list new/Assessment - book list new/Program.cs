using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment___book_list_new
{
    //Create seperate class for just the strings + make sure its set into namespace instead of class.
    public class Book
    {
        public string bookTitle;
        public string author;
        public double bookPrice;
        public decimal bookISBN;
        public string deleteBook;

        public Book (string bookTitle, double bookPrice, decimal bookISBN)
        {
            this.bookTitle = bookTitle;
            //this.author = author;
            this.bookPrice = bookPrice;
            this.bookISBN = bookISBN;

        }
        class Program
        {
            static void Main(string[] args)
            {
                //creating a string functions for switch statements 
                string reply;
                string addBook;
                string deleteBook;
                string bookTitle;
                //string bookAuthor;
                int bookPrice;
                int bookISBN;


                List<Book> myBooks = new List<Book>();

                Book book1 = new Book("ACOMAF", 8.99, 9781619634466);        
                Book book2 = new Book("Harry Potter", 8.99, 9780439554930);
                Book book3 = new Book("Game Of Thrones", 7.99, 9780553588484);
                Book book4 = new Book("Chronicles of Narnia", 7.99, 9780066238500);
                //add the books onto the actual list
                myBooks.Add(book1);
                myBooks.Add(book2);
                myBooks.Add(book3);
                myBooks.Add(book4);

                //create a do function to pop up for the user and make it case sensitive.
                do
                {
                    Console.WriteLine("Please select a letter of your choice: A = Add a Book to the List, ");
                    Console.WriteLine("B = Search a book,");
                    Console.WriteLine("D = Delete a book from the list,");
                    Console.WriteLine("S = Sort the books,");
                    Console.WriteLine("V = View All the Books,");
                    Console.WriteLine("X = Exit");
                    reply = Console.ReadLine().ToLower();

                //create a swtich statement for each letter in the function statment.
                        switch (reply)
                        {
                            case "a": //add a book
                                Console.WriteLine("Add a Title to the List:");
                                addBook = Console.ReadLine();
                                Console.WriteLine("Enter a price");
                                bookPrice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Please enter the ISBN:");
                                bookISBN = Convert.ToInt32(Console.ReadLine());

                                Book moreBooks = new Book(addBook, bookPrice, bookISBN);
                                myBooks.Add(moreBooks);
                                Console.WriteLine(addBook + + bookPrice + bookISBN + " has been added."); //notify the user that the book has been added to the list.
                                break;
                           case "b": //search the book
                             /* bookTitle = Console.ReadLine();
                              bool found = myBooks.Contains(bookTitle);
                             
                                 if (found) //create if statements if the book has been found or not.
                            { Console.WriteLine("Book has been found: "); } //declare that the book was found
                                else { Console.WriteLine("Title has not been found"); } //declare if the book has not been found */
                                break; 
                            case "d": //delete the book
                            reply = Console.ReadLine();
                            int indexMatch = myBooks.FindIndex(i => i.bookTitle == reply);
                            if (indexMatch >= 0) //match the title to 0
                            {
                                myBooks.Remove(myBooks[indexMatch]);
                                Console.WriteLine(reply + " has been deleted from the list."); //let the user know that the book has been deleted.
                            }
                                break;
                            case "s": //sort the list of books  
                                myBooks.Sort(); //currently doenst work
                                break;
                            case "v": //show the list
                                      // for (int i = 0; i < myBooks.Count; i++) //count all the books to display on the screen
                                      // { Console.WriteLine(myBooks[i]); }
                            foreach (Book v in myBooks)
                            { 
                                Console.WriteLine("Book: {0}, Price: {1}, ISBN: {2}.", v.bookTitle, v.bookPrice, v.bookISBN);                      
                            }

                                break;
                            default:
                                break;

                        }

                } while (reply != "x"); //while function for the x button
            }
        }
    }
}//end
