Console.WriteLine("Metotlar Tekrar");


void tanisma(string ad = "", bool detay = false)
{
    if (ad != "")
    {
        Console.WriteLine("Merhaba " + ad);
    }
    else
    {
        Console.WriteLine("Merhaba kullanıcı");
    }

    if (detay)
    {
        Console.WriteLine("Bu kallnıcı hakkında detaylı bilgi");
        Console.WriteLine("Kullanıcı detayları");
    }
    
}


//tanisma("tugay", false);
//tanisma("izel");

//tanisma();

//tanisma("tuna", true);

double cevreHesaplama(int r,bool goster = false, double pi = 3.14)
{
    // 2 x p R 
    // R = 2 x r
    double cevre = r * 2 * pi;

    if (goster)
    {
        Console.WriteLine("Çevre hesaplaması " + cevre);
    }


    return cevre;
}

cevreHesaplama(20);

cevreHesaplama(50, true, 3.142);

Console.WriteLine("Yarıçap değerini giriniz:");
int kdeger = int.Parse(Console.ReadLine());


if (cevreHesaplama(kdeger,false) > 150)
{
    Console.WriteLine("Daire uygundur!");
}
else
{
    Console.WriteLine("Daire uygun değildir!");
}

List<int> sayilar = new List<int>() { 2, 5, 11, 24, 52, 12, 14, 27, 42 };
List<int> sayilar2 = new List<int>() { 5, 15, 71, 11, 51, 91, 19, 22, 46 };
List<int> kareleriniBul(List<int> liste)
{
    List<int> kareler = new List<int>();
    foreach (int item in liste)
    {
        // karesi
        //Console.WriteLine(item * item);
        kareler.Add(item * item);
    }

    return kareler;
}

kareleriniBul(sayilar2);

kareleriniBul(new List<int>() { 1, 2, 5, 6, 10 });

//foreach (int item in sayilar)
//{
//    Console.WriteLine(item * item);
//}

//foreach (int item in sayilar2)
//{
//    Console.WriteLine(item * item);
//}


foreach (int item in kareleriniBul(sayilar))
{
    Console.WriteLine(item);
}


