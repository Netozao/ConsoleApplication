using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.Write("Please enter your name: ");
            myName = Console.ReadLine();
            string location;
            Console.Write("Where are you from? (City/State) ");
            location = Console.ReadLine();

            Console.WriteLine("Welcome " + myName);
            Console.WriteLine($"Your location is {location}");

            var currentDate = DateTime.Now;
            var futureDate = new DateTime(currentDate.Year, 12, 25);
            
            // ------------------------------------      
            // ----

            Console.WriteLine("The current date is " + currentDate.ToString("d"));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
