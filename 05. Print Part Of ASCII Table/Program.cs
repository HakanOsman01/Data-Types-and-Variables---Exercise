using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int starIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            for (int currentIndex = starIndex; currentIndex <= endIndex; currentIndex++)
            {
                Console.Write($"{(char)currentIndex} ");
            }
        }
    }
}
