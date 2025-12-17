Console.WriteLine("11. Ders - Döngüler");

string[] adminler = { "tugay", "ismail", "tuna", "ercan", "elif", "nursel" };

// dizinin içindeki elemanların değişken tipi
// her bir elemana koyduğum isim
// in
// dizinin adı
foreach (string eleman in adminler)
{
    Console.WriteLine(eleman);
}


Console.WriteLine("-----------------");


// for döngüsü
// Değişkenin oluşturulması ve değer atanması ;
// Koşul ifadesinin oluşturulması ;
// Değişkenin artması/azalması (şartı bozmaya yönelik hareket)

for (int k = 1; k < 16; k++) 
{
    Console.WriteLine(k);
}

//Console.WriteLine(adminler[0]); // 1. Eleman
//Console.WriteLine(adminler[1]); // 2. Eleman
//Console.WriteLine(adminler[2]); // 3. Eleman
//Console.WriteLine(adminler[3]); // 4. Eleman
//Console.WriteLine(adminler[4]); // 5. Eleman

Console.WriteLine("Lütfen adınızı giriniz:");
string isim = Console.ReadLine();


for (int t = 0; t < adminler.Length; t++)
{
    if (isim == adminler[t])
    {
        Console.WriteLine("Admin hoş geldin!");
    }
}


// 50'den 60'e kadar 3'ün katlarını

int[] dizi1 = new int[10];
int sayac = 0;
for (int i = 50; i <= 60; i++)
{
    if (i % 3 == 0)
    {
        dizi1[sayac] = i;
        sayac++;
    }
}


foreach (int item in dizi1)
{
    Console.WriteLine(item);
}





