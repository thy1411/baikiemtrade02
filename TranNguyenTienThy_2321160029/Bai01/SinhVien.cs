using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Sinhvien
    {
        public string Hoten { get; set; }
        public double Diemtoan { get; set; }
        public double Diemvan { get; set; }
        public double Diemngoaingu { get; set; }
        public char Khoihoc { get; set; }
        public Sinhvien()
        {

        }
        public Sinhvien(string hoTen, double diemToan, double diemVan, double diemNgoaingu, char khoiHoc)
        {
            Hoten = hoTen;
            Diemtoan = diemToan;
            Diemvan = diemVan;
            Diemngoaingu = diemNgoaingu;
            Khoihoc = khoiHoc;
        }
        public double TinhDiemTrungBinh()
        {
            return (Diemtoan + Diemvan + Diemngoaingu) / 3;
        }
        public string TinhXepLoai()
        {
            double diemTrungBinh = TinhDiemTrungBinh();
            if (diemTrungBinh >= 5)
                return "Duoc len lop";
            else
                return "Luu ban";
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ho Ten: {Hoten}");
            Console.WriteLine($"Diem Trung Binh: {TinhDiemTrungBinh()}");
            Console.WriteLine($"Tinh Xep Loai: {TinhXepLoai()}");
        }
    }
}