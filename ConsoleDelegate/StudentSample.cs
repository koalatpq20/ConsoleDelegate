using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDelegate
{
    /// <summary>
    /// Sửa bài tập câu 2 - Delegate kiểu void
    /// </summary>
    public class StudentSample
    {
        /// <summary>
        /// Khai báo kiếu delegate void
        /// </summary>
        public delegate void StudentDelegate(StudentSample student);

        public StudentDelegate DelDisplay { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Nhập thông tin sinh vien và 
        /// </summary>
        public void DisplayInformation()
        {
            //Nhập thông tin
            Console.WriteLine("Nhập thông tin sinh viên ...");
            Name = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());

            //Gọi thực thi delegate xuất thông tin màn hình.
            DelDisplay(this);
        }
    }
}
