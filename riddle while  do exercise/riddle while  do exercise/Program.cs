using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riddle_while__do_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feed me and I live, yet give me a drink and I die");
            Console.WriteLine("What am I?");
            string answer = "fire";
            bool statement = false;

            do
            {
                int reply = Convert.ToInt32(Console.ReadLine());
                if (reply = answer)
                {
                    Console.WriteLine("Yay you! You got it right!");

                }
            } while (statement == false);
    }
}
