using System;

namespace AditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15 + 5 = " + Calculator.Plus(15, 5));
            Console.WriteLine("15 - 5 = " + Calculator.Minus(15, 5));
            Console.WriteLine("15 * 5 = " + Calculator.Multiplication(15, 5));
            Console.WriteLine("15 / 5 = " + Calculator.Division(15, 5));
        }
    }
}
