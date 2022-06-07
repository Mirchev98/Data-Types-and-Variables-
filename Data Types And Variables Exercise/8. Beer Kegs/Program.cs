using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string biggestKegName = "";

            for (int currentKeg = 1; currentKeg <= kegs; currentKeg++)
            {
                string kegModel = Console.ReadLine();

                float kegRadius = float.Parse(Console.ReadLine());

                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (kegVolume > biggestKeg)
                {
                    biggestKeg = kegVolume;
                    biggestKegName = kegModel;
                }

            }

            Console.WriteLine(biggestKegName);
        }
    }
}
