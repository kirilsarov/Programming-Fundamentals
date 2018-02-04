using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string strOne = Console.ReadLine();
            string strTwo = Console.ReadLine();
            object sum = strOne + " " + strTwo;
            Console.WriteLine(sum);
        }
    }
}
