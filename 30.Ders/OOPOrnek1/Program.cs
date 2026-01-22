using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek1
{
    internal class Program
    {
        public class Personel
        {
            public string Isim { get; set; }
            public string Soyisim { get; set; }
            public int Yas { get; set; }


            public virtual void BilgiYazdir()
            {
                Console.WriteLine("Kişinin adı - soyadı: " + Isim + " " + Soyisim);
                Console.WriteLine("Kişinin yaşı: " + Yas);
            }



        }

        public class Ogrenci : Personel
        {
            public int OkulNumarasi { get; set; }

            public override void BilgiYazdir()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Öğrencinin adı - soyadı: " + Isim + " " + Soyisim);
                Console.WriteLine("Öğrencinin okul numarası: " + OkulNumarasi);
                Console.ResetColor();
            }
        }

        public class Ogretmen : Personel
        {
            public string Brans { get; set; }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Uygulamaya hoş geldiniz");

            Personel personel1 = new Personel() { Isim = "Ahmet", Soyisim = "Yılmaz", Yas = 44 };
            Ogrenci ogrenci1 = new Ogrenci() { Isim = "Samet", Soyisim = "Çakan", Yas = 20, OkulNumarasi = 198 };
            Ogretmen ogretmen1 = new Ogretmen() { Isim = "Tugay", Soyisim = "Tuna", Yas = 30, Brans = "Yazılım" };
            Ogrenci ogrenci2 = new Ogrenci() { Isim = "Yusuf", Soyisim = "Balcı", Yas = 18, OkulNumarasi = 548 };


            List<Personel> personeller = new List<Personel>();
            personeller.Add(personel1);
            personeller.Add(ogrenci1);
            personeller.Add(ogretmen1); 
            personeller.Add(ogrenci2);


            foreach (Personel prs in personeller)
            {
                prs.BilgiYazdir();
            }

        }
    }
}
