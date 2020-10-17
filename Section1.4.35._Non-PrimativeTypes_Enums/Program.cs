using System;

namespace Section1._4._35._Non_PrimativeTypes_Enums
{
    //Best Practice = Set the value of the enum explicitly. 
    public enum ShippingMethod
    {
        RegularMail = 1,
        RegisteredMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section1._4._35._Non_PrimativeTypes_Enums");
            var method = ShippingMethod.Express;
            //To display the numeric value of the shipping method.
            Console.WriteLine((int)method);
            //convert to the shipping method from a number.
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            var methodId1 = 1;
            Console.WriteLine((ShippingMethod)methodId1);

            //ToString()
            Console.WriteLine(method.ToString()); //returns Express
            //COnsole.WriteLIne will always convert to a string.
            Console.WriteLine(method); //returns Express


            //Convert method name to enum.
            var methodName = "RegisteredMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        }
    }
}
