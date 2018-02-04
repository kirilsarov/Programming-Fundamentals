using System;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energyPerOneHundred = int.Parse(Console.ReadLine());
            int sugarPerOneHundred = int.Parse(Console.ReadLine());
            double energy = (volume / 100) * energyPerOneHundred;
            double sugar = (volume / 100) * sugarPerOneHundred;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
