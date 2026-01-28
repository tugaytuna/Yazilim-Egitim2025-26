using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Font = new Font("Microsoft Sans Serif", 30);
        }

        public class Kullanici
        {
            public string KullaniciAdi { get; set; }
            public string KullaniciSifre { get; set; }
        }


        List<Kullanici> kullanicilar = new List<Kullanici>() { new Kullanici() { KullaniciAdi = "tugay", KullaniciSifre = "1234" }, new Kullanici() { KullaniciAdi = "samet", KullaniciSifre = "5432" } };

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            foreach (Kullanici user in kullanicilar)
            {
                if (kullaniciAdi == user.KullaniciAdi && sifre == user.KullaniciSifre)
                {
                    MessageBox.Show("Giriş Yapıldı!");
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                    //this.Close();
                }
            }

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();

            if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            {
                yeniKullanici.KullaniciAdi = txtYeniKullaniciAdi.Text;
                yeniKullanici.KullaniciSifre = txtYeniSifre.Text;
                kullanicilar.Add(yeniKullanici);
                MessageBox.Show("Kullanıcı başarıyla oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifreler aynı değil!");
            }
            
        }
    }
}
