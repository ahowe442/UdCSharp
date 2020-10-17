using System;

namespace Section1._4._29._Non_PrimativeTypes_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section1._4._29._Non_PrimativeTypes_Structs");

            /*
             Similar to classes
            uses the struct keyword
            combines related field and methods together.

            Most of the time you will you create new types with classes not struct

            Use structures when yoiu ar tying to define a small lightweight object like the example below. 
             */
        }

        public struct RgbColor
        {
            public int Red;
            public int Green;
            public int Blue;
        }
    }
}
