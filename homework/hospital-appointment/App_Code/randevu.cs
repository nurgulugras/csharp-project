using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;


public class randevu
{
    string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=hastane; integrated security=true";
	public randevu()
	{
		
	}
    public void listboxalistele(ListBox lb, string sql)
    {
        SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        lb.DataSource = t;
        lb.DataTextField = t.Columns[1].ColumnName;
        lb.DataValueField = t.Columns[0].ColumnName;
        lb.DataBind();
    }
    public void randuvual(string tc, string isim, string doktorno, string tarih, string saatno)
    {
        string sql = "insert into randevular(tc,isim,doktorno,tarih,saatno) " +
            "values('" + tc + "' , '" + isim + "' , '" + doktorno + "' , '" + tarih + "' , " + saatno + ")"; 
        SqlConnection b = new SqlConnection(bcum);
        SqlCommand k = new SqlCommand(sql, b);
        b.Open();
        k.ExecuteNonQuery();
        b.Close();
    }
    public void rand_listele(GridView gv)
    {
        string sql;
        sql = "select r.tc , r.isim , p.poladi , d.doktor , r.tarih , s.saat " +
            "from poller p , doktorlar d , saatler s , randevular r " +
            "where p.polno=d.polno and r.doktorno=d.doktorno " +
            " and r.saatno=s.saatno ";
        SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        gv.DataSource = t;
        gv.DataBind();
    }
}