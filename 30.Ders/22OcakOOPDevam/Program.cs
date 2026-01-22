using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _22OcakOOPDevam
{
    internal class Program
    {
        public class Hayvan
        {
            public string Cinsi { get; set; }
            public int Yas { get; set; }


            public virtual void SesCıkar()
            {
                Console.WriteLine("Hayvan Sesi!");
            }


        }

        public class Kedi : Hayvan
        {
            public int KediMamaStok { get; set; }


            public override void SesCıkar()
            {
                Console.WriteLine("Miyav miyav!");
            }

        }

        public class Kopek : Hayvan
        {
            public int KopekMamaStok { get; set; }

            public override void SesCıkar()
            {
                Console.WriteLine("Hav hav!");
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Uygulamaya hoş geldiniz!");

            Hayvan hayvan1 = new Hayvan();
            hayvan1.Cinsi = "Diğer";
            hayvan1.Yas = 4;

            Kedi kedi1 = new Kedi();
            kedi1.Cinsi = "British";
            kedi1.Yas = 5;
            kedi1.KediMamaStok = 200;

            Kopek kopek1 = new Kopek();
            kopek1.Cinsi = "Golden";
            kopek1.Yas = 6;
            kopek1.KopekMamaStok = 800;

            Kedi kedi2 = new Kedi();
            kedi2.Cinsi = "Tekir";
            kedi2.Yas = 7;
            kedi2.KediMamaStok = 400;

            Hayvan hayvan2 = new Hayvan() { Cinsi = "İnek", Yas = 1 };


            List<Hayvan> hayvanlar = new List<Hayvan>();
            hayvanlar.Add(hayvan1);
            hayvanlar.Add(kedi1);
            hayvanlar.Add(kopek1);
            hayvanlar.Add(kedi2);
            hayvanlar.Add(hayvan2);




           

            foreach (Hayvan item in hayvanlar)
            {
                Console.WriteLine(item.Cinsi);
                item.SesCıkar();
            }



        }
    }
}
