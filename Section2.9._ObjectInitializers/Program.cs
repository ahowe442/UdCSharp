using System;

namespace Section2._9._ObjectInitializers
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime Birthdate;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section2._9._Object Initializers");
            // In this example you can see this utilized the IDE created
            //default construtor above.
            // The curly brackets are the basis to initalize the object. 
            var person = new Person
            {
                Birthdate = 09 / 03 / 1097,
                FirstName = "Abby",
                LastName = "Howe",
                Id = 1
            };

        }
    }
}
