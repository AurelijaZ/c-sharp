using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snow_white_ex
{
    class Program
    {  
        static void Main(string[] args)
        {

            //make an array of strings with all seven dwarves names.
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Dopey", "Bashful", "Grumpy", "Sneezy"};
            //create new strings for drink and dinner
            string[] dinner = new string[7];
            string[] drink = new string[7];

            //make a for loop to ask each dwarve for what they'll be eating.
            for (int i=0; i < dinner.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + " will be eating?");
                   dinner[i] = Console.ReadLine();
            }
            // create for loop to push an array into drink array.
            for (int i = 0; i < dinner.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + ", your " + dinner[i] + " is ready");
            }

            for (int i=0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine( sevenDwarves [i] + " will be drinking?");
                dinner[i] = Console.ReadLine(); 
            }
            for (int i = 0; i < dinner.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + ", your " + drink[i] + " is ready");
            }


        }
    }
}
