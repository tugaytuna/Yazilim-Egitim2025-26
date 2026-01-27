namespace FormUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> adminler = new List<string>() { "tugay", "tuna" };

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            bool bulundu = false;

            foreach (string item in adminler)
            {
                if (kullaniciAdi == item)
                {
                    MessageBox.Show("Admin Hoþ Geldin!");
                    bulundu = true;
                    break;
                }
            }

            if (!bulundu)
            {
                MessageBox.Show(kullaniciAdi + " Hoþ Geldiniz!");
            }
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            adminler.Add(kullaniciAdi);
            MessageBox.Show("Admin eklendi!");
        }

    }
}
