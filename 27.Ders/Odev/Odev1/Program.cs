using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    internal class Program
    {
        public class BankaHesabi
        {
            public int HesapNo;
            public string SahipAdi;
            public decimal Bakiye;
        }


        static void Main(string[] args)
        {
            string secim = "0";

            BankaHesabi bankahesabi1 = new BankaHesabi();
            bankahesabi1.SahipAdi = "Elif Sezgin";
            bankahesabi1.Bakiye = 500;
            bankahesabi1.HesapNo = 142365;

            List<BankaHesabi> hesaplar = new List<BankaHesabi>() { new BankaHesabi() { HesapNo = 125921, Bakiye = 100, SahipAdi = "Tugay Tuna" }, new BankaHesabi() { HesapNo = 154264, Bakiye = 200, SahipAdi = "Samet Çakan" } };

            hesaplar.Add(bankahesabi1);






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
                        hesapBilgileriGoster();
                        break;
                    case "2":
                        paraCek();
                        break;
                    case "3":
                        paraYatir();
                        break;
                    case "4":
                        Console.WriteLine("Oturumunuz başarılı bir şekilde sonlandırılmıştır.");
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşlama yaptınız, tekrar deneyiniz.");
                        break;
                }

            }

            void hesapBilgileriGoster()
            {
                Console.Clear();
                Console.WriteLine("Hesap numaranızı giriniz:");
                int hesapnumara = int.Parse(Console.ReadLine());

                //bool bulundu = false;

                BankaHesabi account = hesaplar.Find(item => item.HesapNo == hesapnumara);

                if (account == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aradığınız hesap bulunamadı!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Hesap sahibinin biglileri: " + account.SahipAdi);
                    Console.WriteLine(account.HesapNo + " numaralı hesabın bakiyesi: " + account.Bakiye + " TL");
                }

                  

                //foreach (BankaHesabi item in hesaplar)
                //{
                //    if (hesapnumara == item.HesapNo)
                //    {
                //        bulundu = true;

                //        Console.WriteLine("Hesap sahibinin biglileri: " + item.SahipAdi);
                //        Console.WriteLine(item.HesapNo + " numaralı hesabın bakiyesi: " + item.Bakiye + " TL");

                //        break;
                //    }
                    
                //}

                //if (!bulundu)
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("Aradığınız hesap bulunamadı!");
                //    Console.ResetColor();
                //}

            }




            void paraCek() 
            {
                Console.Clear();
                Console.WriteLine("Hesap numaranızı giriniz:");
                int hesapnumara = int.Parse(Console.ReadLine());

                bool bulundu = false;

                foreach (BankaHesabi item in hesaplar)
                {
                    if (hesapnumara == item.HesapNo)
                    {
                        bulundu = true;

                        Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz:");
                        int tutar = int.Parse(Console.ReadLine()); // double tipinde tutabilirim
                        item.Bakiye -= tutar; //bakiye kontrolü
                        Console.WriteLine("İşlem başarıyla gerçekleşti.");
                        break;
                    }
                }

                if (!bulundu)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aradığınız hesap bulunamadı!");
                    Console.ResetColor();
                }
            }

            void paraYatir() 
            {
                Console.Clear();
                Console.WriteLine("Hesap numaranızı giriniz:");
                int hesapnumara = int.Parse(Console.ReadLine());

                bool bulundu = false;

                foreach (BankaHesabi item in hesaplar)
                {
                    if (hesapnumara == item.HesapNo)
                    {
                        bulundu = true;

                        Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz:");
                        int tutar = int.Parse(Console.ReadLine()); // double tipinde tutabilirim
                        item.Bakiye += tutar;
                        Console.WriteLine("İşlem başarıyla gerçekleşti.");
                        break;
                    }
                }

                if (!bulundu)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aradığınız hesap bulunamadı!");
                    Console.ResetColor();
                }
            }

        }
    }
}
