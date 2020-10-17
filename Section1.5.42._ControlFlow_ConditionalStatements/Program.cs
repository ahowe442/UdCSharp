using System;

namespace Section1._5._42._ControlFlow_ConditionalStatements
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section1._5._42._ControlFlow_ConditionalStatements");

            int hour = 10;

            if (hour > 0 && hour < 12)
            {
               Console.WriteLine("It's morning");
            }         
            else if (hour >= 12 && hour < 18)
            {         
                Console.WriteLine("It's afternoon");
            }         
            else      
            {         
                Console.WriteLine("It's evening.");
            }


            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);


            var season = Season.Winter;
            switch (season)
            {
                case Season.Spring:
                case Season.Autumn:
                    Console.WriteLine("We've got a promotion. ");
                    break;
                case Season.Summer:
                case Season.Winter:
                    Console.WriteLine("There are not any sales at this time.");
                    break;
                default:
                    Console.WriteLine("Error, choose one of the four seasons. ");
                    break;
            }



        }
    }
}