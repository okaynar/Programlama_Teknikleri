using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_uyg2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = "bu gun hava çok güzel".Split(' ');
            foreach (string item in dizi)
            {
                Console.WriteLine(item);
            }
                
        }
    }
}
