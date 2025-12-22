Console.WriteLine("Ödev 3");


int[] notlar = { 45, 78, 90, 60, 32, 85, 100 };

// 50'nin altındaki notları getir
// 50 ve üzeri olan notların adet sayısı
// en yüksek not
// en düşük not
// sınıf geçme oranı

Console.WriteLine("50'nin altındaki notlar");
foreach (int not in notlar)
{
    if (not < 50)
    {
        Console.WriteLine(not);
    }
}

int elliUzeri = 0;
foreach (int not in notlar)
{
    if (not >= 50)
    {
        //elliUzeri += 1;
        elliUzeri++;
    }
}


Console.WriteLine("50 ve üzeri not alan sayısı: " + elliUzeri);

Console.WriteLine("En yüksek not: " + notlar.Max());
Console.WriteLine("En düşük not: " + notlar.Min());


Console.WriteLine(((double)elliUzeri / notlar.Length) * 100);