using System;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int counter = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    int digits = (i * j)*3;
                    totalSum += digits;
                    if (totalSum < thirdNum)
                    {
                        counter++;
                    }
                    else if (totalSum >= thirdNum)
                    {
                        counter++;
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {thirdNum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
