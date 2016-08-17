using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle //create vehicle class and then move on to next ingeritance topics
    { //Create seperate class for just the strings + make sure its set into namespace instead of class.
        public string make;
        public string model;
        public int price;
        public bool sold;
        public int wheels;

        public int priceSell;
        public static int vehicleSold;
        //public static int vehicleStock;
        public static int numberOfVehicles;

        public Vehicle (string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.wheels = 4;
            Vehicle.numberOfVehicles++;

        }
        public void ListVehicle()
        {
            Console.WriteLine("The Details of the car  are: ");
            Console.WriteLine("Make and the model:" + make + model + price);
            if (sold)
            {
                Console.WriteLine("The vehicle has been sold.");
            }
            else
            {
                Console.WriteLine("The vehicle has not yet been sold.");
            }
            Console.WriteLine();
        }

        public void SellVehicle(bool sold, int priceSell)
        { //record the sale
            this.sold = sold;
            this.priceSell = priceSell; //new set function to find out a price of the sold car
            Vehicle.vehicleSold++; Vehicle.numberOfVehicles--;
        }
        //list all the vehicles
        public static void ListAllVehicles(List<Vehicle> allVehicles)
        {
            int totalValueSold = 0;
            int totalValueInStock = 0;

            foreach (Vehicle item in allVehicles)
            {
                Console.WriteLine("The Details of the vehicles are: ");
                Console.WriteLine("Make and the model: " + item.make + item.model + " £ " + item.price);
                if (item.sold)             //create an if funtion 
                {
                    Console.WriteLine("This vehicle has been sold.");
                    totalValueSold += item.priceSell;
                }
                else
                {
                    Console.WriteLine("This vehicle is unsold");
                    totalValueInStock += item.price;
                }
                Console.WriteLine();
            }
            //add another record of how many cars have been sold, and then repeat the function of telling how many cars are left.
            Console.WriteLine("Number of vehicles sold: " + vehicleSold);
            Console.WriteLine("Number of vehciles in stock:" + numberOfVehicles);
            Console.WriteLine("Total value of vehicles sold is: " + totalValueSold);
            Console.WriteLine("Total value of vehicles in stock is: " + totalValueInStock);
            Console.WriteLine();
        }
    } // end of vehicle

    class Car : Vehicle
    {
        public static int numberOfCars;

        public Car (string make, string model, int price, string type= "car") : base (make, model, price)
        {
            this.wheels = 4;
            numberOfCars++;
        }

        //record the sale of cars
        public void SoldCar(bool isSold, int price)
        {
            SellVehicle(isSold, price);
            //adjust the number of cars
            numberOfCars--;
        }
    } //end of car

    class Motorcycle : Vehicle
    {
        public static int numberOfMotorcycles;
        public Motorcycle (string make, string model, int price, string type= "motorcycle") : base ( make, model, price)
        {
            this.wheels = 2;
            numberOfMotorcycles++;
        }

        //record the sale of motorcycles
        public void SellMotorcycle (bool isSold, int price)
        {
            SellVehicle(isSold, price);
            //adjust the numner of motorcycles
            numberOfMotorcycles--;
        }
    } //end of motorcycle

    class Program
    {
        static void Main(string[] args)
        {
            //create a list for all cars
            List<Vehicle> vehicles = new List<Vehicle>();
            Car car1 = new Car("Volkswagen ", "The Beetle ", 13500);
            vehicles.Add(car1);

            Car car2 = new Car("Mazda ", " MX5 ", 18450);
            vehicles.Add(car2);
            Car car3 = new Car("Audi ", " A1 ", 14530);
            vehicles.Add(car3);
            Car car4 = new Car("Range Rower ", " Discovery ", 35000);
            car4.SellVehicle(true, 25000); // it lets the user know if you see the car (true) and for how much it was resold.
            vehicles.Add(car4);
            Motorcycle bike1 = new Motorcycle("Honda", " Naked ", 15000);
            vehicles.Add(bike1);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of motorcycles in stock is: {0} ", Motorcycle.numberOfMotorcycles);
            //make a list for all ve as a constructor to save some space on coding
            Vehicle.ListAllVehicles(vehicles);



        }
    } //end main
}

