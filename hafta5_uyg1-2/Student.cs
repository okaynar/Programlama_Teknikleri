using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace hafta5_uyg1_2
{
    class Student
    {
        public string Ad { get; set; }
        public string Soy { get; set; }
        public int  Yas  { get; set; }

        public Student()
        {
            Ad = "";
            Soy = "";
            Yas = 0;
        }

        public Student(string ad, string soy, int yas)
        {
            Ad = ad;
            Soy = soy;
            Yas = yas;
        }


    }
}