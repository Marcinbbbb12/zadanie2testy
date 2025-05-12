using System;
using NUnit.Framework;

namespace zadanie2testy
{
    public class AbsoluteValueCalculator
    {
        public int GetAbsoluteValue(int number)
        {
            return Math.Abs(number);
        }
    }

  
    public class AbsoluteValueCalculatorTest
    {
        private AbsoluteValueCalculator _calculator;

     
        public void Setup()
        {
            _calculator = new AbsoluteValueCalculator();
        }

    
        public void GetAbsoluteValue_PositiveNumber_ReturnsSameNumber()
        {
            Assert.AreEqual(5, _calculator.GetAbsoluteValue(5));
        }

      
        public void GetAbsoluteValue_NegativeNumber_ReturnsPositiveNumber()
        {
            Assert.AreEqual(5, _calculator.GetAbsoluteValue(-5));
        }

       
        public void GetAbsoluteValue_Zero_ReturnsZero()
        {
            Assert.AreEqual(0, _calculator.GetAbsoluteValue(0));
        }
    }
}