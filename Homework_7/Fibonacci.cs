using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Fibonacci
    {
        public int СycleFibonacci(int n)
        {
            int i = 0;
            int f1 = 1;
            int f2 = 1;
            int fSum = 0;
            while (i < n - 1)
            {
                fSum = f1 + f2;
                f1 = f2;
                f2 = fSum;
                i++;
            }
            return f2;
        }

       
        public int RecursionFibonacci(int n)
        {
             if (n == 1 || n == 2)
             {
                 return n;
             }
             return RecursionFibonacci(n - 1) + RecursionFibonacci(n - 2);
        }
    }
}
