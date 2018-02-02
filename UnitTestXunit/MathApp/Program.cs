using System;
using MathLib;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using MathLib in a console app");
            System.Console.WriteLine($"Add: {SimpleMath.Add(5, 3)}");
            System.Console.WriteLine($"Subtract: {SimpleMath.Subtract(5, 3)}");
            System.Console.WriteLine($"Multiply: {SimpleMath.Multiply(5, 3)}");
            System.Console.WriteLine($"Divide: {SimpleMath.Divide(5, 3)}");
            System.Console.WriteLine($"Remainder: {SimpleMath.Remainder(5, 3)}");
        }
    }
}
