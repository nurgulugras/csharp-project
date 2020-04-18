using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace instagram
{
    public partial class anasayfa : Form
    {
       
       

        islemlerim islem = new islemlerim();
        string kul, sifre;

        
        public anasayfa(string kul_adi, string sif)
        {
            kul = kul_adi;
            sifre = sif;
            InitializeComponent();
        }
        public anasayfa()
        {
            InitializeComponent();
        }
        string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=instagram; integrated security=true";
        public static string gonderilecekveri;
   

        private void anasayfa_Load(object sender, EventArgs e)
        {
            lbkullaniciad.Text = kul;
            string sql = "select f.kul_adi[Kullanıcı Adı:],f.foto_id,f.foto[Fotoğrafı],f.foto_aciklama[Açıklaması:],f.yorum[Yorumlar] from fotograflar f, takipciler t " +
                         "where f.kul_adi=t.takip_edilen and t.takip_eden= '" + lbkullaniciad.Text + "'";

            SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
            DataTable t = new DataTable();
            a.Fill(t);
            dgtakipfoto.DataSource = t;

           for (int i = 0; i < dgtakipfoto.Columns.Count; i++)
                if (dgtakipfoto.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgtakipfoto.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            foreach (DataGridViewRow row in dgtakipfoto.Rows)
            {
                row.Height = 100;
               
            }
            dgtakipfoto.Columns[1].Visible = false;

            
        }

        private void btkesfet_Click(object sender, EventArgs e)
        {
            gonderilecekveri = lbkullaniciad.Text;
            kesfet k = new kesfet();
            k.Show();
        }

        private void btresimekle_Click(object sender, EventArgs e)
        {
            gonderilecekveri = lbkullaniciad.Text;
            resimekle f4 = new resimekle();
            f4.Show();

        }

        private void btprofil_Click(object sender, EventArgs e)
        {
            gonderilecekveri = lbkullaniciad.Text;
            profil p = new profil();
            p.Show();
        }

        private void dgtakipfoto_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gonderilecekveri = lbkullaniciad.Text;
            string kul_adi,foto_id;
            kul_adi = dgtakipfoto.SelectedRows[0].Cells[0].FormattedValue.ToString();
            foto_id = dgtakipfoto.SelectedRows[0].Cells[1].FormattedValue.ToString();
            yorum y = new yorum(kul_adi, foto_id);
            y.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris g = new giris();
            g.Show();
            this.Hide();
        }

     
    }
}

