using System.Collections.Generic;

namespace Setion2._11._Fields
{
    partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;
            //Initialize the list this way so that you don't have to use it in a no-arg constructor.  
            public readonly List<Order> Orders = new List<Order>();

            public Customer(int id)
            {
                this.Id = id;
            }

            public Customer(int id, string name)
                : this(id)
            {
                this.Name = name;
            }

            public void Promote()
            {
                //..... readonly fields can onlly be initialized in the the initializer or in the constructor at the initial implementation. 
                //Orders = new List<Order>();
            }
        }
    }
}
