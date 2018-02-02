using System;
using Xunit;

namespace UnitTestDemoXunit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class SimpleMath
    {
        static public int Add(int a, int b) =>  a + b; // expression-bodied function in C# 6.0
        static public int Subtract(int a, int b) => a - b; 
        static public int Multiply(int a, int b) => a * b;
        static public int Divide(int a, int b) => a / b;
        static public int Remainder(int a, int b) => a % b;
    }
    public class SimpleMathTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-10, 2, -8)]
        [InlineData(100, 72, 172)]        
        public void AddTest(int a, int b, int expectedRes)
        {
            var res = SimpleMath.Add(a, b);
            Assert.True(expectedRes == res);    
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(-25, -10, -15)]
        [InlineData(9, 5, 4)]
        public void SubtractTest(int a, int b, int expectedRes)
        {
            var res = SimpleMath.Subtract(a, b);
            Assert.True(expectedRes == res);    
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(-25, -10, 250)]
        [InlineData(0, 5, 0)]
        public void MultiplyTest(int a, int b, int expectedRes)
        {
            var res = SimpleMath.Multiply(a, b);
            Assert.Equal(expectedRes, res);    
        }
        [Theory]
        [InlineData(100, 2, 50)]
        [InlineData(-25, 1, -25)]
        [InlineData(0, 5, 0)]
        public void DivideTest(int a, int b, int expectedRes)
        {
            var res = SimpleMath.Divide(a, b);
            Assert.Equal( expectedRes, res);    
        }
        [Theory]
        [InlineData(100, 2, 0)]
        [InlineData(-25, 4, -1)]
        [InlineData(11, 3, 2)]
        public void RemainderTest(int a, int b, int expectedRes)
        {
            var res = SimpleMath.Remainder(a, b);
            Assert.Equal( expectedRes, res);    
        }
    }
}
