using System;

namespace _10.__Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());

            int pokeDistance = int.Parse(Console.ReadLine());

            int numY = int.Parse(Console.ReadLine());

            int pokeCounter = 0;

            int pokePowerCopy = pokePower;

            while (pokePower >= pokeDistance)
            {
                pokePower -= pokeDistance;
                pokeCounter++;
                if (pokePower == pokePowerCopy * 0.5 && numY > 0)
                {
                    pokePower /= numY;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);
        }
    }
}
