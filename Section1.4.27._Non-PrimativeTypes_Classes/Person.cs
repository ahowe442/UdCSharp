using System;

namespace Section1._4._27._Non_PrimativeTypes_Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }
    }
}
