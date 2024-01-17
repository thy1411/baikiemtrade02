using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main()
        {
            Sinhvien sv1 = new Sinhvien();
            
            Console.WriteLine("Nhap thong tin sinh vien 1:");
            
            Console.Write("Ho ten:");
            sv1.Hoten = Console.ReadLine();
            
            Console.Write("Diem Toan: ");
            sv1.Diemtoan = double.Parse(Console.ReadLine());
            
            Console.Write("Diem Van: ");
            sv1.Diemvan = double.Parse(Console.ReadLine());
            
            Console.Write("Diem Ngoai Ngu: ");
            sv1.Diemngoaingu = double.Parse(Console.ReadLine());
            
            Console.Write("Khoi hoc (A,B,C): ");
            sv1.Khoihoc = char.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Clear();

            Console.WriteLine("THONG TIN DIEM SINH VIEN");
            Console.WriteLine("__________________________");
            Console.WriteLine("");

            sv1.InThongTin();
            Console.WriteLine("");

            Sinhvien sv2 = new Sinhvien("Tran Nguyen Tien Thy", 10.0, 10.0, 10.0, 'A');
            sv2.InThongTin();
            Console.WriteLine("__________________________");
            Console.ReadLine();
        }
    }

}
