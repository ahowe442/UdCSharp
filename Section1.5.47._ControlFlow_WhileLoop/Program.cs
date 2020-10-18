using System;

namespace Section1._5._47._ControlFlow_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section1._5._47._ControlFlow_WhileLoop");


            // Both block of code below do the exact same thing.

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                    i++;
                
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: " + input);

            }

            Console.WriteLine("Second way to play echo!!");
            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; 
                }

                break;
            }
        }
    }
}
