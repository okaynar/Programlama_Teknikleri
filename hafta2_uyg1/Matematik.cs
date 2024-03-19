using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_uyg1
{
    public static class Matematik
    {
        public static int us_al(int a, int b)
        {
            int f = 1;
            for (int i = 0; i < b; i++)
            {
                f = f * a;
            }
            return f;

        }
        public static int fak(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
            }
            return x;
        }


        public static int kom(int a, int b)
        {
            return fak(a) / (fak(b) * fak(a - b));

        }

        public static int topla(int a, int b)
        {
            return a + b;
        }

        public static int topla(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int topla(int[] sayilar)

        {
            int t = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                t = t + sayilar[i];
            }
            return t;
        }

        public static int carp(params int[] sayilar)

        {
            int c = 1;
            for (int i = 0; i < sayilar.Length; i++)
            {
                c = c * sayilar[i];
            }
            return c;
        }

        public static string birlestir(params string[] dizi)
        {
            string s = "";

            foreach (string item in dizi)
            {
                s = s + " "+ item;
            }

            return s;
        }


        public static string birlestir(char ch,params string[] dizi)
        {
            string s = "";

            foreach (string item in dizi)
            {
                s = s + ch + item;
            }

            return s;
        }

    }
    
}
