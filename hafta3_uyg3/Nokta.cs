using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_uyg3
{
    class Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void yaz()
        {
            Console.WriteLine("{0}, {1}",X,Y );
        }
        public static void selamla()
        {
            Console.WriteLine("hello world");
        }
    }
}
