using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a random generator for the game
            Random random = new Random();
            int num = random.Next(1,50);
            bool anotherTry = true;

            Console.WriteLine("I'm thinking of a number, can you guess what it is?");


            do
            {
                int response = Convert.ToInt32(Console.ReadLine());
                if (response == num)
                {
                    Console.WriteLine("Wow, well done!");
                    anotherTry = true;
                }
                else if (response > num)
                {
                    Console.WriteLine("I'm thinking of a smaller number");
                }
                else
                {
                    Console.WriteLine("I'm thinking of a bigger Number");
                  
                }
            } while (anotherTry != true);
        }
    }
}
