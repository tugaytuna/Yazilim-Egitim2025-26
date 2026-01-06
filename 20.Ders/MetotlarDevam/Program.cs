Console.WriteLine("Metotlar Devam");




void hesapla(int sayi1, int sayi2, string tt)
{
    if (sayi1 > 5000 || sayi2 > 5000)
    {
        Console.WriteLine("Daha küçük bir sayı giriniz");
    }
    else
    {
        Console.WriteLine("Hesaplama yapılıyor...");

        switch (tt)
        {
            case "1":
                // toplama
                Console.WriteLine("Toplama işlemi sonucu: " + (sayi1 + sayi2));
                break;
            case "2":
                // çıkarma
                Console.WriteLine("Çıkarma işlemi sonucu: " + (sayi1 - sayi2));
                break;
            case "3":
                // çarpma
                Console.WriteLine("Çarpma işlemi sonucu: " + (sayi1 * sayi2));
                break;
            case "4":
                // bölme
                double sonuc = (double)sayi1 / (double)sayi2;
                Console.WriteLine("Bölme işlemi sonucu: " + sonuc);
                break;
            default:
                Console.WriteLine("Hatalı seçim değeri gönderdiniz, işlem hesaplanamadı.");
                break;
        } 
    }
}


hesapla(20, 40, "3");

while (true)
{
    Console.WriteLine("-------------------");
    Console.WriteLine("Lütfen 1. sayıyı giriniz:");
    int ksayi = int.Parse(Console.ReadLine());

    Console.WriteLine("Lütfen 2. sayıyı giriniz:");
    int ksayi2 = int.Parse(Console.ReadLine());

    Console.WriteLine("1- Toplama yapmak için");
    Console.WriteLine("2- Çıkarma yapmak için");
    Console.WriteLine("3- Çarpma yapmak için");
    Console.WriteLine("4- Bölme yapmak için");

    string secim = Console.ReadLine();

    hesapla(ksayi, ksayi2, secim);
}




