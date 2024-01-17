using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class ChuNhat
    {
        private double rong;
        private double dai;
        public ChuNhat(double rong, double dai)
        {
            this.rong = rong;
            this.dai = dai;
        }
        public double tinhChuVi()
        {
            return (dai + rong) * 2;
        }
        public double tinhDienTich()
        {
            return dai * rong;
        }
        public void Xuat()
        {
            Console.WriteLine("--------------------------------Thong tin hinh chu nhat------------------------------------");
            Console.WriteLine("Dai: {0}\t\t Rong: {1}\t\t Chu vi: {2}\t\t Dien tich: {3}", dai, rong, tinhChuVi(), tinhDienTich());
            Console.WriteLine("");
        }
    }
}
