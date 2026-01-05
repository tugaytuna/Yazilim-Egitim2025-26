using System.Xml.Schema;

Console.WriteLine("Kütüphane Uygulamasına Hoşgeldiniz!");


// bir döngü içerisinde
// kitap eklensin
// v2'de kitap ve sayfa sayısı eklensin (ayrı bir liste içinde)
// kitaplar listelensin
// kitap silinsin
// belli bir tuşa basıldığında uygulamadan çıkılsın

string secim;
List<string> kitapAdlari = new List<string>();

do
{
    Console.WriteLine("Kitap eklemek için 1 yazın");
    Console.WriteLine("Kitapları listelemek için 2 yazın");
    Console.WriteLine("Kitap silmek için 3 yazın");
    Console.WriteLine("Uygulamadan çıkmak için 4 yazın");

    secim = Console.ReadLine();

    switch(secim)
    {
        case "1":
            // kitap ekle
            Console.WriteLine("Lütfen kitabın adını giriniz:");
            string kisim = Console.ReadLine();
            kitapAdlari.Add(kisim);
            Console.WriteLine("Kitap eklendi.");
            break;
        case "2":
            // kitapları listele
            Console.WriteLine("Kitaplar listeleniyor..");
            Console.WriteLine("------------------");
            foreach (string kitap in kitapAdlari)
            {
                Console.WriteLine(kitap);
            }
            Console.WriteLine("------------------");
            break;
        case "3":
            // kitap silme
            Console.WriteLine("Hangi kitabı silmek istiyorsunuz adını giriniz:");
            string sisim = Console.ReadLine();
            bool silmeBasarili = kitapAdlari.Remove(sisim);
            if (silmeBasarili)
            {
                Console.WriteLine("Kitap başarılı bir şekilde silindi.");
            }
            else
            {
                Console.WriteLine("Kitap bulunamadı!");
            }

                break;
        case "4":
            // uygulamadan çıkmak
            Console.WriteLine("Uygulamadan çıkış yapılıyor...");
            break;
        default:
            // hatalı tuşlama
            Console.WriteLine("Hatalı tuşlama yaptınız!");
            break;
    }



} while (secim != "4");


