using Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest1
{
    public class BasicMathTest
    {
        [Fact]
        public void TestAddNumbers()
        {
            var math = new BasicMath();
            var result = math.AddNumbers(5, 5);
            Assert.True(result == 10);
        }

        [Fact]
        public void TestSubtactNumbers()
        {
            var math = new BasicMath();
            var result = math.SubtractNumbers(10, 5);
            Assert.True(result == 5);
        }

        [Fact]
        public void TestMultiplyNumbers()
        {
            var math = new BasicMath();
            var result = math.MultiplyNumbers(2, 5);
            Assert.True(result == 10);
        }

        [Fact]
        public void TestDivideNumbers()
        {
            var math = new BasicMath();
            var result = math.DivideNumbers(10, 2);
            Assert.True(result == 5);
        }
    }
}
