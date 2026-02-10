using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGenel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Kullanici
        {
            public int KullaniciID { get; set; }
            public string KullaniciAdi { get; set; }
            public Color Renk { get; set; }
        }

        Kullanici kullanici1 = new Kullanici() { KullaniciID = 1, KullaniciAdi = "tugay", Renk = Color.Khaki };
        Kullanici kullanici2 = new Kullanici() { KullaniciID = 2, KullaniciAdi = "samet", Renk = Color.Sienna };

        List<Kullanici> kullaniclar = new List<Kullanici>();

        int loginUserId = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            kullaniclar.Add(kullanici1);
            kullaniclar.Add(kullanici2);


        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            //if (progressBar1.Value < 100)
            //{
            //    progressBar1.Value += 10;
            //}

            

            //for (int i = 0; i <= progressBar1.Maximum; i++)
            //{
            //    progressBar1.Value = i;
            //}

            //progressBar1.Value = (progressBar1.Maximum / 2);
            progressBar1.Value = 50;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                groupBox1.BackColor = colorDialog1.Color;
                Kullanici loginUser = kullaniclar.Find(item => item.KullaniciID == loginUserId);

                if (loginUser != null)
                {
                    loginUser.Renk = colorDialog1.Color;
                }
                
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Hiçbir renk seçilmedi!");
            }

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            foreach (Kullanici user in kullaniclar)
            {
                if (user.KullaniciAdi == txtIsim.Text)
                {
                    groupBox1.BackColor = user.Renk;
                    loginUserId = user.KullaniciID;
                }
            }
        }
    }
}
