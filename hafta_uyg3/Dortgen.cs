using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_uyg3
{
    class Dortgen
    {

        public int En { get; set; }
        public int Boy { get; set; }

        public Dortgen()
        {
            En = 0;
            Boy = 0;
        }

        public Dortgen(int en, int boy)
        {
            En = en;
            Boy = boy;
        }

        public Dortgen(int en)
        {
            En = en;
            Boy = en;
        }

            public int alan()
            {
                return En * Boy;
            }

            public int Cevre()
            {
                return 2 * (En + Boy);
            }
        
           public string bilgiver()
            {
             return  string.Format("en={0} boy={1}  alan={2} cevre{3}", En,Boy, alan(), Cevre());
           }

        public override string ToString()
        {
            return string.Format("en={0} boy={1}  alan={2} cevre{3}", En, Boy, alan(), Cevre());
        }

    }
}
