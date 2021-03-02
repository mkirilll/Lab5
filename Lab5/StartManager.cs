using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab5
{
    public static class StartManager
    {
        public static void Start()
        {
            Fibonacci fibonacci = new Fibonacci();
            HanoiTowers hanoiTowers = new HanoiTowers();

            Console.Write("Input quantity of numbers: ");
            fibonacci.ElementsQuantity = Convert.ToInt32(Console.ReadLine());

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            fibonacci.IterativeFibonacci(fibonacci.ElementsQuantity);
            stopwatch.Stop();
            Console.WriteLine($"\nTime efficiency: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            fibonacci.RecursiveFibonacci(fibonacci.ElementsQuantity);
            stopwatch.Stop();
            Console.WriteLine($"\nTime efficiency: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            fibonacci.ClosedFormFibonacci(fibonacci.ElementsQuantity);
            stopwatch.Stop();
            Console.WriteLine($"\n\nTime efficiency: {stopwatch.ElapsedMilliseconds} ms");

            Console.Write("\n\nInput quantity of rings: ");
            hanoiTowers.RingsQuantity = Convert.ToInt32(Console.ReadLine());

            stopwatch.Restart();
            hanoiTowers.SolveHanoiTowers(hanoiTowers.RingsQuantity);
            stopwatch.Stop();
            Console.WriteLine($"\nTime efficiency: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
