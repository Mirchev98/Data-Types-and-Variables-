using System;

namespace _2._Pounds_to_Dollars
{
    internal class Program
    {

        static void Main()
        {
            int pounds = int.Parse(Console.ReadLine());

            double poundsToUsRate = 1.31;

            double dollars = pounds * poundsToUsRate;
            
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
