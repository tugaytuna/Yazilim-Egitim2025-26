using System.Runtime;

Console.WriteLine("Ödev 1");


int[] sayilar = { 5, 21, 7, 43, 11, 34, 55, 67, 20, 10 };

// tüm elemanların ekrana yazılması
// tüm elemanların toplanması ve ekrana yazdırılması
// tüm elemanların ortalamasının bulunması ve ekrana yazdırılması

int toplam = 0;
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
    //toplam = sayilar[i] + toplam;
    toplam += sayilar[i];
}

double ortalama = (double)toplam / (double)sayilar.Length;

Console.WriteLine("Sayıların toplamı: " + toplam);
Console.WriteLine("Sayıların ortalaması: " + ortalama);