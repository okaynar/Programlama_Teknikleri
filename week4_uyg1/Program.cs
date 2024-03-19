using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_uyg1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[] { 3, 6, 9, 15 };

            List<int> sayilar = new List<int> { 3, 6, 9, 15 };

            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("------------------");
            foreach (int item in sayilar)
            {
                Console.WriteLine( item);
            }
            Console.WriteLine("--------");
            Array.Resize(ref A, 6);

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.WriteLine("eleman sayısı{0}",sayilar.Count);
            Console.WriteLine("-------------");

            sayilar.Add(66);
            sayilar.Add(75);
            Console.WriteLine("eleman sayısı{0}", sayilar.Count);
            Console.WriteLine("-------------");

            Console.WriteLine();
            sayilar.Insert(0, 100);
            sayilar.Insert(1, 150);

            Console.WriteLine("------------------");
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

            sayilar.Remove(100); // elemanı bul ve sil 
            
            Console.WriteLine("------------------");
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            sayilar.RemoveAt(0);// 0. elemanı 
                foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("eleman sayısı{0}", sayilar.Count);
            Console.WriteLine("-------------");
            sayilar.Clear();
            Console.WriteLine("eleman sayısı{0}", sayilar.Count);
            Console.WriteLine("-------------");

        }
    }
}
