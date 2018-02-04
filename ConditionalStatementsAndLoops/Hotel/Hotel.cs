using System;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());

            double sumStudio = 0;
            double sumDouble = 0;
            double sumSuite = 0;
            if (month == "May" || month == "October")
            {

                sumStudio = countNights * 50.0;
                sumDouble = countNights * 65.0;
                sumSuite = countNights * 75.0;

                if (month == "October" && countNights > 7)
                {
                    sumStudio = (countNights - 1) * 50.0;
                }

                if (countNights > 7)
                {
                    sumStudio = sumStudio - (sumStudio * 0.05);
                }


            }
            else if (month == "June" || month == "September")
            {
                sumStudio = countNights * 60.0;
                sumDouble = countNights * 72.0;
                sumSuite = countNights * 82.0;

                if (month == "September" && countNights > 7)
                {
                    sumStudio = (countNights - 1) * 60.0;
                }

                if (countNights > 14)
                {
                    sumDouble = sumDouble - (sumDouble * 0.10);
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                sumStudio = countNights * 68.0;
                sumDouble = countNights * 77.0;
                sumSuite = countNights * 89.0;

                if (countNights > 14)
                {
                    sumSuite = sumSuite - (sumSuite * 0.15);
                }
            }

            Console.WriteLine("Studio: {0:F2} lv.", sumStudio);
            Console.WriteLine("Double: {0:F2} lv.", sumDouble);
            Console.WriteLine("Suite: {0:F2} lv.", sumSuite);
        }
    }
}
