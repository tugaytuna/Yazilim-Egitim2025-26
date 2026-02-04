using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            public string ProfilePic { get; set; }
        }


        List<Kullanici> kullanicilar = new List<Kullanici>() { new Kullanici() { KullaniciAdi = "tugay", KullaniciSifre = "1234", Meslek = "Öğretmen", ProfilePic = "https://plus.unsplash.com/premium_photo-1689977807477-a579eda91fa2?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" }, new Kullanici() { KullaniciAdi = "samet", KullaniciSifre = "5432", Meslek = "Öğrenci", ProfilePic = "https://plus.unsplash.com/premium_photo-1693258698597-1b2b1bf943cc?q=80&w=687&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" } };

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
                    pictureBox1.ImageLocation = user.ProfilePic;
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
        void kayitKontrol()
        { 
            uyariMesaji = "";
            //variable = (condition) ? expressionTrue :  expressionFalse;
            uyariMesaji = chbKullaniciSozlesme.Checked ? uyariMesaji : "Lütfen kullanıcı sözleşmesini kabul edin.";
            uyariMesaji = (txtYeniSifre.Text == txtYeniSifreTekrar.Text) ? uyariMesaji : "Girdiğiniz şifreler aynı değil!";
            uyariMesaji = (!radioButton1.Checked && !radioButton2.Checked) ? "Lütfen mesleğinizi giriniz!" : uyariMesaji;
            uyariMesaji = (txtYeniKullaniciAdi.Text == "") ? "Kullanıcı adı boş bırakamazsınız" : uyariMesaji;
            uyariMesaji = (txtYeniSifre.Text.Length < 4) ? "Şifreniz en az 4 karakter olmalıdır!" : uyariMesaji;
                      
        }

        string uyariMesaji = "";

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();
            kayitKontrol();
            if (uyariMesaji == "")
            {
                yeniKullanici.KullaniciAdi = txtYeniKullaniciAdi.Text;
                yeniKullanici.KullaniciSifre = txtYeniSifre.Text;

                yeniKullanici.Meslek = radioButton1.Checked ? "Öğrenci" : "Öğretmen";
                yeniKullanici.ProfilePic = txtProfilePic.Text;

                kullanicilar.Add(yeniKullanici);
                MessageBox.Show("Kullanıcı başarıyla oluşturuldu.");
                Temizle();
            }
            else
            {
                MessageBox.Show(uyariMesaji);
            }

            //if (chbKullaniciSozlesme.Checked)
            //{
            //    if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
            //    {
            //        yeniKullanici.KullaniciAdi = txtYeniKullaniciAdi.Text;
            //        yeniKullanici.KullaniciSifre = txtYeniSifre.Text;

            //        if (radioButton1.Checked)
            //        {
            //            yeniKullanici.Meslek = "Öğrenci";
            //            kullanicilar.Add(yeniKullanici);
            //            MessageBox.Show("Kullanıcı başarıyla oluşturuldu.");
            //            Temizle();
            //        }
            //        else if (radioButton2.Checked)
            //        {
            //            yeniKullanici.Meslek = "Öğretmen";
            //            kullanicilar.Add(yeniKullanici);
            //            MessageBox.Show("Kullanıcı başarıyla oluşturuldu.");
            //            Temizle();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Lütfen mesleğinizi giriniz!");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Girdiğiniz şifreler aynı değil!");
            //        txtYeniSifre.Text = "";
            //        txtYeniSifreTekrar.Text = "";
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen kullanıcı sözleşmesini kabul edin.");
            //}
        }
        private void btnCikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            btnCikis.Visible = false;
            MessageBox.Show("Çıkış yapıldı!");
            pictureBox1.ImageLocation = "https://picsum.photos/200/200";
            //pictureBox1.Image.Dispose();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("F:\\Development\\Yazilim-Egitim2025-26\\34.Ders\\Resources\\okul2.jpg");
            //pictureBox1.ImageLocation = "F:\\Development\\Yazilim-Egitim2025-26\\34.Ders\\Resources\\okul2.jpg";
            //pictureBox1.ImageLocation = "https://images.unsplash.com/photo-1761839259112-aaea03db3633?q=80&w=1170&auto=format&fit=crop&ixlib=rb-4.1.0&ixid=M3wxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D";
            pictureBox1.ImageLocation = "https://picsum.photos/200/200";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                lblProfilePic.Visible = true;
                txtProfilePic.Visible = true;
            }
            else
            {
                lblProfilePic.Visible = false;
                txtProfilePic.Visible = false;
            }
            
        }

        //string selectedImage = "";

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                DialogResult result = openFileDialog1.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    //selectedImage = openFileDialog1.FileName;
                    txtProfilePic.Text = openFileDialog1.FileName;
                }
            }
        }

        
    }
}
