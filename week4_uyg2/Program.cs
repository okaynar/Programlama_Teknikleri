using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_uyg2
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> sayilar = new List<int> { 3, 6, 9, 15 };
            for (int i = 0; i < sayilar.Count; i++)
            {
                sayilar.Remove(sayilar[i]);
            }


            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            // doğrusu

            while (sayilar.Count>0)
            {
                sayilar.RemoveAt(0);
            }
            Console.WriteLine("liste elemanları");
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


            //alternatif yontem

            sayilar = new List<int> { 3, 6, 9, 15 };
            int[] yedek = new int[sayilar.Count];


            sayilar.CopyTo(yedek);

            for (int i = 0; i < yedek.Length ; i++)
            {
                sayilar.Remove(yedek[i]);
            }


            Console.WriteLine("liste elemanları");
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


            List<string> isimler = new List<string> { "ali", "ayse", "kaya" };
            foreach (string item in isimler )
            {
                Console.WriteLine(item);
            }


            isimler = new List<string> { "ali", "ayse", "kaya" };

            Console.WriteLine(isimler.Contains("mahmut"));  //  geciyorsa true  gecmiyorsa false 
            Console.WriteLine(isimler.IndexOf("kaya"));

            List<string> ogrenciler = new List<string>(isimler);
            ogrenciler.Add("sedanur");
            ogrenciler.Add("oguz");
            Console.WriteLine("----------------------");
            foreach (string item in ogrenciler )
            {
                Console.WriteLine(item);
            }


        }
    }
}
