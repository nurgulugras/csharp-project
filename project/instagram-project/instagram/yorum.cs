using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace instagram
{
    public partial class yorum : Form
    {
        string kul_adi;
        string foto_id;
      
        string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=instagram; integrated security=true";
        islemlerim i = new islemlerim();
        public yorum(string kadi, string foto)
        {
            kul_adi=kadi;
            foto_id=foto;
            InitializeComponent();
        }

        private void yorum_Load(object sender, EventArgs e)
        {
          
            tbtakip.Text=anasayfa.gonderilecekveri;
            tbtakipkul.Text =kul_adi;
            tbfoto.Text =foto_id.ToString();
           
        }
        
      private void btcikart_Click(object sender, EventArgs e)
        {
            i.takip_cikart(tbtakip.Text,tbtakipkul.Text);
        }

        private void btekle_Click(object sender, EventArgs e)
        {
            i.yorum_ekle(rtbyorum.Text,tbtakip.Text,tbfoto.Text);
        }
    }
}
