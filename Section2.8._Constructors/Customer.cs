using System.Collections.Generic;

namespace Section2._8._Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders; 

        //Three constructors = Overloaded constructor.
        public Customer()
        {
            //The IDE auto creates a parameterless constructor.
            //Once we begin creating construtors (like the ones below then we
            //need to also create a parameterless constructor (like this one).

            //When we have a list of any type we should automatically initialize that list:
            var Orders = new List<Order>();
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            
            this.Name = Name; 
        }

    }
}
