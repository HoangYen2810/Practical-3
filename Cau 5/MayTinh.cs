using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau5
{
    class MayTinh : May
    {
        private int tocDo { get; set; }
        private int dungLuongRam { get; set; }
        private int dungluongHDD { get; set; }

        public new void Input()
        {
            base.Input();
            Console.Write("Nhập tốc độ: ");
            tocDo = int.Parse(Console.ReadLine());
            Console.Write("Nhập dung lượng Ram: ");
            dungLuongRam = int.Parse(Console.ReadLine());
            Console.Write("Nhập dung lượng HDD: ");
            dungluongHDD = int.Parse(Console.ReadLine());
        }

        public new void Output()
        {
            base.Output();
            Console.WriteLine("Tốc độ: {0} GHz", tocDo);
            Console.WriteLine("Dung lượng Ram: {0} GB", dungLuongRam);
            Console.WriteLine("Dung lượng HDD: {0} GB\n", dungluongHDD);
        }
    }
}