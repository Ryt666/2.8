using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8
{
    class Fuzzy
    {
        private double a;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        private double a_l;

        public double A_l
        {
            get
            {
                return a_l;
            }
            set
            {
                a_l = value;
            }
        }

        private double a_r;

        public double A_r
        {
            get
            {
                return a_r;
            }
            set
            {
                a_r = value;
            }
        }
        public Fuzzy(double a, double a_l, double a_r)
        {
            this.a = a;
            this.a_l = a_l;
            this.a_r = a_r;
        }
        public void print()
        {
            Console.WriteLine((a - a_l)+ " " + a + " " + (a + a_r));
        }
        public void print_3()
        {
            Console.WriteLine(a_l +" " + a + " " + a_r);
        }
        public static Fuzzy operator + (Fuzzy F1, Fuzzy F2)//два разных обьекта одного и того же класса
        {
            Fuzzy F = new Fuzzy();
            F.a_l = F1.a + F2.a - F1.a_l - F2.a_l;
            F.a = F1.a + F2.a;
            F.a_r = F1.a_r + F2.a_r + F1.a + F2.a;
            return F;
        }

        public static Fuzzy operator - (Fuzzy F1, Fuzzy F2)
        {
            Fuzzy F = new Fuzzy();
            F.a_l = F1.a - F2.a - F1.a_l - F2.a_l;
            F.a = F1.a - F2.a;
            F.a_r = F1.a - F2.a + F1.a_r + F2.a_r;
            return F;
        }

        public static Fuzzy operator * (Fuzzy F1, Fuzzy F2)
        {
            Fuzzy F = new Fuzzy();
            F.a_l = F1.a * F2.a - F2.a * F1.a_l - F1.a * F2.a_l + F1.a_l * F2.a_l;
            F.a = F1.a * F2.a;
            F.a_r = F2.a * F1.a + F2.a * F1.a_r + F1.a_r * F2.a_r;
            return F;
        }

        public static Fuzzy operator / (Fuzzy F1, Fuzzy F2)
        {
            Fuzzy F = new Fuzzy();
            F.a_l = (F1.a / F1.a_l)/(F2.a + F2.a_r);
            F.a = F1.a / F2.a;
            F.a_r = (F1.a + F1.a_r) / (F2.a - F2.a_l);
            return F;
        }

        public static Fuzzy operator / ( int F2 ,Fuzzy F1)
        {
            Fuzzy F = new Fuzzy();
            F.a_l = 1 / (F1.a + F1.a_r);
            F.a = 1 / F1.a;
            F.a_r = 1 / (F1.a - F1.a_l);
            return F;
        }

        public override bool Equals(System.Object obj)//перекрывание метода equals
        {
            if (obj == null)
            {
                return false;
            }

            Fuzzy f = obj as Fuzzy;//проверяет является ли обьект ссылкой на тип и если это так возращает новую ссылку используя новый тип, если нет нам
            if ((System.Object)f == null)
            {
                return false;
            }

            return (a == f.a) && (a_l == f.a_l) && (a_r == f.a_r);
        }

        public bool Equals(Fuzzy f)
        {
            if ((object)f == null)
            {
                return false;
            }

            return (a == f.a) && (a_l == f.a_l) && (a_r == f.a_r);
        }

        public static bool operator == (Fuzzy F1, Fuzzy F2)//bool возращаемый тип
        {
            if (System.Object.ReferenceEquals(F1, F2))//если f1 и f2 соответсвуют одному параметру то true
            {
                return true;
            }

            if (((object)F1 == null) || ((object)F2 == null))
            {
                return false;
            }

            return F1.a == F2.a && F1.a_l == F2.a_l && F1.a_r == F2.a_r;
        }

        public static bool operator != (Fuzzy F1, Fuzzy F2)
        {
            return !(F1 == F2);
        }
     }
}
