using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            int days = 0;
            long amountSpice = 0;
            while (startingYield>=100)
            {
                amountSpice +=startingYield - 26;
                startingYield -= 10;
                days++;
            }
            Console.WriteLine(days);
            if (amountSpice >=26)
            {
                Console.WriteLine(amountSpice - 26);
            }
            else
            {
                Console.WriteLine(amountSpice);
            }
            
        }
    }
}
