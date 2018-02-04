using System;

namespace VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if (input == 97 || input == 101 || input == 105 || input == 111 || input == 117 || input == 121)
            {
                Console.WriteLine("vowel");
            }
            else if (input >= 48 && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
