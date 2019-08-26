using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_calculator
{
    public class Calculator
    {
        public double Add(string first, string second)
        {
            var firstNumber = Convert.ToDouble(first);
            var secondNumber = Convert.ToDouble(second);
            return firstNumber + secondNumber;
        }

        public double Subtract(string first, string second)
        {
            var firstNumber = Convert.ToDouble(first);
            var secondNumber = Convert.ToDouble(second);
            return firstNumber - secondNumber;

        }

        public double Multiply(string first, string second)
        {
            var firstNumber = Convert.ToDouble(first);
            var secondNumber = Convert.ToDouble(second);
            return firstNumber * secondNumber;

        }

        public double Divide(string first, string second)
        {
            var firstNumber = Convert.ToDouble(first);
            var secondNumber = Convert.ToDouble(second);
            return firstNumber / secondNumber;
        }
    }
}
