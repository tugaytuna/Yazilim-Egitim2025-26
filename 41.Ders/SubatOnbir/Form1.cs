using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubatOnbir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Roman");
            //comboBox1.Items.Add("Bilim Kurgu");
            //comboBox1.Items.Add("Biyografi");
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

            foreach (Kitap kt in kitapListesi)
            {
                comboBox1.Items.Add(kt);
                listBox1.Items.Add(kt);
                
            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());
            Kitap secilenKitap = comboBox1.SelectedItem as Kitap;

            MessageBox.Show(secilenKitap.KitapYazar);
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kitap secilenListItem = listBox1.SelectedItem as Kitap;
            lblBilgi.Text = "Kitabın Yazarı: " + secilenListItem.KitapYazar;
            lblBilgi2.Text = "Kitabın Basım Yılı: " +  secilenListItem.YayınTarihi.Year.ToString();
        }
    }
}
