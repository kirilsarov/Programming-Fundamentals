using System;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = String.Empty;
            double price = 0.0;
            double discount = 0.0;
            if (groupSize > 0 && groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
                if (package == "Normal")
                {
                    price += 500;
                    discount = 0.05;
                }
                else if (package == "Gold")
                {
                    price += 750;
                    discount = 0.1;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    discount = 0.15;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
                if (package == "Normal")
                {
                    price += 500;
                    discount = 0.05;
                }
                else if (package == "Gold")
                {
                    price += 750;
                    discount = 0.1;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    discount = 0.15;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
                if (package == "Normal")
                {
                    price += 500;
                    discount = 0.05;
                }
                else if (package == "Gold")
                {
                    price += 750;
                    discount = 0.1;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    discount = 0.15;
                }
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            double discountAmount = price * discount;
            double finalPrice = price - discountAmount;
            double pricePerPerson = finalPrice / groupSize;
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
