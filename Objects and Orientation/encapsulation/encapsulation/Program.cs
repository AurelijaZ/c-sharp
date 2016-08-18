using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    public class Meal
    {
        public string name;
        public decimal price;
        public decimal cost;

        //changed from public void meal to just public meal, so it connects with the menu
        public Meal(string name, decimal price, decimal cost)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;

        }

        public static decimal cookMeal(Meal meal, decimal balance)
        {
            Console.WriteLine("The meal {0} has been cooked.", meal.name);
            // balance = balance + meal.price;
            // balance = balance - meal.cost;

            // return balance;
            //only do the cooking, no balance 
        }
    }

    public class Order
    {
        public void takeOrder(Meal meal)
        {
            Console.WriteLine("The meal {0} has been ordered.", meal.name);
        }
    }
    //create private balance
    class Balance
    {
        private static decimal _balance_ = 0;

        public static void getBalance(decimal meal)
        {
            decimal balance = 0;
            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);
        }
    }


    class Program
    {

        static void Main(string[] args)
    {
        decimal balance = 0;

        //add some meals data
        Meal steak = new Meal("Steak", 20.00M, 5.00M);
            Balance.getBalance(steak);
        Meal fajitas = new Meal("Fajitas", 12.00M, 2.00M);
        Meal pumpkinRisotto = new Meal("Pumpkin Risotto", 10.00M, 1.00M);


        Order order1 = new Order();
        order1.takeOrder(steak);
        balance = Meal.cookMeal(steak, balance);

        Order order2 = new Order();
        order2.takeOrder(pumpkinRisotto);
        balance = Meal.cookMeal(pumpkinRisotto, balance);

        Console.WriteLine("You need to pay: £{0:N2}.", balance);

    }
}
}