using System;

namespace _9.__Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int totalSpiceMined = 0;

            int days = 0;

            while (yield >= 100)
            {
                totalSpiceMined += yield - 26;
                yield -= 10;
                days++;
            }
            
            if (totalSpiceMined - 26 < 0)
            {
                totalSpiceMined = 0;
            }
            else
            {
                totalSpiceMined -= 26;
            }
            

            Console.WriteLine(days);
            Console.WriteLine(totalSpiceMined);
        
        }

    }
}
