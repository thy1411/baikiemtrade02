using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main (string[] age)
        {
            Console.WriteLine("\t\t\tTINH CHU VI, DIEN TICH HINH CHU NHAT VA HINH VUONG");
            Console.WriteLine("");
            ChuNhat cn = new ChuNhat(400, 600);
            Vuong vu = new Vuong(400);
            cn.Xuat();
            vu.Xuat();
            Console.ReadLine();
        }
    }
}
