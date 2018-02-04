using System;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int numberone = int.Parse(Console.ReadLine());
            int numbertwo = int.Parse(Console.ReadLine());
            int numberthree = int.Parse(Console.ReadLine());
            int numberfour = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numberone:d4} {numbertwo:d4} {numberthree:d4} {numberfour:d4}");
        }
    }
}
