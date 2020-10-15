using System;
using System.Collections.Generic;

namespace Section2._8._Constructors
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1,"John");
            Console.WriteLine("Section2._8._Constructors");
            Console.WriteLine();
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Id);

            var Order = new Order();
            //This is what Mosh said was a hack.
            //The main method should not be the method that
            //initializes the orders list.
            /****The job of this class is to add an order to the customer.****/
            //customer.Orders = new List<Order>();
            customer.Orders.Add(Order);
        }
    }
}
