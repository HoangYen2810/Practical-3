using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng máy tính: n =");
            int n = int.Parse(Console.ReadLine());

            List<MayTinh> computer = new List<MayTinh>(new MayTinh[n]);
            for (int i = 0; i < computer.Count; i++)
            {
                computer[i] = new MayTinh();
                computer[i].Input();
            }

            Console.WriteLine("Thông tin của các máy tính của các nhà sản xuất Intel");
            for (int i = 0; i < computer.Count; i++)
                if (String.Compare(computer[i].nhaSanXuat.ten, "Intel", true) == 0)
                    computer[i].Output();

            int[] compare = new int[computer.Count];
            for (int i = 0; i < computer.Count; i++)
            {
                compare[i] = computer[i].giaThanh;
            }

            for (int i = 0; i < computer.Count - 1; i++)
                for (int j = i + 1; j < computer.Count; j++)
                    if (compare[i] < compare[j])
                    {
                        int t = compare[i];
                        compare[i] = compare[j];
                        compare[j] = t;
                    }

            for (int i = 0; i < computer.Count; i++)
                computer[i].giaThanh = compare[i];

            Console.WriteLine("Danh sách các máy tính theo chiều giảm dần của giá thành");
            foreach (MayTinh cp in computer)
                cp.Output();


            double s = computer[0].giaThanh;
            for (int i = 1; i < computer.Count; i++)
                s += computer[i].giaThanh;
            Console.Write("Giá thành trung bình của mỗi chiếc máy tính: " + Math.Round(s / n, 2));

            Console.ReadKey();
        }
    }
}