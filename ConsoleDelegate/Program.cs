using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //Câu 1
            NumberSample numberSample = new NumberSample();

            //Thay đổi hàm xử lý của delegate
            numberSample.DelSum = SumNumbers;
            numberSample.DelSum(50, 60, 70);

            //Cau 2
            StudentSample studentSample = new StudentSample();
            studentSample.DelDisplay = PrintStudent; //chèn code xử lý xuất thông tin vào class StudentSample
            studentSample.DisplayInformation();

            //Câu3
            CalculatorSample calculator = new CalculatorSample() { Number1 = 100, Number2 = 30};
            calculator.ExecuteOperator(); // thực thi nhiều delegate cùng 1 lượt

            //Câu4
            Calculator2Sample calculator2 = new Calculator2Sample() { Number1 = 200, Number2 = 50 };
            calculator2.ExecuteOperator(); // thực thi nhiều delegate cùng 1 lượt

            Console.ReadLine();
        }

        private static double SumNumbers(double a, double b, double c)
        {
            return a + b + c;
        }

        private static void PrintStudent(StudentSample student)
        {
            Console.WriteLine($"Sinh viên : tên {student.Name} - tuổi {student.Age}");
        }
    }
}
