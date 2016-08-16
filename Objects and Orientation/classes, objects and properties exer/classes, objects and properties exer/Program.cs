using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes__objects_and_properties_exer
{
    //Create seperate class for just the strings + make sure its set into namespace instead of class.
    class Car
    {
        public string make;
        public string model;
        public int price;
        public bool sold;

        public string result;


        public static int carSold;
        public static int carStock;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //3 objects for car dealership
            Car myCar = new Car();

            myCar.make = "Volkswagen";
            myCar.model = "The Beetle";
            myCar.price = 13500;
            myCar.sold = false;
            //make car.stock if you're trying to do total number of cars in stock.
            // Car.carStock++;

            //make seperate class for each property
            Car myCar2 = new Car();
            myCar2.make = "Mazda";
            myCar2.model = "MX5";
            myCar2.price = 18450;
            myCar2.sold = false;

           
            Car myCar3 = new Car();
            myCar3.make = "Audi";
            myCar3.model = "A1";
            myCar3.price = 14530;
            myCar3.sold = false;

            Car.carSold ++;

            // create control function for each property with class taken from each property
            Console.WriteLine("Total number of cars sold is: " + Car.carSold ); //notifies the user of how many cars have been sold.
            Console.WriteLine("The Details of this car are:");
            Console.WriteLine("Make and Model:" + myCar.make + " " + myCar.model + " , " + "price: " +  myCar.price);
            Console.WriteLine("Make and Model:" + myCar2.make + " " + myCar2.model + " , " + "price: " + myCar2.price);
            Console.WriteLine("Make and Model:" + myCar3.make + " " + myCar3.model + " , " + "price: " + myCar3.price);

        } //end main
       
    }
}
