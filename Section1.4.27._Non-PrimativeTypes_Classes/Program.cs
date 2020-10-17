using System;
using static Section1._4._27._Non_PrimativeTypes_Classes.Math.Program;

namespace Section1._4._27._Non_PrimativeTypes_Classes
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section1._4._27._Non_PrimativeTypes_Classes");
            Console.WriteLine("Classes combine related variables (fields) and Functions (methods)");
            /*
             Classes are blueprints for creating objects.
            Objects are instances of a class.

             */

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);

            Console.WriteLine(result);


        }
    }
}
