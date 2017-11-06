using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau5
{
    class May
    {
        protected string nhanHieu;
        public string NhanHieu
        {
            get { return nhanHieu; }
            set
            {
                if (value != "")
                    nhanHieu = value;
                else
                    nhanHieu = "";
            }
        }

        public NhaSanXuat nhaSanXuat { get; set; }
        public int giaThanh { get; set; }

        public void Input()
        {
            Console.Write("Nhập nhãn hiệu: ");
            nhanHieu = Console.ReadLine();
            nhaSanXuat = new NhaSanXuat();
            nhaSanXuat.Input();
            Console.Write("Nhập giá thành: ");
            giaThanh = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("Nhãn hiệu: " + nhanHieu);
            nhaSanXuat.Output();
            Console.WriteLine("Giá thành: " + giaThanh);
        }
    }
}