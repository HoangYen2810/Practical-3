using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    class MayInLaser : MayIn
    {
        private int doPhanGiai { get; set; }
        private int tocDoIn { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập trọng lượng máy: ");
            trongLuongMay = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm sản xuất: ");
            namSanXuat = int.Parse(Console.ReadLine());
            Console.Write("Nhập hãng sản xuất: ");
            hangSanXuat = Console.ReadLine();
            Console.Write("Nhập độ phân giải: ");
            doPhanGiai = int.Parse(Console.ReadLine());
            Console.Write("Nhập tốc độ in: ");
            tocDoIn = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Trọng lượng máy: {0}g", trongLuongMay);
            Console.WriteLine("Năm sản xuất: " + namSanXuat);
            Console.WriteLine("Hãng sản xuất: " + hangSanXuat);
            Console.WriteLine("Độ phân giải: " + doPhanGiai);
            Console.WriteLine("Tốc độ in: {0} trang/phút", tocDoIn);
        }
    }
}