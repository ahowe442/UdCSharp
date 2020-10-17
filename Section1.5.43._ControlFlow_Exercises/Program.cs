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

            /*
             * 
             * 2- Write a program which takes two numbers from the console 
             * and displays the maximum of the two.
             *
             */
            Console.WriteLine("Enter first numnber: ");
            var input1 = Console.ReadLine();
            int num1 = int.Parse(input1);

            Console.WriteLine("Enter second numnber: ");
            var input2 = Console.ReadLine();
            int num2 = int.Parse(input2);

            var sum = num1 + num2;
            Console.WriteLine($"The maximum of your two numbers is: {sum}");

            /*
             * 3- Write a program and ask the user to enter the width and height
             * of an image. Then tell if the image is landscape or portrait.
             */

            Console.WriteLine("Enter the width of your image: ");
            var input3 = Console.ReadLine();
            int width = int.Parse(input3);
            Console.WriteLine("Enter the height of your image: ");
            var input4 = Console.ReadLine();
            int height = int.Parse(input4);

            if (height < width)
            {
                Console.WriteLine("Your image is a Landscape format");
            }
            else if (width < height)
            {
                Console.WriteLine("Your image is a Portrait format");
            }
            else
            {
                Console.WriteLine("Is neither a landscape nor portrait format.  ");
            }

            /*
             * 
             * 4- Your job is to write a program for a speed camera. For 
             * simplicity, ignore the details such as camera, sensors, etc and
             * focus purely on the logic. Write a program that asks the user to
             * enter the speed limit. Once set, the program asks for the speed
             * of a car. If the user enters a value less than the speed limit,
             * program should display Ok on the console. If the value is above
             * the speed limit, the program should calculate the number of
             * demerit points. For every 5km/hr above the speed limit, 1 demerit
             * points should be incurred and displayed on the console. If the
             * number of demerit points is above 12, the program should display
             * License Suspended.
             * 
             */

            Console.WriteLine("enter the speed limit: ");
            var speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the speed of the car: ");
            var speedOfCar = int.Parse(Console.ReadLine());

            if (speedOfCar <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (speedOfCar > speedLimit)
            {
                var difference = speedOfCar - speedLimit;
                var demerits = (speedOfCar - speedLimit)/5;
                Console.WriteLine($"Because you were speeding by {difference} MPH, you earned {demerits} demerits. ");
                
            }

        }
    }
}
