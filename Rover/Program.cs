using System;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the location in the following format (X,Y,D) :");
            string location = Console.ReadLine();
            Console.WriteLine("Enter the commands :");
            string commands = Console.ReadLine();

            Rovers rover = new Rovers();
            rover.SetInitialValues(location, commands);
            rover.ReadCommand();
            Console.WriteLine("Updated Location :" + rover.GetUpdatedLocation());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
