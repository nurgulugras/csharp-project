using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace instagram
{
    public partial class profil : Form
    {
        string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=instagram; integrated security=true";

        islemlerim i = new islemlerim();
        public profil()
        {
            InitializeComponent();
        }

        private void profil_Load(object sender, EventArgs e)
        {


            lbkuladi.Text = anasayfa.gonderilecekveri;



            string sql = "select foto[Fotoğraflarım:],foto_id,foto_aciklama[Açıklamalar:],yorum[Yorumlar:] from fotograflar where kul_adi = '" + lbkuladi.Text + "'";

            SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
            DataTable t = new DataTable();
            a.Fill(t);
            dgprofilim.DataSource = t;



            for (int i = 0; i < dgprofilim.Columns.Count; i++)
                if (dgprofilim.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgprofilim.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            foreach (DataGridViewRow row in dgprofilim.Rows)
            {
                row.Height = 80;
            }

            dgprofilim.Columns[1].Visible = false;
            
        }

    }
}
