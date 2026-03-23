namespace KitapDB.Models
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string Isim { get; set; }
        public string Yazar { get; set; }
        public string Tur{ get; set; }
        public string YayınEvi { get; set; }
        public int SayfaSayisi{ get; set; }
        public bool Okundu { get; set; }

    }
}
