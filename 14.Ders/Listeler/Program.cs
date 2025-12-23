Console.WriteLine("Listeler");

string isim = "tugay";
int sayi1 = 22;

// 1. Yöntem
//int[] dizi1 = new int[2];
//dizi1[0] = 15;
//dizi1[1] = sayi1;

// 2. Yöntem
int[] dizi1 = { 15, sayi1 };

foreach (int eleman in dizi1)
{
    Console.WriteLine(eleman);
}

for (int i = 0; i < dizi1.Length; i++)
{
    Console.WriteLine(dizi1[i]);
}

Console.WriteLine(dizi1[0]);