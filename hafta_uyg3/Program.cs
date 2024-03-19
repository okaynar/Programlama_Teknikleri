using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_uyg3
{
    class Program
    {
        static void Main(string[] args)
        {

            Dortgen d1 = new Dortgen();
           // d1.En = 20;
            //d1.Boy = 20;
            //Console.WriteLine("en={0} boy={1}  alan={2} cevre{3}",d1.En, d1.Boy, d1.alan(), d1.Cevre());
            Console.WriteLine(d1.ToString());
           // Console.WriteLine( d1.bilgiver());


            Dortgen d2 = new Dortgen();
            d2.En = 50;
            d2.Boy = 70;
            // Console.WriteLine("en={0} boy={1}  alan={2} cevre{3}", d2.En, d2.Boy, d2.alan(), d2.Cevre());
            Console.WriteLine(d2.ToString());
            //Console.WriteLine(  d2.bilgiver().ToUpper());

            Dortgen d3 = new Dortgen();
            d3.En = 3;
            d3.Boy = 5;
            Console.WriteLine(  d3.bilgiver());


            Dortgen d5 = new Dortgen(6, 8);
            Console.WriteLine(d5.ToString());

            Dortgen d6 = new Dortgen(5);
            Console.WriteLine(d6.ToString());


           // Dortgen[] dortgenler = new Dortgen[3];

           // List<Dortgen> sekiller = new List<Dortgen>();



        }
    }

    


}
