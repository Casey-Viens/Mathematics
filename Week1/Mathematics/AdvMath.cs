using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AdvMath
    {
        /// <summary>
        /// Function to Calculate an area given height and width
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public double CalcArea(double height, double width)
        {
            return height * width;
        }
        /// <summary>
        /// Function to calculate an average from a list of doubles
        /// </summary>
        /// <param name="numList"></param>
        /// <returns></returns>
        public double CalcAvg(List<double> numList)
        {
            double total = 0;
            foreach(double num in numList)
            {
                total += num;
            }
            return total / numList.Count;
        }
        /// <summary>
        /// Function to find the square of a given number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public double SquareNumber(double num)
        {
            return Math.Pow(num,2);
        }
        /// <summary>
        /// Function to use the pythagorean theorem given a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double PythagoreanTheorem(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
