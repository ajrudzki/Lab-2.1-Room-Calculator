using System;

namespace Lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the length of the room"); // user inputs length data
            string entry = Console.ReadLine();
            double length = double.Parse(entry);
            Console.WriteLine($"Enter the width of the room"); // user inputs width data
            string width_entry = Console.ReadLine();
            double width = double.Parse(width_entry);
            double area = length * width;
            Console.WriteLine($"Area = {area}");
            double perimeter = (length + width) * 2;
            Console.WriteLine($"Perimeter = {perimeter}");
            if (area < 250)
            {
                Console.WriteLine($"This is a small-sized room");
            }
            else if (area > 250 && area < 650)
            {
                Console.WriteLine($"This is a medium-sized room");
            }
            else if (area > 650)
            {
                Console.WriteLine($"This is a large-sized room");
            }
        }
    }
}
