using System;
using System.Runtime.InteropServices;

namespace GeometryExample
{
    public class Cylinder
    {
        public static void Process(double radius, double height)
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine($"Radius: {radius}, Height: {height}");
            var base1 = radius * radius * 3.14;
            var lateral = 2 * 3.14 * radius * height;
            var totalArea = 2 * 3.14 * radius * (height + radius);
            var volume = 3.14 * radius * radius * height;
            Console.WriteLine($"Base: {base1} | Lateral: {lateral} | Total: {totalArea } | Volume: {volume}");
        }

        public void Result()
        {
            Console.WriteLine("Enter dimension of the sylinder");
            Console.WriteLine("Radius:");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            var height = double.Parse(Console.ReadLine());
            Process(radius, height);
        }
        
    }
}