using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            TienDien tienDien = new TienDien();
            tienDien.Nhap();
            TienDienMoi tienDienMoi = new TienDienMoi();
            tienDienMoi.Nhap();

            tienDien.HienThi();
            Console.WriteLine("Số công tơ điện đã dùng: " + (tienDien.SoCongToDien));
            Console.WriteLine("Số tiền điện phải trả: {0}\n", tienDien.TinhTienDien());
            tienDienMoi.HienThi();
            Console.WriteLine("Số công tơ điện đã dùng: " + (tienDienMoi.SoCongToDien));
            Console.WriteLine("Số tiền điện phải trả: " + tienDienMoi.TinhTienDien());
            
            Console.ReadKey();
        }
    }
}