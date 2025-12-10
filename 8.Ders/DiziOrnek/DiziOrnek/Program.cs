Console.WriteLine("8.Ders!");

//
int yas = 12;
string isim = "tugay";
bool admin = false;

string ornek1 = "12";

//int ornekRakam = int.Parse(ornek1);
int ornekRakam = Convert.ToInt32(ornek1);

Console.WriteLine(ornekRakam + 10);
Console.WriteLine(isim + yas);

// Diziler - Array

string[] dizi1 = { "tugay", "tuna", "ercan", "ismail" };
int[] dizi2 = { 12, 24, 11, 2, 24, 53 };
bool[] dizi3 = { true, false, true };

Console.WriteLine(dizi1[2]);

Console.WriteLine(dizi2[4] + " " + dizi1[3]);

Console.WriteLine("Dizi1'in elemanlarının sıralanması");

//Console.WriteLine(dizi1[0]);
//Console.WriteLine(dizi1[1]);
//Console.WriteLine(dizi1[2]);
//Console.WriteLine(dizi1[3]);

foreach (string eleman in dizi1)
{
    Console.WriteLine(eleman);
}


foreach (int item in dizi2)
{
    if (item > 15)
    {
        Console.WriteLine(item + 100);
    }
    
}



