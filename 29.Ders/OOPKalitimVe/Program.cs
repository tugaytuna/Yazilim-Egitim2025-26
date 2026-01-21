using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimVe
{
    internal class Program
    {
        public class Kisi
        {
            public string Ad { get; set; }
            public int Yas { get; set; }


            public void BilgiYazdir()
            {
                Console.WriteLine("Bu kişinin adı: " + Ad);
                Console.WriteLine("Bu kişinin yaşı: " + Yas);
            }

        }

        public class Ogrenci
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

            public int OkulNo { get; set; }
        }

        public class Ogretmen
        {
            public string Ad { get; set; }
            public int Yas { get; set; }
            public string Brans { get; set; }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Bu uygulamada Kişi -> Öğrenci ve Öğretmen nesne örnekli bir proje yapacağız.");

            Kisi kisi1 = new Kisi() { Ad = "Tugay", Yas = 18 };

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Elif";
            ogrenci1.Yas = 19;
            ogrenci1.OkulNo = 359;




        }
    }
}
