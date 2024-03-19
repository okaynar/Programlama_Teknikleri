using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_uyg3
{
    class Program
     {
        static void  selamla(string mes)
        {

            Console.WriteLine("hello "+mes);
        }

        static void Main(string[] args)
        {

            int a=0;

            Console.WriteLine(a); ;

            Nokta p = new Nokta();
            p.X = 5;
            p.Y = 7;
            p.yaz();
            Nokta.selamla();
            //Console.WriteLine("{0},{1}",p.X, p.Y );
            //Nokta kose = new Nokta();

            //Console.WriteLine("{0},{1}", kose.X, kose.Y);

            //kose = p;
            //Console.WriteLine("{0},{1}", kose.X, kose.Y);

            //p.X = 20;
            //Console.WriteLine("{0},{1}", kose.X, kose.Y);


            //Nokta[] noktalar = new Nokta[3];

            //noktalar[0] = new Nokta();
            //noktalar[0].X = 30;
            //noktalar[0].Y = 40;
            //noktalar[1] = p;
            //noktalar[2] = new Nokta();

            //Console.WriteLine("-------------------");
            //for (int i = 0; i < noktalar.Length; i++)
            //{
            //    Console.WriteLine(" {0},{1} ", noktalar[i].X, noktalar[i].Y);
            //}


            //Nokta[] Dortgen = new Nokta[] { new Nokta(), new Nokta(), p, kose };

            //selamla("oğuz");
            //selamla("deneme");
        }
    }
}
