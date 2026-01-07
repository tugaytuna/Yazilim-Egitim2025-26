Console.WriteLine("Geriye Değer Döndüren Metotlar");




int toplama(int x, int y)
{
    //Console.WriteLine("Toplam: " + (x + y));
    int toplam = x + (y * y);
    return toplam;
}


int sayi1 = 10;
sayi1 = 20 + 10;


sayi1 = toplama(5,10);

Console.WriteLine(toplama(30, 50));


string fullname(string isim, string soyisim)
{
    string fullN = isim + " " + soyisim.ToUpper();
    return fullN;
}

Console.WriteLine(fullname("tugay", "tuna"));

Console.WriteLine("Lütfen adınızı giriniz: "); 
string name = Console.ReadLine();

Console.WriteLine("Lütfen soyisminizi giriniz");
string surname = Console.ReadLine();

string full = fullname(name, surname);


Console.WriteLine("Hoşgeldiniz " + full);

