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
    public partial class kesfet : Form
    {
        public kesfet()
        {
            InitializeComponent();
        }
        islemlerim i = new islemlerim();
        private void kesfet_Load(object sender, EventArgs e)
        {
           
        }

        private void tbara_TextChanged(object sender, EventArgs e)
        {
            i.ara(tbara.Text, dgkesfet);
        }

        private void dgkesfet_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string kul_adi;
            kul_adi = dgkesfet.SelectedRows[0].Cells[0].FormattedValue.ToString();
            takip t = new takip(kul_adi);
            t.ShowDialog();
        }
        
      
    }
}
