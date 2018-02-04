using System;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int time = seconds + minutes * 60 + hours * 3600;

            double metersPerSecond = (double)distance / (double)time;
            double kilometersPerHour = ((double)distance / 1000) / ((double)time / 3600);
            double milesPerHour = ((double)distance / 1609) / ((double)time / 3600);

            Console.WriteLine($"{metersPerSecond:0.######}");
            Console.WriteLine($"{kilometersPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");
        }
    }
}
