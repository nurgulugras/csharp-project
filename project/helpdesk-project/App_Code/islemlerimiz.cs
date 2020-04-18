using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public class islemlerimiz
{
    string bagcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=projemiz; integrated security=true";
    public islemlerimiz()
    { }
       public int  kullanici_kontrol(string kul, string sifre)
    {
        string sql;



        sql = "select * from kullanicilar where kul_adi='" + kul + "' and sifre='" + sifre + "'";
       
         sql =  "select * from destek_personel where dp_ad='" + kul + "' and sifre='" + sifre + "'";
          
        SqlDataAdapter a = new SqlDataAdapter(sql, bagcum);
      
        DataTable t = new DataTable();
        a.Fill(t);
        if (t.Rows.Count > 0)
            return Convert.ToInt32(t.Rows[0][0]);
        else
            return 0;
       
        
            
    }

    public void listele(GridView gv, string sql)
    {
        SqlDataAdapter a = new SqlDataAdapter(sql, bagcum);
        DataTable t = new DataTable();
        a.Fill(t);
        gv.DataSource = t;
        gv.DataBind();
    }
    }


