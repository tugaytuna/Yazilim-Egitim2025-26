Console.WriteLine("Metotlar Giriş");




void hosgeldinGonder()
{
    Console.WriteLine("Merhaba Dünya");
    Console.WriteLine("Uygulamanın amacı genel bilgilendirme yapmaktır.");
    Console.WriteLine("Bu uygulamada kişisel veriler hakkında bilgiler gelecektir.");
    Console.WriteLine("İşlemler tek gerçekleşir...");
}


void hosgeldinIsim(string isim)
{
    Console.WriteLine("Hoşgeldin " + isim);
}


hosgeldinGonder();
Console.WriteLine("--------------");
hosgeldinGonder();


hosgeldinIsim("Tugay");
hosgeldinIsim("Abdulsamet");

Console.WriteLine("Lütfen adınızı giriniz: ");
string kIsim = Console.ReadLine();
hosgeldinIsim(kIsim);
