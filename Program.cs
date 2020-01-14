using System;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* Instructions:
             * Create a new Visual C# Console App using .NET Framework project and name it "ConsoleApplication."
            Store two variables:
            Your name / Your location (state or country)
            Output two WriteLine statements that display those two variables with proper labels (My name is ... , I am from ...) using String Interpolation.
            Output the current date but not the current time.
            Output the number of days until Christmas this year and, of course, apply an appropriate label to that output.
            Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
            Add these requirements to the code:
            Provide appropriate text labels when requesting dimensional input.
            Cause the program to pause in the console so that the application does not automatically terminate when launched from the Visual Studio run debugger tool.
            Hint: Consider Console.ReadKey()
            You do NOT need to add any sort of input validation.
            Push your completed solution to a GitHub repository.
            Submit your GitHub repository.
            */
            string myName;
            Console.Write("Please enter your name: ");
            myName = Console.ReadLine();
            string location;
            Console.Write($"Hi {myName}, where are you from? ");
            location = Console.ReadLine();
            Console.WriteLine($"Great {myName}, I bet {location} is a great place!");

            var currentDate = DateTime.Now;
            var futureDate = new DateTime(currentDate.Year, 12, 25);
            if (currentDate.Month == 12 && currentDate.Day >= 26)
            {
                futureDate = new DateTime((currentDate.Year + 1), 12, 25);
            }
            var daysToChristmas = (futureDate - currentDate);
            Console.WriteLine($"The current date is {currentDate.ToString("d")}, and we are only {daysToChristmas.Days + 1} day(s) away from Christmas!");
            Console.WriteLine("Let's calculate the amount of wood and glass required to make a window...");
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write($"Please {myName}, enter the desired width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write($"Now enter the desired height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}