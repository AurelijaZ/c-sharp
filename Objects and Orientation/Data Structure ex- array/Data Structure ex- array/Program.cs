using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_ex__array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers to be averaged, pressing return each time:");
            decimal[] numbers = new decimal[5];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter another number:");
            }
        }
    }
}
