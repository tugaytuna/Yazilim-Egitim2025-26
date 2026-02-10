using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kullanici> kullanicilar = new List<Kullanici>();

        private void Form1_Load(object sender, EventArgs e)
        {
            kullanicilar.Add(new Kullanici { KullaniciID = 1, KullaniciIsim = "Ahmet", KullaniciSifre = "1234", MailAdresi = "ahmet@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 2, KullaniciIsim = "Mehmet", KullaniciSifre = "abcd", MailAdresi = "mehmet@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 3, KullaniciIsim = "Ayse", KullaniciSifre = "ayse123", MailAdresi = "ayse@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 4, KullaniciIsim = "Fatma", KullaniciSifre = "fatma1", MailAdresi = "fatma@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 5, KullaniciIsim = "Ali", KullaniciSifre = "ali321", MailAdresi = "ali@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 6, KullaniciIsim = "Can", KullaniciSifre = "canpass", MailAdresi = "can@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 7, KullaniciIsim = "Zeynep", KullaniciSifre = "zey123", MailAdresi = "zeynep@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 8, KullaniciIsim = "Mert", KullaniciSifre = "mert12", MailAdresi = "mert@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 9, KullaniciIsim = "Elif", KullaniciSifre = "elifpass", MailAdresi = "elif@gmail.com" });
            kullanicilar.Add(new Kullanici { KullaniciID = 10, KullaniciIsim = "Burak", KullaniciSifre = "burak99", MailAdresi = "burak@gmail.com" });

        }


        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "kullanıcı adınızı giriniz....") 
            {
                txtKullaniciAdi.Text = "";
            }
           
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "kullanıcı adınızı giriniz....";
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "sifrenizi giriniz...")
            {
                txtSifre.Text = "";
                txtSifre.PasswordChar = '*';
            }
        }

        void listBoxDoldur()
        {
            foreach (Kullanici kullanici in kullanicilar)
            {
                listBox1.Items.Add(kullanici.KullaniciIsim);
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            foreach (Kullanici eleman in kullanicilar)
            {
                if (eleman.KullaniciIsim == txtKullaniciAdi.Text && eleman.KullaniciSifre == txtSifre.Text)
                {
                    MessageBox.Show("Giriş yapıldı!");

                    listBoxDoldur();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("selected index changed çalıştı" + listBox1.SelectedItem );

            //label1.Text = listBox1.SelectedItem.ToString();

            Kullanici secilenKullanici = kullanicilar.Find(item => item.KullaniciIsim == listBox1.SelectedItem.ToString());

            label1.Text = secilenKullanici.KullaniciSifre;
        }
    }
}
