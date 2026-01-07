Console.WriteLine("Geriye Değer Döndüren Metotlar");

void karesi(int sayi, bool ekstraBilgi){
    Console.WriteLine( sayi + " sayısının karesi: " + kareHesapla(sayi));

    if (ekstraBilgi)
    {
        if (sayi % 2 == 0) //çift ise
        {
            Console.WriteLine("Girdiğiniz sayı aynı zamanda çifttir");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı aynı zamanda tektir");
        }
    }   
}


int kareHesapla(int sayi)
{
    return (sayi * sayi);
}


int yas = 18;
List<int> sayilar = new List<int>() { 2, 3, 8, 14, 15, 19, 42 };
List<int> sayilarinKaresi = new List<int>();



karesi(5,true);
karesi(14,true);

karesi(yas,true);

karesi(sayilar[2],true);

for (int i = 0; i < sayilar.Count; i++)
{
    karesi(sayilar[i],false);
    sayilarinKaresi.Add(kareHesapla(sayilar[i]));
}