Console.WriteLine("Switch Örnekler");



string sifre = "";

do
{
    Console.WriteLine("Lütfen şifreyi giriniz:");
    sifre = Console.ReadLine();
   
    
} while (sifre != "1234");


int sayi1 = 20;

Console.WriteLine("Sayımız: " + sayi1);
Console.WriteLine("2 ile çarpmak için '1'e basın");
Console.WriteLine("50 ile toplamak için '2'e basın");
Console.WriteLine("2'ye bölmek için '3'e basın");

string secim = Console.ReadLine();


//if (secim == "1")
//{
//    Console.WriteLine(sayi1 * 2);
//}else if (secim == "2")
//{
//    Console.WriteLine(50 + sayi1);
//}else if (secim == "3")
//{
//    Console.WriteLine(sayi1 / 2);
//}else
//{
//    Console.WriteLine("Hatalı tuşlama yaptınız!");
//}

switch (secim)
{
    case "1":
        Console.WriteLine(sayi1 * 2);
        break;
    case "2":
        Console.WriteLine(50 + sayi1);
        break;
    case "3":
        Console.WriteLine(sayi1 / 2);
        break;
    case "4":
        Console.WriteLine(sayi1 * sayi1);
        break;
    default:
        Console.WriteLine("Hatalı tuşlama yaptınız!");
        break;
}




