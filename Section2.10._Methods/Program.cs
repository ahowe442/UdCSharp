using System;

namespace Section2._10._Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
               var num = int.Parse("abc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conversion Failed (in the try catch block)");
            }
            
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed (TryParse).");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5}));
        }

        static void UsePoints()
        {
            Console.WriteLine("Section2._10._Methods");

            //Goals for Learning:
            /* Signature Methods
             * Params Modifier //Useful
             * Ref Modifier //Code Smells & Not Useful
             * Out Modifier //Code Smells & Not Useful
             */
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occured");

            }
        }
    }
}
