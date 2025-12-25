Console.WriteLine("Switch");

Console.WriteLine("Merhaba uygulamaya hoş geldiniz!");

List<int> sayilar = new List<int>() { 5, 12, 2, 29, 54, 32, 22, 1, 152 };

bool giris = true;
while (giris)
{
    Console.WriteLine("Listeyi ekrana yazdırmak için 'a' basın");
    Console.WriteLine("Listeyi büyükten küçüğe doğru sıralamak için 'b' basın");
    Console.WriteLine("Listeyi küçükten büyüye doğru sıralamk için 'k' basın");
    Console.WriteLine("Çıkış yapmak için 'c' basın");


    string secim = Console.ReadLine();

    if (secim == "a")
    {
        // tüm liste ekrana yazdırılsın

        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }


    }else if (secim == "b")
    {
        // tüm liste büyükten küçüğe sıralansın
        sayilar.Sort();
        sayilar.Reverse();
        Console.WriteLine("Liste büyükten küçüğe doğru sıralanmıştır!");

    }
    else if (secim == "k")
    {
        // tüm liste küçükten büyüye sıralansın
        sayilar.Sort();
        Console.WriteLine("Liste küçükten büyüye doğru sıralanmıştır!");
    }
    else if (secim == "c")
    {
        // çıkış yapılsın
        giris = false;
    }
    else
    {
        // hatalı tuşlama yapıldı densin
        Console.WriteLine("Hatalı tuşlama yaptınız!");
    }




}