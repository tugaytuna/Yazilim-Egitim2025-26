using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OOPDevam
{
    internal class Program
    {
        public class Ogrenci
        {
            public string Ad { get; set; }
            public string Soyad{ get; set; }
            public int OkulNo { get; set; }
            public double OrtalamaNot { get; set; }

            public Ogrenci()
            {

            }

            public Ogrenci(string soyad)
            {
                Soyad = soyad.ToUpper();
            }

            public Ogrenci(string ad, string soyad)
            {
                Ad = ad;
                Soyad = soyad.ToUpper();
            }

            public void BilgileriYazdir()
            {
                Console.WriteLine("Öğrencinin adı-soyadı: " + Ad + " " + Soyad);
                Console.WriteLine("Öğrencinin okul numarası: " + OkulNo);
                Console.WriteLine("Öğrencinin not ortalaması: " + OrtalamaNot);
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci kayıt uygulamasına hoşgeldiniz!");

            Ogrenci ogrenci1 = new Ogrenci("Tugay","Tuna");
            //ogrenci1.Ad = "Tugay";
            //ogrenci1.Soyad = "Tuna";
            ogrenci1.OkulNo = 185;
            ogrenci1.OrtalamaNot = 84.5;

            //Ogrenci yeniOgrenci = new Ogrenci();

            Ogrenci ogrenci2 = new Ogrenci("Elif","Sezgin") { OkulNo = 585, OrtalamaNot = 92.5 };
            
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(ogrenci1);
            ogrenciler.Add(ogrenci2);


            Console.WriteLine("Yeni öğrenci kaydı oluşturuluyor..");
            Console.WriteLine("Lütfen öğrencinin adını giriniz:");
            string kisim = Console.ReadLine();
            Console.WriteLine("Lütfen öğrencinin soyadını giriniz:");
            string ksoyisim = Console.ReadLine();

            ogrenciler.Add(new Ogrenci(kisim, ksoyisim));

            Ogrenci yeni = new Ogrenci("tuna");
            yeni.Ad = "Tugay";



            Console.WriteLine("Tüm öğrencilerin bilgileri listeleniyor...");
            foreach (Ogrenci ogr in ogrenciler)
            {
                ogr.BilgileriYazdir();
            }



                                            
            

        }
    }
}
