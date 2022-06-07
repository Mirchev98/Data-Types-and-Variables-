using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingChar = int.Parse(Console.ReadLine());
            int endingChar = int.Parse(Console.ReadLine());

            for (int currentChar = startingChar; currentChar <= endingChar; currentChar++)
            {
                Console.Write((char)currentChar + " ");
            }
        }
    }
}
