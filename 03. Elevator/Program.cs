using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int fullCourse = (int)(numberOfPeople / capacity);
            if (numberOfPeople % capacity != 0)
            {
                ++fullCourse;
            }
            Console.WriteLine(fullCourse);

        }
    }
}
