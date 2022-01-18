using Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest1
{
    public class UnitTests
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

    public class AdvMathTest
    {
        [Fact]
        public void TestCalcArea()
        {
            var math = new AdvMath();
            var result = math.CalcArea(2, 3);
            Assert.True(result == 6);
 
        }
        [Fact]
        public void TestCalcAvg()
        {
            var math = new AdvMath();
            List<double> numList = new List<double>();
            numList.Add(5);
            numList.Add(5);
            numList.Add(5);
            numList.Add(2);
            numList.Add(3);
            numList.Add(10);
            numList.Add(10);
            numList.Add(2);
            numList.Add(3);
            numList.Add(5);
            var result = math.CalcAvg(numList);
            Assert.True(result == 5);

        }
        [Fact]
        public void TestSquareNumber()
        {
            var math = new AdvMath();
            var result = math.SquareNumber(3);
            Assert.True(result == 9);

        }
        [Fact]
        public void TestPythagoreanTheorem()
        {
            var math = new AdvMath();
            var result = math.PythagoreanTheorem(3, 4);
            Assert.True(result == 5);

        }
    }
}
