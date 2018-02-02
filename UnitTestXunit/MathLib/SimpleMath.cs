using System;

namespace MathLib
{
    public class SimpleMath
    {
        static public int Add(int a, int b) =>  a + b; // expression-bodied function in C# 6.0
        static public double Add(double a, double b) =>  a + b;
        static public int Subtract(int a, int b) => a - b;
        static public int Multiply(int a, int b) => a * b;
        static public int Divide(int a, int b) => a / b;
        static public int Remainder(int a, int b) => a % b;
    }
}
