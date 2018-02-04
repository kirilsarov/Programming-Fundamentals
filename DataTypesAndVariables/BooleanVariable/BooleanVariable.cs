using System;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();
            bool isItTrue = Convert.ToBoolean(boolean);
            if (isItTrue == true)
            {
                Console.WriteLine("Yes");
            }
            else if (isItTrue == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
