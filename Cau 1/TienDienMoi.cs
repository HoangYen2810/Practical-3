using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class TienDienMoi : TienDien
    {
        private int dinhMuc = 1240;

        public new void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            diaChi = Console.ReadLine();

            do
            {
                Console.Write("Nhập số công tơ tháng trước: ");
                soCongToThangTruoc = int.Parse(Console.ReadLine());
            } while (soCongToThangTruoc < 1240);

            do
            {
                Console.Write("Nhập số công tơ tháng sau: ");
                soCongToThangSau = int.Parse(Console.ReadLine());
            } while (soCongToThangSau < 1240);
        }

        public new void HienThi()
        {
            base.HienThi();
        }
        
        public new int TinhTienDien()
        {
            if (SoCongToDien < dinhMuc)
                base.TinhTienDien();
            return SoCongToDien * 1600;
        }
    }
}