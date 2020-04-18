using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;


namespace instagram
{
    
    public partial class giris : Form
    {
        
        islemlerim i = new islemlerim();
        public giris()
        {
            InitializeComponent();
        }

        private void Kaydol_MouseClick(object sender, MouseEventArgs e)
        {
            giris f2 = new giris();
            f2.Close();
            kaydol f1 = new kaydol();
            f1.Show();

            this.Hide();
        }

        private void btgiris_Click(object sender, EventArgs e)
        {
            string kul, sifre;
            bool varmi;
            kul = tbkul.Text;
            sifre = tbsif.Text;
           
            varmi = i.kullanici_kontrol(kul, sifre);

            if (varmi==true)
            {
                this.Hide();
                anasayfa f3 = new anasayfa(kul, sifre);
                f3.Show();
            }
            else
            {
                label5.Text = "Kullanıcı adı ya da şifre yanlış";

            }
    
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

    }
}
