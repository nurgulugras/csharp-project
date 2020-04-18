using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections;



namespace instagram
{
   
    class islemlerim
    {
        
        string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=instagram; integrated security=true";

        public islemlerim()
        { 
        }
        public void yorum_ekle(string yorum,string kul_adi,string foto)
        {
            string sql = "insert into yorumlar(yorum,kul_adi,foto_id) values('" + yorum + "' ,'" + kul_adi + "'," + foto + ")";
            sql = sql + " " + "update fotograflar set yorum='" + kul_adi + " " + yorum + "'  where foto_id=" + foto;
            SqlConnection b = new SqlConnection(bcum);
            SqlCommand k = new SqlCommand(sql, b);
            b.Open();
            k.ExecuteNonQuery();
            MessageBox.Show("Yorumunuz Eklendi.");
            b.Close();
        }
       
        public void takip_cikart(string takip,string takip_e)
        {
            string sql = "delete from takipciler where takip_eden= '" + takip + "' and takip_edilen= '" + takip_e + "'";
            SqlConnection b = new SqlConnection(bcum);
            SqlCommand k = new SqlCommand(sql, b);
            b.Open();
            k.ExecuteNonQuery();
            MessageBox.Show("Takipten Çıkarttınız.");
            b.Close();
        }
        public void takip(string takip_eden,string takip_edilen)
        {
            string sql = "insert into takipciler(takip_eden,takip_edilen) values('" + takip_eden + "','" + takip_edilen + "')";
            SqlConnection b = new SqlConnection(bcum);
            SqlCommand k = new SqlCommand(sql, b);
            b.Open();
            k.ExecuteNonQuery();
            MessageBox.Show("Takip Ediyorsunuz.");
            b.Close();
        }
       
        public void ara(string kriter,DataGridView dg)
        {
            string sql = "select kul_adi[Kullanıcı Adı:],adi_soyadi[Adı Soyadı:],internet_sitesi[İnternet Sitesi],biyografi[Biyografi] from kullanicilar " +
                         "where (kul_adi like '%" + kriter + "%' or " +
                         "adi_soyadi like '%" + kriter + "%')";
            SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
            DataTable t = new DataTable();
            a.Fill(t);
            dg.DataSource = t;
        }
      
       public bool kullanici_kontrol(string kul, string sifre)
        {

            string sql = "select * from kullanicilar where kul_adi='" + kul + "' and sifre='" + sifre + "'";
            SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
            DataTable t = new DataTable();
            a.Fill(t);
            if (t.Rows.Count > 0)
                return true;
            else
                return false;

        }
       public void kaydol(string kul_adi, string sifre, string adi_soyadi, string email)
        {
            string sql = "insert into kullanicilar(kul_adi,sifre,adi_soyadi,email) values('" + kul_adi + "','" + sifre + "','" + adi_soyadi + "','" + email + "')";
            SqlConnection b = new SqlConnection(bcum);
            SqlCommand k = new SqlCommand(sql, b);
            b.Open();
            k.ExecuteNonQuery();
            MessageBox.Show("Kayıt İşleminiz Gerçekleşmiştir.");
            b.Close();

        }
    
    }
}
