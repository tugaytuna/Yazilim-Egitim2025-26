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
    public partial class KullaniciAyarlari : Form
    {
        public string KullaniciSifreForm { get; set; }

        public KullaniciAyarlari(string _kullaniciAdi)
        {
            InitializeComponent();
            kullaniciAdi = _kullaniciAdi;
        }

        string kullaniciAdi = "";

        private void KullaniciAyarlari_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniciAdi;
            label2.Text = KullaniciSifreForm;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
