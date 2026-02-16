using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenelTekrar
{
    internal class Kullanici
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }



        public void BilgiGoster()
        {
            MessageBox.Show(KullaniciID + " " + KullaniciAdi);
        }


    }
}
