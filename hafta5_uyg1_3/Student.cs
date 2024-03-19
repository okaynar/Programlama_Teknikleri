
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace hafta5_uyg1_3
{
    class Student:Object 
    {
        public string Ad { get; set; }
        public string Soy { get; set; }
        public int  Yas  { get; set; }

        public List<string> Dersler { get; set; }

        public Student()
        {
            Ad = "";
            Soy = "";
            Yas = 0;
            Dersler = new List<string>();

        }

        public Student(string ad, string soy, int yas, List<string> dersler)
        {
            Ad = ad;
            Soy = soy;
            Yas = yas;
            Dersler = dersler;
        }

        public override string ToString()
        {
            string baslik = Ad + "  " + Soy + "+  " + Yas.ToString()+"\n";
            baslik+= "aldığı dersler" + "\n";
            baslik +="-------------------" + "\n";

            if (Dersler != null)
            {
                if (Dersler.Count > 0)
                {
                    foreach (string item in Dersler)
                    {
                        baslik += item + "\n";
                    }
                }
                else
                    baslik += "aldığı hiç ders yok";

            }
            else
            {
                baslik += "aldığı hiç ders yok";
            }

                return baslik;
        }

    }
}