using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a_l: ");
            int a_l = int.Parse(Console.ReadLine());
            Console.WriteLine("a_r: ");
            int a_r = int.Parse(Console.ReadLine());
            Fuzzy F1 = new Fuzzy(a,a_l, a_r);
            F1.print();
            Console.WriteLine("b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("b_l: ");
            int b_l = int.Parse(Console.ReadLine());
            Console.WriteLine("b_r: ");
            int b_r = int.Parse(Console.ReadLine());
            Fuzzy F2 = new Fuzzy(b,b_l,b_r);
            F2.print();
            Fuzzy F3 = F1 + F2;
            F3.print_3();
            Fuzzy F4 = F1 - F2;
            F4.print_3();
            Fuzzy F5 = F1 * F2;
            F5.print_3();
            Fuzzy F6 =  1/ F1;
            F6.print_3();
            Fuzzy F7 = F1 / F2;
            F7.print_3();
            if (F1.Equals(F2))
            {
                Console.WriteLine("F1 == F2");
            }
            else
            {
                Console.WriteLine("F1 != F2");
            }
            if (F1 == F2)
            {
                Console.WriteLine("F1 == F2");
            }
            else
            {
                Console.WriteLine("F1 != F2");
            }
            Console.Read();
        }
    }
}
