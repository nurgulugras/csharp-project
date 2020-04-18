using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;


public class islemler
{
    string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=pusula; integrated security=true";
	public islemler()
	{
		
	}

    public DataTable kullanici_kontrol(string kul, string sifre)
    {
        string sql;
        sql = "select * from ogrenciler where kul_adi='" + kul + "' and sifre='" + sifre + "'";
        SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        return t;
    }
    
    public void ders_listele(string ogr_no, GridView gv, char c)
    {
        string sql;
        sql = "select * from dersler where dno ";
        if (c == 'a')
            sql = sql + "not ";
        sql = sql + "in (select dno from ogr_ders where ogr_no=" + ogr_no + ")";
        SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        gv.DataSource = t;
        gv.DataBind();
   }

    public void ekle_sil(string ogr_no, string dno, char c )

   {
       string sql;
        if(c == 'e'){
            sql = "insert into ogr_ders(ogr_no,dno) values(" + ogr_no + ", " + dno + ")";
        }else
            sql= "delete from ogr_ders where ogr_no="+ogr_no+" and dno="+dno;
        SqlConnection b = new SqlConnection(bcum);
        SqlCommand k = new SqlCommand(sql, b);
        b.Open();
        k.ExecuteNonQuery();
        b.Close();
    }
       

   

}