using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string my_name = "Stephen Sanders";
            string my_location = "Illinois";
            int days_until_christmas;
            DateTime current_date = DateTime.Today;
            DateTime christmas = new DateTime(current_date.Year, 12, 25);
            double width, height, woodLength, glassArea;
            string widthString, heightString;


            // Start of code
            Console.WriteLine($"My name is {my_name}.");
            Console.WriteLine($"I am from {my_location}.\n");

            Console.WriteLine(current_date.ToString("d"));

            days_until_christmas = (christmas - current_date).Days;

            if (days_until_christmas < 0)
            {
                days_until_christmas += 365;
            }

            Console.WriteLine($"There are {days_until_christmas} days until Christmas.\n");

            // Section 2.1 Program Example
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            // End of operations
            Console.ReadKey();
        }
    }
}
