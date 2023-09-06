using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
{
    class HinhTron
    {
        private double banKinh;
        private ToaDo tam;

        internal ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }

        public double tinhChuVi()
        {
            return 2 * 3.14 * banKinh;
        }
        public double tinhDienTich()
        {
            return 3.14 * banKinh * banKinh;
        }
        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
            this.tam = Tam;
        }
        public HinhTron()
        {}
        public void xuat()
        {
            Console.WriteLine("Hinh Tron co Tam {0}({1},{2}, co ban kinh la {3}, chu vi va dien tich lan luot la {4}, {5}) ", tam.Ten, +tam.X, +tam.Y, +banKinh, +tinhChuVi(), +tinhDienTich());
           
        }
    }
}
