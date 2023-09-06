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
        private double bankinh;

        public double Bankinh
        {
            get { return bankinh; }
            set { bankinh = value; }
        }
        public HinhTron()
        {
            Tam = new ToaDo();
            bankinh = 0;
            Tam.name = "Hinh Tron";
        }
        public HinhTron(ToaDo tam, double bkinh)
        {
           this.Tam = tam;
            this.bankinh = bkinh;
            this.Tam.name = "Hinh Tron";
        }
        public double tinhChuVi()
        {
            return 2 * 3.14 * bankinh;
           
        }
        public double tinhDienTinh()
        {
            return 3.14 * bankinh * bankinh;
        }


        public void ToString()
        {
           
            Console.WriteLine("\n CHu Vi :  " + tinhChuVi());
            Console.WriteLine("\n Dien Tich : " + tinhDienTinh());
           
        }


    }
}
