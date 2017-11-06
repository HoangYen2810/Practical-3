using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Số lượng máy in kim: n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Số lượng máy in laser: m = ");
            int m = int.Parse(Console.ReadLine());

            MayInKim[] kim = new MayInKim[n];
            Console.WriteLine("Nhập thông tin từng máy in kim");
            for (int i = 0; i < n; i++)
            {
                kim[i] = new MayInKim();
                kim[i].Nhap();
            }

            MayInLaser[] laser = new MayInLaser[m];
            Console.WriteLine("Nhập thông tin từng máy in laser:");
            for (int i = 0; i < m; i++)
            {
                laser[i] = new MayInLaser();
                laser[i].Nhap();
            }

            Console.Write("Thông tin máy in kim");
            foreach (MayInKim mik in kim)
                mik.Xuat();

            Console.Write("Thông tin máy in laser");
            foreach (MayInLaser mil in laser)
                mil.Xuat();

            Console.ReadKey();
        }
    }
}