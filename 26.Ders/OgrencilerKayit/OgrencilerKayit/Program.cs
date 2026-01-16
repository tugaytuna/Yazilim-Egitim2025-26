using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrencilerKayit
{
    internal class Program
    {
        public class Ogrenci
        {
            public int OgrenciNo;
            public string OgrenciIsim;
            public string OgrenciSoyisim;
            public int OgrenciSınıf;
            public int OgrenciNotOrt;

            
            public void BilgileriGetir()
            {
                Console.WriteLine(OgrenciNo + " numaralı " + OgrenciIsim + " " + OgrenciSoyisim + " " + OgrenciSınıf + ". sınıfta okuyor. Ortalaması: " + OgrenciNotOrt);
            }


        }


        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci() { OgrenciIsim = "Tugay", OgrenciSoyisim = "Tuna", OgrenciNo = 22, OgrenciNotOrt = 68, OgrenciSınıf = 11 };
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(ogrenci1);


            string secim = "0";

            while (secim != "4")
            {

                Console.WriteLine("1- Tüm Öğrencileri Listele");
                Console.WriteLine("2- Yeni Öğrenci Kaydı Oluştur");
                Console.WriteLine("3- Numaraya Göre Öğrenci Bul");
                Console.WriteLine("4- Çıkış Yap");

                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        tumOgrencilerListele();
                        break;
                    case "2":
                        yeniOgrenciKayit();
                        break;
                    case "3":
                        ogrenciBul();
                        break;
                    case "4":
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşlama yaptınız, tekrar deneyiniz.");
                        break;
                }
            }


            void tumOgrencilerListele()
            {
                Console.WriteLine("-------------------");
                foreach (Ogrenci ogr in ogrenciler)
                {
                    ogr.BilgileriGetir();
                }
                Console.WriteLine("-------------------");
            }

            void yeniOgrenciKayit()
            {
                Ogrenci ogr1 = new Ogrenci();

                Console.WriteLine("Öğrencinin okul numarasını giriniz: ");
                ogr1.OgrenciNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Öğrencinin adını giriniz: ");
                ogr1.OgrenciIsim = Console.ReadLine();

                Console.WriteLine("Öğrencinin soyadını giriniz: ");
                ogr1.OgrenciSoyisim = Console.ReadLine();

                Console.WriteLine("Öğrencinin sınıfını giriniz ");
                ogr1.OgrenciSınıf = int.Parse(Console.ReadLine());

                Console.WriteLine("Öğrencinin not ortalamasını giriniz: ");
                ogr1.OgrenciNotOrt = int.Parse(Console.ReadLine());


                ogrenciler.Add(ogr1);

                yesilYazi("Kayıt başarılı bir şekilde eklendi!");

            }

            void ogrenciBul()
            {
                Console.WriteLine("Öğrenci numarasını giriniz:");
                int aramaNo = int.Parse(Console.ReadLine());
                bool bulundu = false;
                foreach (Ogrenci ogr in ogrenciler)
                {
                    if (aramaNo == ogr.OgrenciNo)
                    {
                        ogr.BilgileriGetir();
                        bulundu = true;
                        return;
                    }
                }

                if (!bulundu)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bu numarada öğrenci bulunamadı!");
                    Console.ResetColor();
                }


            }

            void yesilYazi(string msg)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(msg);
                Console.ResetColor();
            }

        }
    }
}
