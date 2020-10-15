using System;

namespace Section2._7._1._Classes_Demo
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
    }

    public Person Parse(string str)
    {
        var person = new Person();
        person.Name = str;

        return person;
    } 

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var p = person.Parse("John");
            person.Introduce("Abby");
        }
    }
}
