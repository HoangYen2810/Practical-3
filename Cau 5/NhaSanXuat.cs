using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau5
{
    class NhaSanXuat
    {
        public string ten { get; set; }
        public string diaChi { get; set; }

        public void Input()
        {
            Console.Write("Nhập tên nhà sản sản xuất: ");
            ten = Console.ReadLine();
            Console.Write("Nhập địa chỉ nhà sản sản xuất: ");
            diaChi = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("Tên nhà sản xuất: " + ten);
            Console.WriteLine("Địa chỉ nhà sản xuất: " + diaChi);
        }
    }
}