using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

Console.WriteLine("Ödev 2");


// Sürekli menü gelecek - döngü

//-Alışveriş listesine ürün ekle
//-Alışveriş listesini görüntüle
//-Alışveriş listesinden ürün sil
//-Programdan çık

//-Eklenen ürünler bir liste içerisinde saklanmalıdır.
//-Silme işlemi, kullanıcının girdiği ürün adına göre yapılmalıdır.
//-Liste boşken silme işlemi yapılmaya çalışılırsa kullanıcı bilgilendirilmelidir.




string secim = "0";
List<string> alisverisListe = new List<string>();

do
{
    Console.WriteLine("Alışveriş Listesine Hoş Geldiniz!");
    Console.WriteLine("1- Ürün ekle");
    Console.WriteLine("2- Liste görüntüle");
    Console.WriteLine("3- Ürün sil");
    Console.WriteLine("4- Programı kapat");

    secim = Console.ReadLine();

    switch (secim) {
        case "1":
            
            Console.WriteLine("Ürün ismini giriniz:");
            string yeniUrun = Console.ReadLine();
            alisverisListe.Add(yeniUrun);
            
            break;
        case "2":
            
            Console.WriteLine("-----------------");
            foreach (string item in alisverisListe)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            break;
        case "3":

            Console.WriteLine("Silmek istediğiniz ürünün adını giriniz:");
            string silUrun = Console.ReadLine();
            bool basariliSilme = alisverisListe.Remove(silUrun);

            if (basariliSilme)
            {
                Console.WriteLine("Başarılı bir şekilde silindi.");
            }
            else
            {
                Console.WriteLine("Ürün bulunamadı");
            }


            break;
        case "4":
            Console.WriteLine("Uygulamadan çıkış yapılıyor...");
            break;
        //default:
        //    Console.WriteLine("Hatalı tuşlama yaptınız!");
        //    break;
    }


} while (secim != "4");