using System;
using System.Collections.Generic;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start application");

            var creator1 = new CircleCreator();
            var shape1 = creator1.CreateShape();
            shape1.ValueParams.Add(10);
            Console.WriteLine($"Area: {shape1.Area():.##}, Perimeter: {shape1.Perimeter():.##}");

            var creator2 = new RectangleCreator();
            var shape2 = creator2.CreateShape();
            shape2.ValueParams.Add(10);
            shape2.ValueParams.Add(20);
            Console.WriteLine($"Area: {shape2.Area():.##}, Perimeter: {shape2.Perimeter():.##}");

            Console.WriteLine("done");
        }
    }
}
