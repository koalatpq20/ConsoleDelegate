using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    public class Calculator2Sample
    {
        delegate void CalculatorDelegate(double number1, double number2);
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public void ExecuteOperator()
        {
            // Khởi tạo delegate bằng anonymous functions
            CalculatorDelegate delegateSum = (double a, double b) => Console.WriteLine("Cộng : " + (a + b));
            CalculatorDelegate delegateSubstract = (double a, double b) => Console.WriteLine("Trừ : " + (a - b));
            CalculatorDelegate delegateMultiply = (double a, double b) => Console.WriteLine("Nhân : " + (a * b));
            CalculatorDelegate delegateDivide = (double a, double b) => Console.WriteLine("Chia : " + (a / b));

            CalculatorDelegate delegateExecute = delegateSum + delegateSubstract + delegateMultiply + delegateDivide;
            delegateExecute(Number1, Number2); //gọi thực thi delegate
        }
    }
}
