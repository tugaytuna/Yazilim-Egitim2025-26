Console.WriteLine("Listeler ve Döngüler");


List<string> ogrenciler = new List<string>() { "Nursel", "İsmail", "Mehmet", "Abdulsamet", "Yusuf" };
List<int> ciftSayilar = new List<int>();
List<int> tekSayilar = new List<int>();

// Kullanıcıdan bir sayı istenir
// kullanıcan istenen sayıya kadar olan tüm çift sayılar ciftSayilar listesine,
// tüm tek sayılar tekSayilar listesine aktarılır.



Console.WriteLine("Lütfen bir sayı giriniz:");
int kSayi = int.Parse(Console.ReadLine());

for (int i = 1; i <= kSayi; i++)
{
    if (i % 2 == 0) // çift ise
    {
        ciftSayilar.Add(i);
    }
    else
    {
        tekSayilar.Add(i); 
    }
}

// sonrasında kullanıcıya tekrar sorulur, tek sayıları mı çift sayıları mı listelemek ister.
// Seçimine göre ilgili liste elemanları ekrana yazdırılır


bool cikis = false;

while (!cikis)
{
    Console.WriteLine("Tek sayıları ekrana yazdırmak için '1' basın");
    Console.WriteLine("Çift sayıları ekrana yazdırmak için '2' basın");
    Console.WriteLine("Tüm sayıları listelemek için '3' basın");
    Console.WriteLine("Uygulamadan çıkmak için '4' basın");

    int secim = int.Parse(Console.ReadLine());


    if (secim == 1)
    {
        foreach (int x in tekSayilar)
        {
            Console.WriteLine(x);
        }
    }
    else if (secim == 2)
    {
        foreach (int x in ciftSayilar)
        {
            Console.WriteLine(x);
        }
    }
    else if (secim == 3)
    {
        for (int i = 1; i <= kSayi; i++)
        {
            Console.WriteLine(i);
        }
    }else if (secim == 4)
    {
        Console.WriteLine("İyi günler");
        cikis = true;
    }
    else
    {
        Console.WriteLine("Hatalı tuşlama yaptınız!");
    }

}


