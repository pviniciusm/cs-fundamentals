/**
 * Program that calculates if a list of brackets string is balanced.
 */

using System;

namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balanced Brackets Problem");

            Brackets brackets = new Brackets();
            brackets.Calculate(new List<string>()
            {
                "{[()]}",
                "{[(])}",
                "{{[[(())]]}}"
            });
        }
    }
}