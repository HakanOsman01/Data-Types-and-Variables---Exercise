using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberCount = sbyte.Parse(Console.ReadLine());
            int capacity = 255;
            int total = 0;
            for(int currentQuantityWater = 1; currentQuantityWater 
                <= numberCount; currentQuantityWater++)
            {
                short litters = short.Parse(Console.ReadLine());
                if (litters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                capacity -= litters;
                total += litters;
            }
            Console.WriteLine($"{total}");

        }
    }
}
