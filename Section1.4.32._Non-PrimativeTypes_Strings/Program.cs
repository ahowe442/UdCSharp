using System;

namespace Section1._4._32._Non_PrimativeTypes_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section1._4._32._Non_PrimativeTypes_Strings");

            /*
             * What is a string
             *  a sequence of characters. 
             *  
             * How to create strings
             *  string literal
             *  concatenate with plus operator. 
             *  string.Format
             *  string.Join
             *  
             *  
             * Escape characters and verbatim strings
             *  New Line, Tab, Backslash, Single Quottion mark, DOuble Quotation mark etc...
            */

            //In this case creating strings can be a little messy by using the escape character which results in double backslashes. 
            string path = "c:\\projects\\project1\\folder1";


            //Verbatim String
            string path1 = @"c:\projects\project2\folder1";

            Console.WriteLine(path);
            Console.WriteLine(path1);


            //using the string keywaord. 
            var firstName = "Mosh";
            //Using class
            // if you write strings like the below example you must use the system namespace.  
            String lastName = "Hamedani";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //Using the format string
            var myFullName = string.Format("My full name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            //string.Join Example

            // Create an array of names.
            var names = new string[5] { "Abby", "Vail", "Vivian", "HUdson", "Emmett" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            Console.WriteLine();

            var text2 = @"Hi John
Look into the second version of the verbatim string paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text2);





        }
    }
}
