using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_exercise_non_static
{
    class Car
    { //Create seperate class for just the strings + make sure its set into namespace instead of class.
        public string make;
        public string model;
        public int price;
        public bool sold;

        public int priceSell;
        public static int carSold;
        public static int carStock;

        public void AddCar(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.carStock++;

        }
        public void ListCar()
        {
            Console.WriteLine("The Details of the car  are: ");
           Console.WriteLine("Make and the model:" + make + model + price);
            if (sold)
            {
                Console.WriteLine("The car has been sold.");
            }
            else
            {
                Console.WriteLine("The car has not yet been sold.");
            }
            Console.WriteLine();
        }

        public void SellCar(bool sold, int priceSell)
        { //record the sale
            this.sold = sold;
            this.priceSell = priceSell; //new set function to find out a price of the sold car
            Car.carSold++;
        }
        //list all the cars
        public static void ListAllCars(List<Car>allCars)
        {
            int totalValueSold = 0;
            int totalValueInStock = 0;

            foreach (Car item in allCars)
            {
                Console.WriteLine("The Details of the car  are: ");
                Console.WriteLine("Make and the model: " + item.make + item.model + " £ " + item.price);
                if (item.sold)             //create an if funtion 
                {
                    Console.WriteLine("This car has been sold.");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("This car is unsold");
                    totalValueInStock += item.price;
                }
                Console.WriteLine();
            }
            //add another record of how many cards have been sold, and then repeat the function of telling how many cars are left.

            Console.WriteLine("Total value of cars sold is: " + totalValueSold);
            Console.WriteLine("Total value of cars in stock is: " + totalValueInStock);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // objects for car dealership
            Car myCar = new Car();

            myCar.make = "Volkswagen ";
            myCar.model = "The Beetle ";
            myCar.price = 13500;
            myCar.sold = false;
            //make car.stock if you're trying to do total number of cars in stock.
            Car.carStock++;

            //make seperate class for each property
            Car myCar2 = new Car();
            myCar2.make = "Mazda ";
            myCar2.model = " MX5 ";
            myCar2.price = 18450;
            myCar2.sold = false;


            Car myCar3 = new Car();
            myCar3.make = "Audi ";
            myCar3.model = " A1 ";
            myCar3.price = 14530;
            myCar3.sold = false;
            Car.carStock++;

            //add more properties and set the Add car function.
            Car myCar4 = new Car();
            myCar4.AddCar("Range Rower ", " Discovery ", 35000);
            myCar4.SellCar(true, 25000); // it lets the user know if you see the car (true) and for how much it was resold.

            myCar.ListCar();
            myCar2.ListCar();
            myCar3.ListCar();


            // create control function for each property with class taken from each property
            Console.WriteLine("Total number of cars in stock is: " + Car.carStock); //notifies the user of how many cars are in stock.
            Console.WriteLine("The Details of this car are:");
            Console.WriteLine("Make and Model:" + myCar.make + " " + myCar.model + " , " + "price: " + myCar.price);
            Console.WriteLine("Make and Model:" + myCar2.make + " " + myCar2.model + " , " + "price: " + myCar2.price);
            Console.WriteLine("Make and Model:" + myCar3.make + " " + myCar3.model + " , " + "price: " + myCar3.price);
            Console.WriteLine("Cars sold: " + Car.carSold);
            Console.WriteLine("Car was sold: " + myCar4.make + ", "+ myCar4.model + ", " + myCar4.price + " for the price: " + myCar4.priceSell);


        }
    } //end main
}

