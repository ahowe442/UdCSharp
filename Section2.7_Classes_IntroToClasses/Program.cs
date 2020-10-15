using System;

namespace Section2._7_Classes_IntroToClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section2._7_Classes_IntroToClass");

            /*Learning Goals: 
             * What is a class? 
             * Real World Example of a class. 
             * What is an object? 
             * Static Members. 
             */

            Person person1 = new Person();
            //Shorter way to write this code is with the keyword var.
            //Which automatically detects the type. 
            
            //Give the person a name
            person1.Name = "Abby";
            person1.Introduce();

            /*Instance vs. Static Members of a class
             * Instance = Accessible from an object. 
             */
            var person2 = new Person();
            person2.Name = "Ella Cabella";
            person2.Introduce();
            /*
             * Static = Accessible from the class. 
             * we don't have to create an instance of a class to call 
             * Console.WriteLine();
             */
            Console.WriteLine();
            /*Why use static members? 
             * We should use them to represent concepts that occur once or are singleton. 
             * An example is DateTime.Now
             */
            var now = DateTime.Now;
        }

        public class Person
        {
            //Should not be public but we are keeping is simple here. 
            public string Name;

            public void Introduce()
            {
                Console.WriteLine($"Hi my name is {Name}");
            }

        }
    }
}
