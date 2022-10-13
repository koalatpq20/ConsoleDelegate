using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    /// <summary>
    /// Sửa bài 3
    /// </summary>
    public class CalculatorSample
    {
        delegate void CalculatorDelegate(double number1, double number2);
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public void ExecuteOperator()
        {
            CalculatorDelegate delegateSum = Sum;
            CalculatorDelegate delegateSubstract = Subtract;
            CalculatorDelegate delegateMultiply = Multiply;
            CalculatorDelegate delegateDivide = Divide;

            CalculatorDelegate delegateExecute = delegateSum + delegateSubstract + delegateMultiply + delegateDivide;
            delegateExecute(Number1, Number2);
        }

        /// <summary>
        /// Phép cộng
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        private void Sum(double number1, double number2)
        {
            Console.WriteLine("Cộng : " + (number1 + number2));
        }
        /// <summary>
        /// Phép trừ
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        private void Subtract(double number1, double number2)
        {
            Console.WriteLine("Trừ : " + (number1 - number2));
        }

        /// <summary>
        /// Phép nhân
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        private void Multiply(double number1, double number2)
        {
            Console.WriteLine("Nhân: " + (number1 * number2));
        }

        /// <summary>
        /// Phép chia
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        private void Divide(double number1, double number2)
        {
            Console.WriteLine("Chia : " + (number1 / number2));
        }
    }
}
