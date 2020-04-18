using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for yolculuk
/// </summary>

public class yolculuk
{
    string bcum= "data source= ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=bilet; integrated security=true";
	public yolculuk()
	{
		
	}
    public void durak_getir(DropDownList ddl)
    {
        string sql = "select * from duraklar order by durak";
        SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        ddl.DataSource = t;
        ddl.DataTextField = "durak";
        ddl.DataValueField = "durakno";
        ddl.DataBind();
    }
    public void sefer_ara(GridView gv, string nereden, string nereye, string tarih)
    {
        string sql = "select s.seferno , nereden.durak, nereye.durak, s.nezaman,s.kacta " +
            "from seferler s, duraklar nereden, duraklar nereye " +
            "where s.nereden=nereden.durakno and " +
            "s.nereye=nereye.durakno and " +
            "s.nezaman='" + tarih + "' and " +
            "s.nereden= " + nereden + " and " +
            "s.nereye=" + nereye;
        SqlDataAdapter a = new SqlDataAdapter(sql, bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        gv.DataSource = t;
        gv.DataBind();
    }

}