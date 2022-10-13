using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    /// <summary>
    /// Sửa bài tập 1 - Delegate kiểu double
    /// </summary>
    public class NumberSample
    {
        /// <summary>
        /// Khai báo kiểu delegate - tính tổng các số thực
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns>Kiểu trả về số thực double</returns>
        public delegate double NumberDelegate(double number1, double number2, double number3);

        /// <summary>
        /// Thuộc tính truy xuất public, chỉ gán private
        /// Khai báo biến delegate - Dùng delegate như 1 property
        /// </summary>
        public NumberDelegate DelSum { get; set; }

        public NumberSample()
        {
            //Khởi tạo object delegate - gán cho phương thức Sum cùng kiểu trả về, cùng số lượng tham số parameter
            DelSum = Sum;

            // Gọi thực thi delegate lần đầu
            Console.WriteLine("NumberSample: " + DelSum(10, 20, 30));
        }

        private double Sum(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }
    }
}
