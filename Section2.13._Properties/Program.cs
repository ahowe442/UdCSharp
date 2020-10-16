using System;

namespace Section2._13._Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Person();
            person.Birthdate = new DateTime(1982, 1, 1);
            Console.WriteLine(person.Age); 
        }
    }
}
