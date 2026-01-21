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

            private int yas;
            public int Yas
            {
                get
                {
                    return yas;
                }
                set
                {
                    if (value > 6)
                    {
                        yas = value;
                    }
                    else
                    {
                        yas = 0;
                    }
                }
            }



            public void BilgiYazdir()
            {
                Console.WriteLine("Bu kişinin adı: " + Ad);
                Console.WriteLine("Bu kişinin yaşı: " + Yas);
            }

        }

        public class Ogrenci : Kisi
        {
            public int OkulNo { get; set; }
        }

        public class Ogretmen : Kisi
        {
            public string Brans { get; set; }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Bu uygulamada Kişi -> Öğrenci ve Öğretmen nesne örnekli bir proje yapacağız.");

            Kisi kisi1 = new Kisi() { Ad = "TugayKişisi", Yas = 18 };
            


            Console.WriteLine(kisi1.Yas); //get
            kisi1.Yas = 12; // set


            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Elif";
            ogrenci1.Yas = 19;
            ogrenci1.OkulNo = 359;
            

            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Ad = "Tugay";
            ogretmen1.Yas = 39;
            ogretmen1.Brans = "Yazılım";


            List<int> liste1 = new List<int>();
            liste1.Add(12);
            liste1.Add(5454);
            //liste1.Add("asdas");

            List<Ogrenci> liste2 = new List<Ogrenci>();
           
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = "Samet";
            ogr.Yas = 3;
            ogr.OkulNo = 121;


            liste2.Add(ogr);
            liste2.Add(ogrenci1);


            List<Kisi> personeller = new List<Kisi>();
            personeller.Add(kisi1);
            personeller.Add(ogrenci1);
            personeller.Add(ogretmen1);
            personeller.Add(ogr);


            foreach (Kisi personel in personeller)
            {
                personel.BilgiYazdir();
            }





        }
    }
}
