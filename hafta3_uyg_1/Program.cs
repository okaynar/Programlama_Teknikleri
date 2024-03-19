using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_uyg_1
{
    class Program
    {

         static int topla( int[]  a)
        {
            int toplam = 0;
            for (int i = 0; i < a.Length; i++)
            {
                toplam = toplam + a[i];
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;

            a = b;
            b = 4;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int[] x = new int[] { 3, 5, 7 };

            int[] y;
            y = x;
            Console.WriteLine($"x[0]={x[0]}, y[0]={y[0]}");
            Console.WriteLine($"x[2]={x[2]}, y[2]={y[2]}");
            x[2] = 21;
            Console.WriteLine($"x[2]={x[2]}, y[2]={y[2]}");


            x = new int[] { 1, 2, 3, 4 };


            Console.WriteLine("toplam="+topla(x).ToString());

            Console.WriteLine("toplam=" + topla(new int[] { 7, 8, 9 }).ToString());

            int[] sayilar = 5;
            Console.WriteLine(sayilar[0]);

        }
    }
}
