using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            decimal halfPowerN = (decimal)(powerN*0.50);
            int countPops = 0;
            while (powerN >= distanceM)
            {
                powerN -= distanceM;
                if (powerN == halfPowerN)
                {
                    if(powerN>=exhaustionFactorY && exhaustionFactorY != 0)
                    {
                        powerN /= exhaustionFactorY;
                    }
                }
                countPops++;
            }
            Console.WriteLine(powerN);
            Console.WriteLine(countPops);
        }
    }
}
