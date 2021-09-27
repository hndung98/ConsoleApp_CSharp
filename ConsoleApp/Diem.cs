using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Diem
    {
        /// <summary>
        /// hoanh do
        /// </summary>
        private int x;

        /// <summary>
        /// tung do
        /// </summary>
        private int y;

        /// <summary>
        /// Khởi tạo không tham số
        /// constructor giá trị mặc định của (x,y) là (0,0)
        /// </summary>
        public Diem()
        {
            this.x = this.y = 0;
        }

        /// <summary>
        /// Khởi tạo có tham số
        /// constructor truyền giá trị mặc định của (x,y) là (x0,y0)
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        public Diem(int x0, int y0)
        {
            this.x = x0;
            this.y = y0;
        }

        /// <summary>
        /// Tinh khoang cach giua 2 diem
        /// </summary>
        /// <returns></returns>
        public double TinhKhoangCach(Diem data)
        {
            double a = Math.Pow(data.x - x, 2);
            double b = Math.Pow(data.y - y, 2);
            double result = Math.Sqrt(a + b);

            return result;
            //Có thể thay 4 dòng trên bằng 1 dòng sau
            //return Math.Sqrt(Math.Pow(data.x - x, 2),Math.Pow(data.y - y, 2))
        }
    }
}
