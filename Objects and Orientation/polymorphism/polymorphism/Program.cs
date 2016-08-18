using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Car
    {
        public virtual void Wheel()
        {
            Console.WriteLine("This is a car ");
        }
    }
    class Wheels : Car
    {
        public override void Wheel()
        {
            Console.WriteLine("This car has this many wheels");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car());
            cars.Add(new Wheels());

           foreach (Car a in cars)
            {
                a.Wheel();
            }

        }
    }
}
