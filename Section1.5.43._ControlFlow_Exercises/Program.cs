using System;

namespace Section1._5._43._ControlFlow_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section1._5._43._ControlFlow_Exercises");
            /*
             * 1- Write a program and ask the user to enter a number. 
             * The number should be between 1 to 10. If the user enters a 
             * valid number, display "Valid" on the console. Otherwise, 
             * display "Invalid". (This logic is used a lot in applications
             * where values entered into input boxes need to be validated.)
             */

            //Write a program and ask the user to enter a number.
            Console.WriteLine("Enter a number between 1-10: ");
            var input = Console.ReadLine();
            int num = int.Parse(input);

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }



        }
    }
}
