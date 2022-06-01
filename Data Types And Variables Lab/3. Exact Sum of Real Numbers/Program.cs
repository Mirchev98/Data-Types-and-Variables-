using System;

namespace _3._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numbers = decimal.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                decimal inputNumber = decimal.Parse(Console.ReadLine());
                sum += inputNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
