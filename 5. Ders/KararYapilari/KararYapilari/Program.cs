Console.WriteLine("5. Derse Hoş Geldiniz!");

Console.WriteLine("Karar Yapıları");

string isim1 = "tugay";
string isim2 = "izel";

int yas = 20;


Console.WriteLine(isim1 + " " + yas);

// degisken tipi - degiskenismi - = degeri ;
bool admin = false; // doğru
bool uygun = true; // yanlış

yas = 25;

if (yas > 18)
{
    Console.WriteLine("18 yaşından büyüksün!");
}
else
{
    Console.WriteLine("18 yaşından küçüksünüz!");
}





if (isim1 == "tugaytuna") 
{
    Console.WriteLine("Hoşgeldin admin!");
}else
{
    Console.WriteLine("Hoşgeldin misafir kullanıcı");
    isim1 = "misafir";
}
