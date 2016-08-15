using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nextPresident
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare information and questions for the user to know whats the task
            Console.WriteLine("Donald Trump, Hilary Clinton are two primaries running for United States Presidency.");
            Console.WriteLine("Who do you think will win?");
           // create user input with lower case function
            string reply = (Console.ReadLine()).ToLower();
            //create a switch var for the switch fucntion
            switch (reply)
            {
                case "donald":
                case "donald trump":
                case "trump":
                    Console.WriteLine("You mean, the end of the world?");
                    break;
                case "hilary":
                case "hilary clinton":
                case "clinton":
                    Console.WriteLine("Go Girl Power!");
                    //always have break and then default at the end of the case.
                    break;
                default:
                    Console.WriteLine("Please choose a name.");
                    break;
            }
        }
    }
}
