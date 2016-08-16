using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure__dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                { "C#", "Pretty awesome language." },
                { "C++", "Merh." },
                { "Java", "Not bad." },
                {"JavaScript", "its alright." },
            };
            //create strings for dictionary

            string answer;
            string result;
            string add;
            string add2;
            string remove;
            //create a do function, create a message pop up and make it case sensitive.
            do
            {
                Console.WriteLine("Welcome to the Language Dictionary! Press A = to check if a key is in the dictionary, B = Check if a value is in the dictionary, C = Count the List, K = To look up a value, D = To remove an entry, F = Add an entry.");
                Console.WriteLine("X = exit");
                answer = Console.ReadLine().ToLower();

                //create each switch statement for each letter in the options button. 
                switch (answer)
                {
                    case "f":
                        Console.WriteLine("Add a key and a valuable");
                        add = Console.ReadLine();
                        add2 = Console.ReadLine();
                        dict.Add(add, add2);
                        Console.WriteLine(add + " has been added to the list."); //tell the user that the entry has been added.

                        break;
                    case "d":
                        Console.WriteLine("Delete an from the list");
                        remove = Console.ReadLine();
                        dict.Remove(remove);
                        Console.WriteLine(remove + " has been removed from the list."); //tell the user the book has been deleted.
                        break;
                    case "a":
                        Console.WriteLine("Please enter a key to search for:"); //ask for a key name to search it through.
                        answer = Console.ReadLine();
                        bool found = dict.ContainsKey(answer);
                        if (found)
                        {
                            Console.WriteLine("your key has been found"); //provide if statments for both options if either found or non existing.
                        }
                        else
                        {
                            Console.WriteLine(" you search has not been found");
                        }
                        break;
                    case "b":
                        Console.WriteLine("Please enter a value name:"); //ask for a value name to search it through.
                        answer = Console.ReadLine();
                        bool founded = dict.ContainsValue(answer);
                        if (founded)
                        {
                            Console.WriteLine("your value has been found"); //provide if statments for both options if either found or non existing.
                        }
                        else
                        {
                            Console.WriteLine(" you search has not been found");
                        }
                        break;
                    case "c":
                        dict.Count(); //simple count 
                        break;
                    case "k":
                        dict.TryGetValue(answer, out result); //using a key to lookup a value
                        break;
                    default:
                        break;
                }
            }
            while (answer != "x"); //finsih with a while 
        }
    }
}
