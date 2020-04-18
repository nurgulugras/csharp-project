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
    islemler islemim = new islemler();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btgiris_Click(object sender, EventArgs e)
    {
        string kul, sifre;
        kul = tbkul.Text;
        sifre = tbsif.Text;
        DataTable t = new DataTable();
        t = islemim.kullanici_kontrol(kul, sifre);
        if (t.Rows.Count > 0)
        {
            Session["ogrno"] = t.Rows[0][0].ToString();
            Session["isim"] = t.Rows[0][1].ToString();
            Response.Redirect("ders.aspx");

        }
        else
            Label3.Text = "Geçersiz Kullanıcı!!";
    }
}