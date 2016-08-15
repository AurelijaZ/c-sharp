using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers to be averaged, pressing return each time:");
            decimal[] numbers = new decimal[5];

            //call for loop 
            for (int i = 0; i < numbers.Length; i++)
            {
                //read the input by the user and ask for more numbers.
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter another number:");
            }
            //calculate the average and show the total
            Console.WriteLine("The average is of your 5 numbers is:" + (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) / 5);
        }
    }
}
