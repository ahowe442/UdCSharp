using System;

namespace Section2._3._19._AssociationnBetweenClasses_Composition
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section2._3._19._AssociationnBetweenClasses_Composition");

            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}
