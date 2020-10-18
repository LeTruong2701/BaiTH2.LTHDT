using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH2.LTHDT
{
    class Phanso
    {
        private int tu, mau;
        public Phanso()
        {
            tu = mau = 0;
        }
        public Phanso(int x, int y)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public void nhap()
        {
            Console.WriteLine("nhap tu"); tu = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap mau"); mau = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            if (mau == 1)
            {
                Console.WriteLine("{0}", tu);
            }
            else
            {
                Console.WriteLine("{0}/{1}",tu,mau);
            }
        }
        public int Uscln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public Phanso rutgon()
        {
            int uc = Uscln(this.tu, this.mau);
            this.tu = this.tu / uc;
            this.mau = this.mau / uc;
            return this;
        }
        public static Phanso operator +(Phanso t1, Phanso t2)
        {
            Phanso t = new Phanso();
            t.tu = t1.tu * t2.mau + t1.mau * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static Phanso operator -(Phanso t1, Phanso t2)
        {
            Phanso t = new Phanso();
            t.tu = t1.tu * t2.mau - t1.mau * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static Phanso operator /(Phanso t1, Phanso t2)
        {
            Phanso t = new Phanso();
            t.tu = t1.tu * t2.mau;
            t.mau = t1.mau * t2.tu;
            return t;
        }
        public static Phanso operator *(Phanso t1, Phanso t2)
        {
            Phanso t = new Phanso();
            t.tu = t1.tu * t2.tu;
            t.mau = t1.mau * t2.mau;
            return t;
        }
        public static bool operator >(Phanso t1, Phanso t2)
        {
            return t1.tu * t2.mau > t2.tu * t1.mau;
        }
        public static bool operator <(Phanso t1, Phanso t2)
        {
            return t1.tu * t2.mau < t2.tu * t1.mau;
        }
    }
}
