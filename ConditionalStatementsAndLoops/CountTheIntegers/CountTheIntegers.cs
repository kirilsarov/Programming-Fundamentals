using System;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
