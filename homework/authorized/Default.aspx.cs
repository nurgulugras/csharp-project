using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog= okul; integrated security=true";
    islemler i = new islemler();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btgiris_Click(object sender, EventArgs e)
    {
        string kul, sifre;
        int kulno;
        kul = tbkul.Text;
        sifre = tbsifre.Text;
        kulno = i.kullanici_kontrol(kul, sifre);
        if(kulno != 0)
        {
            Session["kulno"] = kulno;
            Response.Redirect("yetkili.aspx");
        }else
        {
            Label1.Text="Geçersiz Kullanıcı!!";
        }

    }
}