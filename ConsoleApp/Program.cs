using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var A = new Diem(1,1);
            var B = new Diem(2,1);

            Console.WriteLine(A.TinhKhoangCach(B));
        }
    }
}
