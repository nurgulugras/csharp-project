using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public class islem
{
    string bcum = "provider=Microsoft.Jet.OleDb.4.0; data source=C:\\proje.mdb";
	public islem()
	{
		
	}
    public void ogrencileri_getir(GridView gv)
    {
        string sql;
        sql = "select * from ogrenciler";
        OleDbDataAdapter a = new OleDbDataAdapter(sql, bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        gv.DataSource = t;
        gv.DataBind();
    }
    public void proje_ata(string sirano, string p_adi)
    {
        string sql;
        sql = "update ogrenciler set p_adi= '" + p_adi + "' where sirano=" + sirano;
        OleDbConnection b = new OleDbConnection(bcum);
        OleDbCommand k = new OleDbCommand(sql, b);
        b.Open();
        k.ExecuteNonQuery();
        b.Close();

    }
}