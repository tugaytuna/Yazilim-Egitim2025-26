Console.WriteLine("Öğrenciler Listesi Uygulaması");


// Kullanıcıya soru sorulacak
// 3 farklı cevap - 1 öğrencileri listele - 2 öğrenci ekle - 3 çıkış yap

List<string> ogrenciler = new List<string>();
int secim;


do {

    Console.WriteLine("Öğrencileri listelemek için '1'e bas");
    Console.WriteLine("Öğrenci eklemek için '2'ye bas");
    Console.WriteLine("Çıkış yapmak için '3'e bas");


    secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.WriteLine("Öğrenciler listeleniyor....");
            foreach (string ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }
            break;
        case 2:
            Console.WriteLine("Öğrencinin adını giriniz:");
            string yeniOgrenci = Console.ReadLine();
            ogrenciler.Add(yeniOgrenci);
            break;
        default:
            Console.WriteLine("Hatalı tuşlama yaptınız!");
            break;

    }



} while (secim != 3); // seçim 3 olmadığı sürece çalışsın



Console.WriteLine("Uygulamamızı umarım beğenmişsinizdir. İyi günler.");