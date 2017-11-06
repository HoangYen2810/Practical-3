using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class TienDien
    {
        protected string hoTen;
        protected string diaChi;
        protected int soCongToThangTruoc;
        protected int soCongToThangSau;

        public TienDien() { }

        public TienDien(string hoTen, string diaChi, int soCongToThangTruoc, 
                        int soCongToThangSau)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soCongToThangTruoc = soCongToThangTruoc;
            this.soCongToThangSau = soCongToThangSau;
        }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            diaChi = Console.ReadLine();

            do {
                Console.Write("Nhập số công tơ tháng trước: ");
                soCongToThangTruoc = int.Parse(Console.ReadLine());
            } while (soCongToThangTruoc < 100);

            do {
                Console.Write("Nhập số công tơ tháng sau: ");
                soCongToThangSau = int.Parse(Console.ReadLine());
            } while (soCongToThangSau < 100);
        }

        public void HienThi()
        {
            Console.WriteLine("Họ tên: " + hoTen);
            Console.WriteLine("Địa chỉ: " + diaChi);
            Console.WriteLine("Số công tơ tháng trước: " + soCongToThangTruoc);
            Console.WriteLine("Số công tơ tháng sau: " + soCongToThangSau);
        }

        public int SoCongToDien
        {
            get
            {
                if (soCongToThangSau - soCongToThangTruoc > 0)
                    return soCongToThangSau - soCongToThangTruoc;
                return 0;
            }
        }

        public int TinhTienDien()
        {
            return SoCongToDien * 1240;
        }
    }
}