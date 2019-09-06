using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start application");

            var n = 616;

            var hightBorder = (int)Math.Sqrt(n);
            var arrayEratosthenes = new bool[hightBorder + 1];
            arrayEratosthenes[1] = true;

            for (var k = 2; k * k <= hightBorder; k++)
                if (!arrayEratosthenes[k])
                    if (k * k <= hightBorder) for (var l = k * k; l <= hightBorder; l += k) arrayEratosthenes[l] = true;

            for (var k = 1; k <= hightBorder; k++)
                if (!arrayEratosthenes[k] && n%k==0)
                    Console.WriteLine($"number {k} is prime divisible");

            Console.WriteLine("done");
        }
    }
}
