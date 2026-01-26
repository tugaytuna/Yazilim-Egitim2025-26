namespace IlkFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<string> adminler = new List<string>() { "tugay", "tuna" };

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string isim = "";
            isim = txtKullaniciAdi.Text;

            bool bulundu = false;

            foreach (string item in adminler)
            {
                if (item == isim)
                {
                    MessageBox.Show("Admin Hoþ Geldin");
                    bulundu = true;
                    break;
                }
            }

            if (!bulundu)
            {
                MessageBox.Show("Kullanýcý Hoþ Geldin");
            }

        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            string yeniAdmin = "";
            yeniAdmin = txtKullaniciAdi.Text;
            adminler.Add(yeniAdmin);
            MessageBox.Show("Admin eklendi!");
        }
    }
}
