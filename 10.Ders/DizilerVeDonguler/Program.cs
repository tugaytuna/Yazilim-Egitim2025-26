Console.WriteLine("10. Ders - Diziler ve Döngüler");

string isim = "tugay";
int yas = 20;
bool yasli = yas > 85;

string[] adminler = { "tugay", "ismail", "tuna", "ercan" };
int[] ciftRakamlar = new int[5];
string[] isimler = new string[4];
//bool[] ifadeler = new bool[2] { true, false };

ciftRakamlar[0] = 2;
ciftRakamlar[1] = 4;
ciftRakamlar[2] = 6;
ciftRakamlar[3] = 8;
ciftRakamlar[4] = 0;


Console.WriteLine(ciftRakamlar[2]);

//Console.WriteLine(adminler[0]);
//Console.WriteLine(adminler[1]);
//Console.WriteLine(adminler[2]);
//Console.WriteLine(adminler[3]);

// dizinin içindeki elemanların değişken tipi
// her bir elemana koyduğum isim
// in
// dizinin adı
foreach (string item in adminler)
{
    Console.WriteLine(item);
}
// foreach döngüsü dışında 'item' kullanılamaz!
//Console.WriteLine(item);


// Dizinin Eleman Sayısı
Console.WriteLine(ciftRakamlar.Length);
int adminlerElemanSayisi = adminler.Length;

// For Döngüsü (Loop)

// Değişkenin oluşturulması ve değer atanması
// Koşul ifadesinin oluşturulması
// Değişkenin artması/azalması (şartı bozmaya yönelik hareket)

for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}




