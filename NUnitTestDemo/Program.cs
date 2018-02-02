using System;
using NUnit.Framework;

namespace UnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // var result = AddInts(3, 4);
            // Console.WriteLine("Result: " + result);
            // Console.Read();
        }

        public static int Add (int a, int b) => a + b; 
        public static int Divide (int a, int b) => a / b;       
    }
    [TestFixture]
    class MathTest 
    {
        [TestCase(2, 4, 6)]
        [TestCase(1, 0, 1)]
        [TestCase(10, -2, 8)]
        public void Should_Return_Sum_Given_Ints(int x, int y, int expectedRes)
        {
            //
            var actualResult = Program.Add(x, y);

            Assert.AreEqual(expectedRes, actualResult);
            // Assert.True(expectedRes == actualResult);          
        }
        [TestCase(2, 4, 0)]
        [TestCase(6, 2, 3)]
        public void Should_Return_Divide_Given_Ints(int x, int y, int expectedRes)
        {
            //
            var actualResult = Program.Divide(x, y);

            Assert.AreEqual(expectedRes, actualResult);
            // Assert.Throws();
            // Assert.True(expectedRes == actualResult);     
        }
        [Test]
        public void Should_Return_Divide_By_Zero_Exception ()
        {
            // Arrange & Act
            var ex = Assert.Throws<DivideByZeroException>(
                () => Program.Divide(5, 0));
            // Assert
            Assert.IsTrue(ex.Message.Contains("Attempted to divide by zero."));
        }
    }
}
