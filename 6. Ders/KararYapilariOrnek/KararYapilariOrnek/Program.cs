Console.WriteLine("Karar Yapıları Örnekler");


int sayi1 = 10;

string isim = "tugay";


string isim2 =  Console.ReadLine();


Console.WriteLine("Hoş geldin " + isim2);

// İkinci Örnek

Console.WriteLine("Lütfen adınızı giriniz:");
isim = Console.ReadLine();

if (isim == "tuna")
{
    Console.WriteLine("Hoş geldin admin!");
}
else if (isim == "tolga")
{
    Console.WriteLine("Hoş geldin editör!");
}
else
{
    Console.WriteLine("Hoşgeldin misafir kullanıcı");
}

// Yaş 18'den büyük 30'dan küçükse; "uygundur" yazsın.

sayi1 = 25;
int sayi2 = 20;

// AND - VE - &&
// TRUE - TRUE -> TRUE
// TRUE - FALSE -> FALSE
// FALSE - TRUE -> FALSE
// FALSE - FALSE -> FALSE


if (sayi1 >= 18 && sayi1 <= 30)
{
    Console.WriteLine("Sayı 18 ile 30 arasındadır!");
}
else if (sayi1 > 30)
{
    Console.WriteLine("30'dan büyüktür!");
}
else
{
    Console.WriteLine("Sayı 18'den küçüktür!");
}


// OR - VEYA - ||
// TRUE - TRUE -> TRUE
// TRUE - FALSE -> TRUE
// FALSE - TRUE -> TRUE
// FALSE - FALSE -> FALSE


if (isim == "tugay" || isim == "tuna")
{
    Console.WriteLine("Admin geldi!");
}
else
{
    Console.WriteLine("Misafir kullanıcı");
}
