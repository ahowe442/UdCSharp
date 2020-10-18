using System;

namespace Section2._3._18._AssociationBetweenClasses_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section2._3._18._AssociationBetweenClasses_Inheritance");

            var text = new Text();
            text.Width = 100;
            text.Copy();

        }
    }
}
