using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int[] arrayTest = { 5, 8, 9, 4, 1 };
            string userInput;
            try
            {
                for (int i = -1; i < arrayTest.Length; i++)
                {
                    number += i;
                    Console.WriteLine(i);
                }


            }
            catch (IndexOutOfRangeException e)
            { Console.WriteLine(e.ToString()); }
            finally { Console.WriteLine("Index Out of Range");  }

            Console.WriteLine("Please enter a number: ");
            userInput = Console.ReadLine();

            try
            {
                number = Convert.ToInt32(userInput);
            }
            catch (System.FormatException e) { Console.WriteLine(e.ToString());  }
            finally { Console.WriteLine("Its not a number!");  }
        }
    }
}
