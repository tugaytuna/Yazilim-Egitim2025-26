using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    internal class Program
    {
        class BankaHesabi
        {
            int HesapNo;
            string SahipAdi;
            decimal Bakiye;
        }


        static void Main(string[] args)
        {
            string secim = "0";

            while (secim != "4")
            {
                Console.WriteLine("1- Hesap bilgisini görmek için");
                Console.WriteLine("2- Para çekmek için");
                Console.WriteLine("3- Para yatırmak için");
                Console.WriteLine("4- Uygulamadan çıkmak için");

                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        // hesap bilgileri göster
                        break;
                    case "2":
                        // para çek
                        break;
                    case "3":
                        // para yatır
                        break;
                    case "4":
                        // uygulamadan çıkış
                        break;
                    default:
                        // hatalı tuşlama
                        break;
                }



            }



        }
    }
}
