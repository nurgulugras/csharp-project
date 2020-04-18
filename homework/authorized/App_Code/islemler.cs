using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class islemler
{
    string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog= okul; integrated security=true";
	public islemler()
	{
		
	}
    public int kullanici_kontrol(string kul, string sifre)
    {
        string sql;
        sql = "select * from kullanicilar where k_adi='"+kul+"' and sifre='"+sifre+"'";
        SqlDataAdapter a= new SqlDataAdapter(sql,bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        if(t.Rows.Count>0)
            return Convert.ToInt32(t.Rows[0][0]);
        else
            return 0;
    }

    public DataTable menu_getir(int kulno)
    {
        string sql;
        sql = "select m.menu_adi from menular m,kul_menu km where m.menuno=km.menuno and km.kulno="+kulno.ToString();
        SqlDataAdapter a=new SqlDataAdapter(sql,bcum);
        DataTable t = new DataTable();
        a.Fill(t);
        return t;
    }
}
