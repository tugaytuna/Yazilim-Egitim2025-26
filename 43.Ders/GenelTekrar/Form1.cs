using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        Kullanici kullanici1 = new Kullanici();
        Kullanici kullanici2 = new Kullanici();

        Ogretmen ogretmen1 = new Ogretmen();

        List<Kullanici> kullanicilar = new List<Kullanici>();
        List<Ogretmen> ogretmenler = new List<Ogretmen>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            kullanici1.KullaniciID = 1;
            kullanici1.KullaniciAdi = "tugay";
            kullanici1.KullaniciSifre = "1234";

            kullanici2.KullaniciID = 2;
            kullanici2.KullaniciAdi = "samet";
            kullanici2.KullaniciSifre = "1234";

            


            kullanicilar.Add(kullanici1);
            kullanicilar.Add(kullanici2);

        }




        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // listedeki elemanların tipi
            // istediğim bir değişken adı 
            // in
            // listenin adı
            foreach (Kullanici user in kullanicilar)
            {
                if (txtKullaniciAdi.Text == user.KullaniciAdi && txtSifre.Text == user.KullaniciSifre)
                {
                    // Kullanıcı bilgilendirmesi
                    MessageBox.Show("Giriş yapıldı!");
                    // Giriş yap ekranının gizlenmesi
                    grpGirisYap.Visible = false;
                    // Düzenle butonunun gözükmesi
                    btnDuzenle.Visible = true;
                    // Aşağıdaki checkbox'ın yukarı gelmesi.
                    checkBox1.Location = new Point(100, 12);


                    user.BilgiGoster();
                }
            }          
            
            // Tek bir liste üzerinden giriş yapma örneği.
            //if (txtKullaniciAdi.Text == kullanici1.KullaniciAdi && txtSifre.Text == kullanici1.KullaniciSifre)
            //{
            //    MessageBox.Show("Giriş yapıldı!");
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                grpGirisYap.Visible = false;
                checkBox1.Location = new Point(100, 12);

            }
            else if (checkBox1.Checked == false)
            {
                grpGirisYap.Visible = true;
                checkBox1.Location = new Point(100, 250);

            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            KullaniciAyarlari kullaniciForm = new KullaniciAyarlari(txtKullaniciAdi.Text);
            kullaniciForm.KullaniciSifreForm = txtSifre.Text;

            
            DialogResult result = kullaniciForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                // ok ise
                lblAciklama.ForeColor = Color.Green;
                lblAciklama.Text = "Kullanıcı başarıyla güncellendi";
            }else if (result == DialogResult.Cancel)
            {
                // cancel ise
                lblAciklama.ForeColor = Color.Red;
                lblAciklama.Text = "Kullanıcı silindi!";
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "tugay";
            txtSifre.Text = "1234";
        }
    }
}





//txtKullaniciAdi.Text == "samet"