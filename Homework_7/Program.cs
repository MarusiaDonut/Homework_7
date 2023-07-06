using System;
using System.Diagnostics;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fib = 0;
            int fib2 = 0;
            Stopwatch StopWatch = new();

            Fibonacci fibonacci = new Fibonacci();

            StopWatch.Start();
            fib = fibonacci.СycleFibonacci(5);
            StopWatch.Stop();
            Console.WriteLine("Значение n-го члена последовательности Фибоначчи = {0}. Время нахождения с использованием цикла = {1}", fib, StopWatch.Elapsed.Nanoseconds);
            StopWatch.Reset();

            StopWatch.Start();
            fib2 = fibonacci.RecursionFibonacci(5);
            StopWatch.Stop();
            Console.WriteLine("Значение n-го члена последовательности Фибоначчи = {0}. Время нахождения с использованием рекурсии = {1}", fib2, StopWatch.Elapsed.Nanoseconds);
            StopWatch.Reset();
            Console.WriteLine("\n");

            StopWatch.Start();
            fib = fibonacci.СycleFibonacci(10);
            StopWatch.Stop();
            Console.WriteLine("Значение n-го члена последовательности Фибоначчи = {0}. Время нахождения с использованием цикла = {1}", fib, StopWatch.Elapsed.Nanoseconds);
            StopWatch.Reset();

            StopWatch.Start();
            fib2 = fibonacci.RecursionFibonacci(10);
            StopWatch.Stop();
            Console.WriteLine("Значение n-го члена последовательности Фибоначчи = {0}. Время нахождения с использованием рекурсии = {1}", fib2, StopWatch.Elapsed.Nanoseconds);
            StopWatch.Reset();
            Console.WriteLine("\n");

            StopWatch.Start();
            fib = fibonacci.СycleFibonacci(20);
            StopWatch.Stop();
            Console.WriteLine("Значение n-го члена последовательности Фибоначчи = {0}. Время нахождения с использованием цикла = {1}", fib, StopWatch.Elapsed.Nanoseconds);
            StopWatch.Reset();

            StopWatch.Start();
            fib2 = fibonacci.RecursionFibonacci(20);
            StopWatch.Stop();
            Console.WriteLine("Значение n-го члена последовательности Фибоначчи = {0}. Время нахождения с использованием рекурсии = {1}", fib2, StopWatch.Elapsed.Nanoseconds);
            StopWatch.Reset();
        }
    }
}