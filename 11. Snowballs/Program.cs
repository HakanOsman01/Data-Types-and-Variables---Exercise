using System;
using System.Numerics;
namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	On the first line, you will get the snowballSnow – an integer.
            //•	On the second line, you will get the snowballTime – an integer.
            //•	On the third line, you will get the snowballQuality – an integer.
            int countSnowballs = int.Parse(Console.ReadLine());
            BigInteger bestSnowBall = BigInteger.Zero;
            int bestSnowBallSnow = 0;
            int bestSnowBallTime = 0;
            int bestSnowBallQuality = 0;
            for(int currentSnowBall = 1; currentSnowBall <= countSnowballs; currentSnowBall++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());
                BigInteger currentBestSnow = BigInteger.Pow((snowBallSnow / snowBallTime),
                    snowBallQuality);
                if (bestSnowBall <= currentBestSnow)
                {
                     bestSnowBall = currentBestSnow;
                     bestSnowBallSnow = snowBallSnow;
                     bestSnowBallTime = snowBallTime;
                     bestSnowBallQuality = snowBallQuality;
                }
                
            }
            Console.WriteLine($"{bestSnowBallSnow} : {bestSnowBallTime} = {bestSnowBall} " +
                    $"({bestSnowBallQuality})");
        }
    }
}
