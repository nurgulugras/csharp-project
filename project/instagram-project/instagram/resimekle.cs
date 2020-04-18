using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace instagram
{
    public partial class resimekle :Form
    {
       
        islemlerim i = new islemlerim();
        string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS;initial catalog=instagram; integrated security=true";
        string kul, sifre;
        public resimekle(string kul_adi, string sif)
        {
            kul = kul_adi;
            sifre = sif;
            InitializeComponent();
        }
        public resimekle()
        {
           
            InitializeComponent();
        }
        public static string gonder;

        private void lblogo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void btekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFileDialog = new OpenFileDialog();
            if(dlgOpenFileDialog.ShowDialog()==DialogResult.OK)
            {
                Image image = Bitmap.FromFile(dlgOpenFileDialog.FileName);
                pbResim.Image = image;
            }
           
        }
       

        private void btpaylas_Click_1(object sender, EventArgs e)
        {
             string sql = "insert into fotograflar(foto,foto_aciklama,kul_adi) values(@pic,'" + rtbAciklama.Text + "','" + lbkullanici.Text + "')";
             MemoryStream stream = new MemoryStream();

             SqlConnection b = new SqlConnection(bcum);
             SqlCommand k = new SqlCommand(sql, b);
             pbResim.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
             byte[] pic = stream.ToArray();
             k.Parameters.AddWithValue("@pic", pic);
             b.Open();
             k.ExecuteNonQuery();
             MessageBox.Show(lbkullanici.Text + " " + " Fotoğraf Paylaştınız.");
             b.Close();
            }
          
       
        private void resimekle_Load_1(object sender, EventArgs e)
        {
            lbkullanici.Text = anasayfa.gonderilecekveri;
        }
    }
}
