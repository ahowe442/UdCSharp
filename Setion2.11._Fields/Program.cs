using System;
using System.Collections.Generic;

namespace Setion2._11._Fields
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setion2._11._Fields");

            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);

        }
    }
}
