Console.WriteLine("Ödev 1");


//-Program çalıştığında kullanıcıdan not bilgileri alınacaktır.
//-Kullanıcı not girmeye devam edebilmeli, 0 girdiğinde not girişi sona ermelidir.
//-Girilen tüm notlar bir liste yapısında saklanmalıdır.

//-Liste içerisindeki notlar üzerinde döngü kullanılarak aşağıdaki işlemler yapılmalıdır:
//-Notların aritmetik ortalaması hesaplanmalıdır.
//-En yüksek not bulunmalıdır.
//-En düşük not bulunmalıdır.

List<int> notlar = new List<int>();


do
{
    Console.WriteLine("Yeni not gir");
    Console.WriteLine("Çıkış yapmak için 0 giriniz");
    int yeniNot = int.Parse(Console.ReadLine());
    if (yeniNot == 0)
    {
        break;

    }
    notlar.Add(yeniNot);

} while (true);


int toplamDeger = 0;
int ortalama = 0;

foreach (int item in notlar)
{
    toplamDeger += item;
}

ortalama = toplamDeger / notlar.Count;

  
Console.WriteLine("Notları aritmetik ortalamasını: " + ortalama);
Console.WriteLine("En yüksek not: " + notlar.Max());
Console.WriteLine("En düşük not: " + notlar.Min());
