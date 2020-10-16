using System;

namespace Section2._12._AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section2._12._AccessModifiers");

            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 01, 01));
            Console.WriteLine(person.GetBirthdate());
            
        }

    }

    
}
