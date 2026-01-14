using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPGirisNETF.Program;

namespace OOPGirisNETF
{
    internal class Program
    {
        public class Kitap
        {
            public string KitapAdı;
            public int SayfaSayisi;
            public string YayınEvi;
            public int YayınYılı;

            public void BilgileriGoster()
            {
                Console.WriteLine(KitapAdı + " isimli kitap " + YayınYılı + " yılında " + YayınEvi + " tarfından yayınlanmıştır.");
            }

        }

        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap();
            kitap1.KitapAdı = "Donkişot";
            kitap1.SayfaSayisi = 215;
            kitap1.YayınEvi = "Can Yayınları";
            kitap1.YayınYılı = 1998;


            Kitap kitap2 = new Kitap();
            kitap2.KitapAdı = "Suç ve Ceza";
            kitap2.SayfaSayisi = 512;
            kitap2.YayınEvi = "İş Bankası Yayınevi";
            kitap2.YayınYılı = 2012;

            Kitap kitap3 = new Kitap() { KitapAdı = "Sıfır", SayfaSayisi = 145, YayınEvi = "Kırmızı Kedi Yayınevi", YayınYılı = 2020 };


            List<Kitap> kitaplik = new List<Kitap>();
            kitaplik.Add(kitap1);
            kitaplik.Add(kitap2);
            kitaplik.Add(kitap3);


            for (int i = 0; i < kitaplik.Count; i++)
            {
                kitaplik[i].BilgileriGoster();
                Console.WriteLine("Sayfa Sayısı: " + kitaplik[i].SayfaSayisi);
            }



            //Console.WriteLine(kitap1.KitapAdı);
            //Console.WriteLine(kitap1.YayınEvi);

            //kitap1.BilgileriGoster();
            //kitap2.BilgileriGoster();
            //kitap3.BilgileriGoster();





            //Console.WriteLine(kitap1.KitapAdı + " isimli kitap " + kitap1.YayınYılı + " yılında " + kitap1.YayınEvi + " tarfından yayınlanmıştır.");

            //Console.WriteLine(kitap2.KitapAdı + " isimli kitap " + kitap2.YayınYılı + " yılında " + kitap2.YayınEvi + " tarfından yayınlanmıştır.");




        }
    }
}
