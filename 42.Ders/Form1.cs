using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SubatOnbir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kitap> kitapListesi = new List<Kitap>
        {
            new Kitap
            {
                KitapID = 1,
                KitapIsim = "Suç ve Ceza",
                KitapYazar = "Fyodor Dostoyevski",
                YayınTarihi = new DateTime(1866, 1, 1)
            },
            new Kitap
            {
                KitapID = 2,
                KitapIsim = "1984",
                KitapYazar = "George Orwell",
                YayınTarihi = new DateTime(1949, 6, 8)
            },
            new Kitap
            {
                KitapID = 3,
                KitapIsim = "Kürk Mantolu Madonna",
                KitapYazar = "Sabahattin Ali",
                YayınTarihi = new DateTime(1943, 1, 1)
            },
            new Kitap
            {
                KitapID = 4,
                KitapIsim = "Sefiller",
                KitapYazar = "Victor Hugo",
                YayınTarihi = new DateTime(1862, 1, 1)
            },
            new Kitap
            {
                KitapID = 5,
                KitapIsim = "Simyacı",
                KitapYazar = "Paulo Coelho",
                YayınTarihi = new DateTime(1988, 1, 1)
            }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            listeYenile();

            dateTimePicker1.MaxDate = DateTime.Now;

            //comboBox1.Items.Add("Roman");
            //comboBox1.Items.Add("Bilim Kurgu");
            //comboBox1.Items.Add("Biyografi");
        }

        void listeYenile()
        {
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
            foreach (Kitap eleman in kitapListesi)
            {
                comboBox1.Items.Add(eleman);
                listBox1.Items.Add(eleman);
            }
            comboBox1.Text = "Seçim Yapınız...";
            txtGuncelleKitapAd.Text = "";
            txtGuncelleYazarAd.Text = "";
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());
            //Kitap secilenKitap = comboBox1.SelectedItem as Kitap;
            //MessageBox.Show(secilenKitap.KitapYazar, secilenKitap.KitapIsim);

            Kitap yeniKitap = new Kitap();
            yeniKitap.KitapID = kitapListesi.Count + 1;
            yeniKitap.KitapIsim = txtKitapAd.Text;
            yeniKitap.KitapYazar = txtYazarAd.Text;
            yeniKitap.YayınTarihi = dateTimePicker1.Value;

            kitapListesi.Add(yeniKitap);

            MessageBox.Show("Kitap başarıyla kaydedildi!");
            listeYenile();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kitap secilenListItem = listBox1.SelectedItem as Kitap;
            lblBilgi.Text = "Kitabın Yazarı: " + secilenListItem.KitapYazar;
            lblBilgi2.Text = "Kitabın Basım Yılı: " +  secilenListItem.YayınTarihi.Year.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kitap secilenCombo = comboBox1.SelectedItem as Kitap;
            txtGuncelleKitapAd.Text = secilenCombo.KitapIsim;
            txtGuncelleYazarAd.Text = secilenCombo.KitapYazar;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            Kitap seciliKitap = comboBox1.SelectedItem as Kitap;

            if (seciliKitap != null)
            {
                string guncelKitapIsim = txtGuncelleKitapAd.Text;
                string guncelYazarIsim = txtGuncelleYazarAd.Text;


                seciliKitap.KitapIsim = guncelKitapIsim;
                seciliKitap.KitapYazar = guncelYazarIsim;

                MessageBox.Show("Liste güncellendi!");
                listeYenile();
            }


         
        }
    }
}
