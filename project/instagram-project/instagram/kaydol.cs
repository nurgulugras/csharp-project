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
    public partial class kaydol : Form
    {
        islemlerim i = new islemlerim();
        public kaydol()
        {
            InitializeComponent();
        }

        private void btkaydol_Click(object sender, EventArgs e)
        {
           i.kaydol(tbkul.Text,tbsif.Text,tbadsoyad.Text,tbposta.Text);
           tbadsoyad.Text = "";
           tbsif.Text = "";
           tbposta.Text = "";
           tbkul.Text = "";
        }

       

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
           giris f2 = new giris();
            f2.Show();

            this.Hide();
        }

        private void kaydol_Load(object sender, EventArgs e)
        {

        }

   

      

       
    }
}
