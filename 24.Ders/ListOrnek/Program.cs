using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba .net framework!");

            // geriye liste döndüren metot
            List<string> isimler = new List<string>() { "samet", "elif", "eser", "hasan", "ismail", "merve", "nursel", "oğuz", "şevval", "ziya" };

            List<string> soyisimler = new List<string>() { "çakan", "sezgin", "altan", "benli", "adıgüzel/taha", "kaftancı", "nakir", "şencan", "yeşilyurt", "yılmaz" };


            List<string> yeniOgrencilerIsim = new List<string>() { "tugay", "ercan", "ahmet" };
            List<string> yeniOgrencilerSoyisim = new List<string>() { "tuna", "bozkurt", "yılmaz" };

            List<string> kullaniciIsimleri(List<string> isimlerListe, List<string> soyisimlerList)
            {
                List<string> returnDeger = new List<string>();
                for (int i = 0; i < isimlerListe.Count; i++)
                {
                    returnDeger.Add(isimlerListe[i] + " " + soyisimlerList[i].ToUpper());
                }

                return returnDeger;
            }




            foreach (string tum in kullaniciIsimleri(yeniOgrencilerIsim,yeniOgrencilerSoyisim))
            {
                Console.WriteLine(tum);
            }


        }
    }
}
