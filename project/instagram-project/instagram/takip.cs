using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instagram
{
    public partial class takip : Form
    {
        string kul_adi;
        islemlerim i = new islemlerim();
        public takip(string kadi)
        {

            kul_adi = kadi;
            InitializeComponent();
        }

        private void takip_Load(object sender, EventArgs e)
        {
            tbgelenkul.Text = anasayfa.gonderilecekveri;
            tbtakipkul.Text = kul_adi;
        }

        private void bttakip_Click(object sender, EventArgs e)
        {
            i.takip(tbgelenkul.Text, tbtakipkul.Text);
        }
    }
}
