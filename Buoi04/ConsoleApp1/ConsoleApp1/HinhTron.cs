using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HinhTron
    {
        private ToaDo tam;
        public ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }

        private double BanKinh;

        public double bankinh
        {
            get { return BanKinh; }
            set { BanKinh = value; }
        }


        public HinhTron()
        {
            Tam = new ToaDo();
            bankinh = 0;
            Tam.name = "Hinh Tron";
        }



        public HinhTron(ToaDo tam, double BanKinh)
        {
            Tam = tam;
            bankinh = BanKinh;
            tam.name = "Hinh Tron";

        }

        public void tinhChuVi()
        {
            var chuvi = 2 * 3.14 * bankinh;
            Console.WriteLine("Chu Vi" + chuvi);
        }
        public void tinhDienTinh()
        {
            var tinhbankinh = 3.14 * bankinh * bankinh;
            Console.WriteLine("Dien Tich hinh tron la: " + tinhbankinh);

        }


    }
}
