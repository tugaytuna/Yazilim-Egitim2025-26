using System.Xml;

Console.WriteLine("Uygulamaya hoş geldiniz");


Console.WriteLine("Lütfen adınızı giriniz:");
string kisim = Console.ReadLine();



Console.WriteLine("Hoşgeldin " + kisim);


Console.WriteLine("Lütfen yaşınızı giriniz:");
//int yas = int.Parse(Console.ReadLine());
int yas = Convert.ToInt32(Console.ReadLine());



if (yas >= 18)
{
    Console.WriteLine("Uygulamaya giriş yapabilirsiniz!");
}
else if (kisim == "tugay")
{
    Console.WriteLine("Tugay bey 18 yaşından küçük olsanız da girebilirsiniz.");
}
else
{
    Console.WriteLine("Yaşınız küçük olduğu için giriş yapamazsınız!");
}

//debug
//bug
bool admin = false;

if (kisim == "tuna" && yas == 99)
{
    admin = true;
}
else
{
    admin = false;
}

if (admin)
{
    Console.WriteLine("Admin giriş yaptı. Bundan sonraki tüm güvenlik önlemleri devredışı.");
}





