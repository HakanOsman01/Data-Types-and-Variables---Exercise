using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            long sumCharacters = 0;
            for(int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sumCharacters += (int)letter;
            }
            Console.WriteLine($"The sum equals: {sumCharacters}");
        }
    }
}
