using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Listeler-2");

int sayi1 = 22;

List<int> sayilarListesi = new List<int>();

sayilarListesi.Add(48);
sayilarListesi.Add(sayi1);
sayilarListesi.Add(55);
sayilarListesi.Add(22);

Console.WriteLine(sayilarListesi[0]);

foreach (int item in sayilarListesi)
{
    Console.WriteLine(item);
}


// Elemanın değeri yazarak silebiliyoruz.
//sayilarListesi.Remove(22);

// Index olarak silme işlemi yapar
//sayilarListesi.RemoveAt(0);

// Dizideki en son elemanı siler
//sayilarListesi.RemoveAt(sayilarListesi.Count - 1);
//Console.WriteLine(sayilarListesi[sayilarListesi.Count -1]);

// Bir koşula göre silme işlemi
//sayilarListesi.RemoveAll(item => item > 25);

//Tüm listeyi temizler/sıfırlar
//sayilarListesi.Clear();

sayilarListesi.RemoveAt(2);
sayilarListesi.Insert(2,10);



sayilarListesi.AddRange(new List<int>() { 5, 47, 11 });
//sayilarListesi.Add(5);
//sayilarListesi.Add(47);
//sayilarListesi.Add(11);


Console.WriteLine("For döngüsü ile tüm liste ekrana yazdırılır!");
for (int i = 0; i < sayilarListesi.Count; i++)
{
    Console.WriteLine(sayilarListesi[i]);
}

List<string> adminler = new List<string>() { "tugay", "tuna", "ahmet", "tugay" };
string[] soyisimler = new string[] { "tuna", "ahmet", "özkan" };

adminler.Add("yeniAdmin");


//adminler.Remove("tugay");


Console.WriteLine("Silmek istediğiniz kullanıcının adını giriniz");
string silKullanici = Console.ReadLine();

adminler.Remove(silKullanici);


Console.WriteLine("Tüm adminler listeleniyor");
foreach (string isim in adminler)
{
    Console.WriteLine(isim);
}