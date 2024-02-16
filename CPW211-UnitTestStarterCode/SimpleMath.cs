using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        /// <summary>
        /// Adds two double numbers and returns the sum.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>Returns sum of both numbers.</returns>
        public static double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        /// <summary>
        /// Subtracts one double number from another and returns the result.
        /// </summary>
        /// <param name="a">The number to subtract from.</param>
        /// <param name="b">The number to subtract.</param>
        /// <returns>The difference of a and b.</returns>
        public static double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        /// <summary>
        /// Multiplies two double numbers and returns the result.
        /// </summary>
        /// <param name="a">The first number to multiply.</param>
        /// <param name="b">The second number to multiply.</param>
        /// <returns>The product of a and b.</returns>
        public static double Multiply(double a, double b)
        {
            double product = a * b;
            return product;
        }

        /// <summary>
        /// Divides one double number by another and returns the result.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <returns>The quotient of a and b.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
            else {
                double quotien = a / b;
                return quotien;
            }
            
        }
    }
}
