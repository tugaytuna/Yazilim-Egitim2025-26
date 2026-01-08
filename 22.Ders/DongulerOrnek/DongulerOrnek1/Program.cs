Console.WriteLine("Örnek 1");



string isimDuzenleme(string isim, string soyisim)
{
    string fullname = isim + " " + soyisim.ToUpper();
    return fullname;
}

ConsoleColor kirmizi = ConsoleColor.Red;
ConsoleColor sari = ConsoleColor.Yellow;

void hosgeldinMesajı(string isim, string soyisim)
{
    string tamisim = isimDuzenleme(isim, soyisim);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Hoşgldiniz " + tamisim);
    Console.ForegroundColor = ConsoleColor.White;

    Console.BackgroundColor = ConsoleColor.Magenta;

    Console.ForegroundColor = kirmizi;
    Console.Write(isim);
    Console.ForegroundColor = sari;
    Console.Write(soyisim);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("");
}


Console.WriteLine("Lütfen isminizi giriniz: "); 
string kisim = Console.ReadLine();

Console.WriteLine("Şimdi de soyisminizi giriniz:");
string ksoyisim = Console.ReadLine();

hosgeldinMesajı(kisim, ksoyisim);


Console.WriteLine(isimDuzenleme(kisim,ksoyisim));