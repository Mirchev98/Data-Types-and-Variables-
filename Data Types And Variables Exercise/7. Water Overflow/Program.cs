using System;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;

            int numberOfLines = int.Parse(Console.ReadLine());

            int total = 0;

            for (int line = 1; line <= numberOfLines; line++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if (total + quantity <= CAPACITY)
                {
                    total += quantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            Console.WriteLine(total);

        }
    }
}
