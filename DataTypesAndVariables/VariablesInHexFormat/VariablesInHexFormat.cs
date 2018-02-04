using System;

namespace VariablesInHexFormat
{
    class VariablesInHexFormat
    {
        static void Main(string[] args)
        {
            string hexa = Console.ReadLine();
            int number = Convert.ToInt32(hexa, 16);
            Console.WriteLine(number);
        }
    }
}
