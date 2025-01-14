﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class BasicMath
    {
        /// <summary>
        /// This is a function that adds two numbers together
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double AddNumbers(double num1, double num2)
        {
            // This adds two numbers
            return num1 + num2;
        }
        /// <summary>
        /// This function subtracts two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// This function multiples two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// This function divides two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
