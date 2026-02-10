using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ornekler10Subat
{
    public partial class KisiselBilgiler : Form
    {
        public string KullaniciAdi { get; set; }

        public KisiselBilgiler(string kullaniciBilgi)
        {
            InitializeComponent();
            lblKullaniciAdi.Text = kullaniciBilgi;
        }

        private void KisiselBilgiler_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = KullaniciAdi;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
