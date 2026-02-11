using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler10Subat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + " yaşındayım.";
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "tugay")
            {
                string msg = "Kullanıcı detaylarını görmek ister misiniz?";
                string msg_baslik = "Giriş Yapıldı: " + txtKullaniciAdi.Text;

                DialogResult result = MessageBox.Show(msg, msg_baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        

                if (result == DialogResult.Yes)
                {
                    KisiselBilgiler kisiselBilgilerForm = new KisiselBilgiler(txtKullaniciAdi.Text);
                    kisiselBilgilerForm.KullaniciAdi = txtKullaniciAdi.Text;
                   
                    DialogResult formResult = kisiselBilgilerForm.ShowDialog();

                    if (formResult == DialogResult.OK)
                    {
                        MessageBox.Show("Kişisel bilgiler güncellendi!");
                    }else if (formResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("İşleminiz iptal edildi!");
                    }

                    //kisiselBilgilerForm.Show();
                    //this.Hide();
                }
                else if (result == DialogResult.No)
                {
                    txtKullaniciAdi.Text = "";
                }

            }
        }
    }
}
