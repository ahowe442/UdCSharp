using System;

namespace Section1._4.Non_PrimativeTypes_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section1._4.Non_PrimativeTypes_Arrays");
            /*
             What is an array?
                An array is a data structure that we use to store values.

            let say we want to work with 3 numnbers, so instead of declaring 3 variables we can use a single array. 
            Declaring An Array -
            Initalizing and arry -
            Access Array Elements - 
             */
            // Ex. let say we want to work with 3 numnbers, so instead of declaring 3 variables we can use a single array.
            //Three variables. 
            int number1;
            int number2;
            int number3;
            //Single Array
            int[] numbers = new int[3];//number in brackets sets the size.  This is fixed and can't be changed.

            //Accessing Array ELements.
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            //If you know the values ahead of time you can use the arry initialization syntax and make your code shorter.  i.e.
            int[] numbers1 = new int[3] { 4, 5, 6 };

            // you can make the code shorter by using the "var" variable syntax.
            //The code knows that var shortCodeArray is a three value int array so there is no need to declare that twice. 
            var shortCodeArray = new int[3] { 7, 8, 9 };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //Bool arrays are always initialized to "false".
            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            //String Array of names.
            var names = new string[3] { "Jack", "John", "Mary" };
            //looping through the list is often the best way to access each value in the array. 
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
               
            

        }
    }
}
