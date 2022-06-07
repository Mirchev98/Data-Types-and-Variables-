using System;

namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            for (int firstLetter = 0; firstLetter < iterations; firstLetter++)
            {
                char firstChar = (char)('a' + firstLetter);
                
                for (int secondLetter = 0; secondLetter < iterations; secondLetter++)
                {
                    char secondChar = (char)('a' + secondLetter);
                    
                    
                    for (int thirdLetter = 0; thirdLetter < iterations; thirdLetter++)
                    {
                        char thirdChar = (char)('a' + thirdLetter);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
