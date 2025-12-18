using System.Runtime.CompilerServices;

Console.WriteLine("Döngüler");

// kullanıcı isimlerinin olduğu bir 
// şifrelerin olduğu bir dizi

string[] kullaniciAdlari = { "tugay", "tuna", "abdulsamet", "izel" };
string[] kullaniciSifre = { "1234", "549ck", "563a", "555" };


Console.WriteLine("Lütfen kullanıcı adınızı giriniz:"); 
string kadi = Console.ReadLine();

Console.WriteLine("Lütfen şifrenizi giriniz:");
string ksifre = Console.ReadLine();




for (int i = 0; i < kullaniciAdlari.Length; i++)
{
    if (kullaniciAdlari[i] == kadi)
    {
        if (kullaniciSifre[i] == ksifre)
        {
            Console.WriteLine("Giriş başarılı!");
            break;
        }
        else
        {
            Console.WriteLine("Şifre yanlış!");
            break;
        }
    }

}


