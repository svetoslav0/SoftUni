using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = double.Parse(Console.ReadLine());
            var people = int.Parse(Console.ReadLine());
            int courses = (int)(Math.Ceiling(capacity / people));
            Console.WriteLine(courses);
        }
    }
}
