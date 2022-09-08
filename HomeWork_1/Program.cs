using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            int y2 = int.Parse(Console.ReadLine());

            int width = Math.Abs(Math.Min(x1, x2) - Math.Max(x1, x2));
            int height = Math.Abs(Math.Min(y1, y2) - Math.Max(y1, y2));

            Console.WriteLine($"S = {width * height}");
            Console.WriteLine($"p = {2 * (width + height)}");
        }
    }
}

