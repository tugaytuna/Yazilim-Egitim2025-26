Console.WriteLine("Döngüler Örnek 2");


// 1'den 50'ye kadar olan çift sayıların karelerini ekrana yazdırın (metot kullanarak)

List<int> ciftSayilar = new List<int>();
List<int> tekSayilar = new List<int>();



// 1'den 50'ye kadar olan çift sayıları listeye ekle
for (int i = 0; i < 50; i++)
{
    if (i % 2 == 0) // çift ise
    {
        ciftSayilar.Add(i);
    }
}

for (int i = 0; i < 50; i++)
{
    if (i % 2 != 0) // tek ise
    {
        tekSayilar.Add(i);
    }
}


void kareHesaplama(string secim)
{
    switch (secim)
    {
        case "1":
            foreach (int item in ciftSayilar)
            {
                Console.WriteLine(item * item);
            }
            break;
        case "2":
            foreach (int item in tekSayilar)
            {
                Console.WriteLine(item * item);
            }
            break;
    }
}

Console.WriteLine("Çift ise 1'e, Tek ise 2'ye basın");
string tercih = Console.ReadLine();

kareHesaplama(tercih);

// Parametre olarak liste.
// Tekler kırmızı, çiftler yeşil gözüksün.