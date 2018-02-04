using System;

namespace FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int current = 2; current <= number; current++)
            {
                bool isItPrime = true;
                for (int delio = 2; delio <= Math.Sqrt(current); delio++)
                {
                    if (current % delio == 0)
                    {
                        isItPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{current} -> {isItPrime}");
            }

        }
    }
}
