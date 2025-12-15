using System.Runtime.InteropServices;

Console.WriteLine("Merhaba Dünya");

// Ekrana yazı yazdırmak için kullanıyoruz
Console.WriteLine("Genel Tekrar");

// Ekrana yazı yazdırmak için kullanıyoruz. Bir satır aşağı inmeden sadece içindeki metinsel ifadeyi ekrana yazdırır.
Console.Write("Merhaba");
Console.Write("Dünya");


Console.WriteLine("Write Line");

//Değişken Tipleri


// Metinsel veri tipi
string kullaniciAdi;
string sifre = "sajhasas121";
string lorem = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
// Sayısal veri tipi
int sayi1;
int yas = 24;
// Mantıksal veri tipi - Değer yalnızca, 'true' ya da 'false'
bool admin;
bool login = true;

// Boş olarak oluşturduğum değişkene sonradan değer ataması yapabilirim.
//kullaniciAdi = "tugay";
//Console.WriteLine(kullaniciAdi);

// Daha az kullanılan değişken tipleri

// Daha büyük sayılar için. Ve bellekte daha fazla yer kaplar.
long buyukSayi = 12312;

// Daha küçük sayılar için. Ve bellekte daha az yer kaplar.
short kucukSayi = 23213;

// Daha küçük byte değerleri için
byte bitler = 121;


// Ondalık sayılar için
double ondalikSayi = 1.5;

float odalikSayi2 = 2.5f;
decimal ondalikSayi3 = 12.2m;

char karakter = 's';


Console.WriteLine($"{karakter} tek karakterli örnektir.");
Console.WriteLine("{0} bu tip değişkenler ve {1} bu tip değişkenler.", karakter, ondalikSayi);

Console.WriteLine("Yaşınızı giriniz:");
string kullaniciYasS = Console.ReadLine();
int kullaniciYas = int.Parse(kullaniciYasS);

// Operatörler
// VE && AND
// VEYA || OR

if (kullaniciYas > 18  && kullaniciYas < 30)
{
    Console.WriteLine("18 - 30 yaş arası");
}else if (kullaniciYas > 30)
{
    Console.WriteLine("Kayıt olamazsınız");
}else
{
    Console.WriteLine("18 yaşından küçükler giremez!");
}


Console.WriteLine("Lütfen adınızı giriniz:");
string isim = Console.ReadLine();


// Uygulamamızda 2 tane admin var, biri 'tugay' diğer 'tolga'
// Kullanıcı tugay veya tolga girdiğinde hoş geldin admin desin
// Şartlar sağlanmazsa 'hoş geldin kullanıcı' yazsın
if (isim == "tugay" || isim == "tolga")
{
    Console.WriteLine("Hoş geldin admin");
}
else
{
    Console.WriteLine("Hoş geldin kullanıcı");
}

// String dizisi
string[] adminler = { "tugay", "tolga", "mehmet", "elif" };

Console.WriteLine(adminler[1]);

// Foreach Döngüsü
foreach (string adm in adminler)
{
    if (adm == isim)
    {
        Console.WriteLine("Hoşgeldin adminler!");
    }
}
