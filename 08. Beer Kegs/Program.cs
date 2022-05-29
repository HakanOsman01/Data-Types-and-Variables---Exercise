using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfKegs = byte.Parse(Console.ReadLine());
            string mostVolumeModel = string.Empty;
            double biggestVolume = double.MinValue;
            for (int currentKeg = 1; currentKeg <= numberOfKegs; currentKeg++) 
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * (Math.Pow(radius, 2)) * height;
                if (biggestVolume < volume)
                {
                    biggestVolume = volume;
                    mostVolumeModel = model;
                }
            }
            Console.WriteLine(mostVolumeModel);
        }
    }
}
