using System;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredient;
            for (int i = 1; i <= 21 ; i++)
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {i-1} ingredients.");
                    break;
                }
            }
        }
    }
}
