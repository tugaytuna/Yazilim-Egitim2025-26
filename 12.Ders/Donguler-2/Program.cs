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



int girisBasarili = 0;
for (int i = 0; i < kullaniciAdlari.Length; i++)
{
    if (kullaniciAdlari[i] == kadi)
    {
        if (kullaniciSifre[i] == ksifre)
        {
            Console.WriteLine("Giriş başarılı!");
            girisBasarili = 2;
            break;
        }
        else
        {
            girisBasarili = 1;
            break;
        }

    }
    else
    {
        girisBasarili = 3;
        
    }

}


if(girisBasarili == 3)
{
    Console.WriteLine("Kullanıcı adı yanlış!");
}else if (girisBasarili == 1) {
    Console.WriteLine("Şifre yanlış!");
}