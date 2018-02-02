using System;
using MathLib;
using Xunit;

namespace MathLib.Tests {
    public class SimpleMathTest {
        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (-10, 2, -8)]
        [InlineData (100, 72, 172)]
        public void AddTest (int a, int b, int expectedRes) {
            // Arrange & Act
            var res = SimpleMath.Add (a, b);
            Assert.True (expectedRes == res);
        }

        [Theory]
        [InlineData (1, 2, -1)]
        [InlineData (-25, -10, -15)]
        [InlineData (9, 5, 4)]
        public void SubtractTest (int a, int b, int expectedRes) {
            var res = SimpleMath.Subtract (a, b);
            Assert.True (expectedRes == res);
        }

        [Theory]
        [InlineData (1, 2, 2)]
        [InlineData (-25, -10, 250)]
        [InlineData (0, 5, 0)]
        public void MultiplyTest (int a, int b, int expectedRes) {
            var res = SimpleMath.Multiply (a, b);
            Assert.Equal (expectedRes, res);
        }

        [Theory]
        [InlineData (100, 2, 50)]
        [InlineData (-25, 1, -25)]
        [InlineData (0, 5, 0)]
        public void DivideTest (int a, int b, int expectedRes) {
            var res = SimpleMath.Divide (a, b);
            Assert.Equal (expectedRes, res);
        }

        [Theory]
        [InlineData (100, 2, 0)]
        [InlineData (-25, 4, -1)]
        [InlineData (11, 3, 2)]
        public void RemainderTest (int a, int b, int expectedRes) {
            var res = SimpleMath.Remainder (a, b);
            Assert.Equal (expectedRes, res);
        }

        [Fact]
        public void DivideTest_DivideByZeroException () {
            // Arrange & Act
            var ex = Assert.Throws<DivideByZeroException>(
                () => SimpleMath.Divide(5, 0));
            // Assert
            Assert.True(ex.Message.Contains("Attempted to divide by zero."));
        }
    }
}