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
        public HinhTron(double banKinh,ToaDo tam)
        {
            
            this.banKinh = banKinh;
            this.tam = tam;
        }
       
        
        public void xuat()
        {
            Console.WriteLine("Hinh Tron co Tam O({0},{1}) co ban kinh la {2}, co Chu Vi va Dien Tich lan luot la {3}, {4} ", +tam.X, +tam.Y, +banKinh, +tinhChuVi(), +tinhDienTich());
           
        }
    }
}
