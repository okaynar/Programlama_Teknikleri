using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_uyg1_1
{

    class Program
    {

        static void Main(string[] args)
        {
            Student ogr1;
            int a;
            int[] dizi;

            dizi = new int[] { 1, 3, 5 };

           

            ogr1 = new Student();
            ogr1.Ad = "oguz";
            ogr1.Soy = "kaynar";

            Console.WriteLine(ogr1.Ad+" "+ogr1.Soy);


            Student ogr2 = new Student() { Ad = "ali", Soy = "can" };
            Console.WriteLine(ogr2.Ad + " " + ogr2.Soy);

            int b = 3;
            int c = 5;

            b = c;

            Student ogr3 = ogr1;
            ogr3.Ad = "betül";
            ogr3.Soy = "derya";

            Console.WriteLine(ogr1.Ad + " " + ogr1.Soy);

            int[] sayilar = new int[] { 4, 9, 15, 6 };

            dizi = sayilar;

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }


            Student[] mezunlar = new Student[3];

            Student[] eskiler = new Student[3] { ogr1, ogr2, new Student { Ad = "lale", Soy = "yilmaz" } };

            Console.WriteLine("------------");
            foreach  (Student  item in eskiler)
            {
                Console.WriteLine(item.Ad + " " + item.Soy);
            }


            //  eskiler = ogr2;  hata  tipler farklı
            mezunlar = eskiler;

        }
    }
}
