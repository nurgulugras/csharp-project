using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class giris : System.Web.UI.Page
{
    string bagcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=projemiz; integrated security=true";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    

    protected void btGiris_Click(object sender, EventArgs e)
    {
        if (tbKul.Text == "admin" && tbSif.Text == "123")
        { Response.Redirect("adminislem.aspx");
    }
    else{
    string kul, sifre;
    int kul_no;
    int dp_no;
    int tip;
    islemlerimiz i = new islemlerimiz();
    kul = tbKul.Text;
    sifre = tbSif.Text;


    kul_no = i.kullanici_kontrol(kul, sifre);
    dp_no = i.kullanici_kontrol(kul, sifre);
    DataTable t = new DataTable();
    tip = tipgetir(kul_no);
    if (tip == 1)
    {
        Session["kulno"] = kul_no;
        Response.Redirect("kullanici.aspx");
    }
    else if (tip == -1 )
    {

        Session["perno"] = dp_no;
        Response.Redirect("personel.aspx");
    }

    else
    {
        lbUyari.Text = "Geçersiz Kullanıcı!";
    }
    }
    }
    int tipgetir(int kul_no)
    {
        string sql = "select kul_tipi from kullanicilar " +
             " where kul_no= " + kul_no;
        SqlDataAdapter a = new SqlDataAdapter(sql, bagcum);
        DataTable t = new DataTable();
        a.Fill(t);
        if (t.Rows.Count > 0)
        {
            return Convert.ToInt32(t.Rows[0][0]);
        }
        else
        {
            return 0;
        }


    }


}
            
    

            

      