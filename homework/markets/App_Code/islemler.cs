using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;


public class islemler
{
    string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=market; integrated security=true";
	public islemler()
	{
		
	}
    public DataTable urun_getir(string urun)
    {
        string sql = "select u.urun,k.kategori,r.reyon,u.dolap,u.raf " +
                   "from urunler u , reyonlar r , kategoriler k  " +
                   "where k.reyon_no=r.reyon_no and k.kategori_no=u.kategori_no and " +
                   "u.urun like '%" + urun + "%' ";
        SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        return t;

    }
}