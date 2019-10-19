using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double height;
            double area;
            double perimeter;
            double volume;
            string userInput;

            do
            {
                Console.WriteLine("Enter Length");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width");
                width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Height");
                height = double.Parse(Console.ReadLine());

                area = length * width;
                perimeter = 2 * (length + width);
                volume = length * width * height;

                Console.WriteLine("The Perimeter of the Room is " + perimeter);
                Console.WriteLine("\nThe Area Of the Room Is " + area);
                Console.WriteLine("\nThe Volume of the Room Is " + volume);
                Console.WriteLine("\nWould you like to calculate the measurements of another room in your haunted house -- like the cellar or the attic?");
                userInput = Console.ReadLine();

                if (userInput == "no")
                {
                    Console.WriteLine("Goodbye!");
                }
                else if (userInput == "yes")
                {
                    Console.WriteLine("Fantastic!");
                }
                else // If userInput is not yes or no we allow you to continue by setting userInput to yes
                {
                    Console.WriteLine("I assume you meant yes.");
                    userInput = "yes";
                }
            } while (userInput == "yes");

            Console.WriteLine("You are now exiting this program.");
        }
    }
}
