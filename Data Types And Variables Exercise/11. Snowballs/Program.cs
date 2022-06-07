using System;
using System.Numerics;

namespace _11.__Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());

            string bestSnowballFormula = "";
            BigInteger highestSnowballValue = 0;
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            BigInteger snowballQuality = 0;

            for (int currentSnowball = 1; currentSnowball <= snowballs; currentSnowball++)
            {
                snowballSnow = int.Parse(Console.ReadLine());

                snowballTime = int.Parse(Console.ReadLine());

                snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = (int)Math.Pow((double)(snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    string bestSnowballFormula = ($"{snowballSnow} : {snowballTime} = " +
                $"{highestSnowballValue} ({snowballQuality})");
                }
            }

            Console.WriteLine(bestSnowballFormula);


        }
    }
}
