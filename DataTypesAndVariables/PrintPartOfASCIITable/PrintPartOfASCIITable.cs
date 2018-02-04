using System;

namespace PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            int chrOne = int.Parse(Console.ReadLine());
            int chrTwo = int.Parse(Console.ReadLine());
            for (char i = (char)chrOne; i <= (char)chrTwo; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
