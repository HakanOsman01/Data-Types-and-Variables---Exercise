using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sumDigith = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sumDigith += number[i]-'0';
                
                
            }
            Console.WriteLine(sumDigith);
        }
    }
}
