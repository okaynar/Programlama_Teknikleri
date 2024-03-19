using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_uyg1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ogr1 = new Student("oguz", "kaynar", 54, new List<string> { "matematik", "programalama", "web dersi" });
            Student ogr2 = new Student("ali", "can", 25, new List<string> { "bilgisayar ağları" });
            Student temp = new Student("mehmet", "gül", 18, new List<string>());


            //Console.WriteLine(ogr1.ToString());
            //Console.WriteLine(ogr2);
            //Console.WriteLine(temp);


            List<Student> mezunlar = new List<Student>
            {
                new Student("berna", "lacin", 35, new List<string> { "matematik", "programalama"}),
                new Student("hasan", "can", 20, new List<string> { "edebiyat", "ingilizce","alan dışı seçmali"}),
                ogr1,
                ogr2,
                temp
            };

            mezunlar.Add(new Student("xxxxx", "yyyy", 11, null));

            foreach (Student item in mezunlar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
