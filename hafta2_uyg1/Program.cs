using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_uyg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(3,4));
            Console.WriteLine(Matematik.us_al(3,3));

            Console.WriteLine("-------------");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine (Matematik.kom(5,i)  );
            }
            Console.WriteLine("----------------");
            Console.WriteLine(Matematik.topla(3,5,7));
            Console.WriteLine(Matematik.topla(3, 5));
            Console.WriteLine("--------------");
            Console.WriteLine(Matematik.topla(new int[] { 1, 2, 3, 4, 15 } ) );

            Console.WriteLine("--------------");
            Console.WriteLine(Matematik.carp(3,5));
            Console.WriteLine(Matematik.carp(4,7,2,3));
            Console.WriteLine(Matematik.carp(7, 5));

            Console.WriteLine(Matematik.birlestir('-',"hello","ali","ahmet", "hasan").ToUpper());


            Console.Write("lutfen N değerini  girin");
            int n = Convert.ToInt16(Console.ReadLine());

            int y = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"fak({i})= {Matematik.fak(i)}");
                y = y + Matematik.fak(i);

            }

            Console.WriteLine(y);

            
            Console.ReadKey();



            for (int i = 1; i <=10 ; i++)
            {
                Console.WriteLine($"3x{i}={3*i}");
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format("3x{0}={1})",i,i*3));
                Console.WriteLine("3x{0}={1})", i, i * 3);

            }


        }



    }
}
