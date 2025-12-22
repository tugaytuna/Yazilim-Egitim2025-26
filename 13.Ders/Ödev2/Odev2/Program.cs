Console.WriteLine("Ödev 2");


// kullanıcıdan kaç adet sayı girmesini istediğini sor
// girilen sayı adeti kadar int dizisi oluştur
// çift sayıları yazdır
// tek sayıları yazdır


Console.WriteLine("Kaç adet sayı girmek istiyorsunuz:");
int adet = int.Parse(Console.ReadLine());

int[] dizi1 = new int[adet];

for (int i = 0; i < dizi1.Length; i++)
{
    Console.WriteLine((i + 1) +". sayıyı lütfen giriniz:");
    dizi1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Çift Sayılar");
foreach (int item in dizi1)
{
    if (item % 2 == 0)
    {
        Console.WriteLine(item);
    }
}

Console.WriteLine("Tek Sayılar");
foreach (int item in dizi1)
{
    if (item % 2 != 0)
    {
        Console.WriteLine(item);
    }
}