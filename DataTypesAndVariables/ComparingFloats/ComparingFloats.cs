using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double difference = Math.Abs(num1 - num2);
            if (difference >= eps)
            {
                Console.WriteLine("False");
            }
            else if (difference < eps)
            {
                Console.WriteLine("True");
            }
        }
    }
}
