using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator_biz_logic
{
    public class Calculator
    {
        public double Add(string first, string second)
        {
            try
            {
                var firstNumber = Convert.ToDouble(first);
                var secondNumber = Convert.ToDouble(second);
                return firstNumber + secondNumber;
            }
            catch (Exception)
            {
                MessageBox.Show("that was crazy");
                return 10;
            }
            
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
