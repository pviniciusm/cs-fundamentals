/**
 * Program for Fibonacci calculation
 */

using System;

namespace Fibonacci
{
    public class Program
    {
        public static void Main()
        {
            int position = 7;

            IFibonacci implementation;

            //implementation = new RecursiveFibonacci();
            //implementation = new MemoizedFibonacci();
            implementation = new BottomUpFibonacci();
            int fibonacci = implementation.Calculate(position);
            
            Console.WriteLine(String.Format("Fibonacci index {0}:", position));
            Console.WriteLine(fibonacci.ToString());

            return;
        }
    }
}
