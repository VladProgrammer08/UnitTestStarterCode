using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expectedNumber = num1 + num2;
            double actualNumber = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expectedNumber, actualNumber);

        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            double firstNumber = 10;
            double secondNumber = 100;

            double expectedNumber = firstNumber * secondNumber;
            double actualNumber = SimpleMath.Multiply(firstNumber, secondNumber);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            double numerator = 10;
            double denominator = 0;
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(numerator, denominator));

        }

        [TestMethod]
        public void Divide_TwoValidNumbers_ReturnsQuotient()
        {
            double firstNumber = 100;
            double secondNumber = 10;
            double expectedNumber = firstNumber / secondNumber;

            double actualNumber = SimpleMath.Divide(firstNumber, secondNumber);
            Assert.AreEqual(expectedNumber, actualNumber);

        }

        [TestMethod]
        public void Subtract_TwoValidNumbers_ReturnsSum()
        {
            double firstNumber = 10;
            double secondNumber = 9;
            
            double expectedNumber = firstNumber - secondNumber;
            double actualNumber = SimpleMath.Subtract(firstNumber, secondNumber);

            Assert.AreEqual(expectedNumber, actualNumber);
        }

    }
}