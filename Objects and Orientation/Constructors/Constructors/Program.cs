using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
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
        public static int numberOfCars;

        public Car(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.numberOfCars++;

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
            Car.carSold++; Car.carStock--;
        }
        //list all the cars
        public static void ListAllCars(List<Car> allCars)
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
                    totalValueSold += item.priceSell;
                }
                else
                {
                    Console.WriteLine("This car is unsold");
                    totalValueInStock += item.price;
                }
                Console.WriteLine();
            }
            //add another record of how many cards have been sold, and then repeat the function of telling how many cars are left.
            Console.WriteLine("Number of cars sold: " + carSold);
            Console.WriteLine("Total value of cars sold is: " + totalValueSold);
            Console.WriteLine("Total value of cars in stock is: " + totalValueInStock);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create a list for all cars
            List<Car> Cars = new List<Car>();
            Car car1 = new Car("Volkswagen ", "The Beetle ", 13500);
            Cars.Add(car1);

            Car car2 = new Car("Mazda ", " MX5 ", 18450);
            Cars.Add(car2);
            Car car3 = new Car("Audi ", " A1 ", 14530);
            Cars.Add(car3);
            Car car4 = new Car("Range Rower ", " Discovery ", 35000);
            car4.SellCar(true, 25000); // it lets the user know if you see the car (true) and for how much it was resold.
            Cars.Add(car4);

            //make a list for all cars as a constructor to save some space on coding
            Car.ListAllCars(Cars);


   

        }
    } //end main
}

