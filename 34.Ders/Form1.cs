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
            public string Meslek { get; set; }
        }


        List<Kullanici> kullanicilar = new List<Kullanici>() { new Kullanici() { KullaniciAdi = "tugay", KullaniciSifre = "1234", Meslek = "Öğretmen" }, new Kullanici() { KullaniciAdi = "samet", KullaniciSifre = "5432", Meslek="Öğrenci" } };

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
                    btnCikis.Visible = true;
                    Temizle();
                    //this.Close();
                }
            }

        }


        public void Temizle()
        {
            //giriş yap
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";

            // yeni kayıt
            radioButton1.Checked = false;
            radioButton2.Checked = false;
           

            txtYeniKullaniciAdi.Text = "";
            //txtYeniKullaniciAdi.Text = string.Empty;
            //txtKullaniciAdi.Clear();
            txtYeniSifre.Text = "";
            txtYeniSifreTekrar.Text = "";
            chbKullaniciSozlesme.Checked = false;
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();

            if (chbKullaniciSozlesme.Checked)
            {
                if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                {
                    yeniKullanici.KullaniciAdi = txtYeniKullaniciAdi.Text;
                    yeniKullanici.KullaniciSifre = txtYeniSifre.Text;

                    if (radioButton1.Checked)
                    {
                        yeniKullanici.Meslek = "Öğrenci";
                        kullanicilar.Add(yeniKullanici);
                        MessageBox.Show("Kullanıcı başarıyla oluşturuldu.");
                        Temizle();
                    }
                    else if (radioButton2.Checked)
                    {
                        yeniKullanici.Meslek = "Öğretmen";
                        kullanicilar.Add(yeniKullanici);
                        MessageBox.Show("Kullanıcı başarıyla oluşturuldu.");
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen mesleğinizi giriniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler aynı değil!");
                    txtYeniSifre.Text = "";
                    txtYeniSifreTekrar.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı sözleşmesini kabul edin.");
            }
        }

        private void btnCikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            btnCikis.Visible = false;
            MessageBox.Show("Çıkış yapıldı!");

            //pictureBox1.Image.Dispose();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\izel\\source\\repos\\tugaytuna Yazilim-Egitim2025-26 main 33.Ders-FormUygulamalari\\Resources\\okul2.jpg");

        }
    }
}
