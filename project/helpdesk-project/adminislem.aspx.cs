using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class adminislem : System.Web.UI.Page
{
    string bagcum = "data source=1208-BILGISAYAR\\SQLEXPRESS; initial catalog=projemiz; integrated security=true";
    islemlerimiz i = new islemlerimiz();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string sql = "select dp.dp_ad, at.alan from destek_personel dp, alan_turleri at where at.alan_no=dp.alan_no";
            i.listele(gvDestek, sql);
            string sql_sorun = "select k.kul_adi, p.problem from kullanicilar k, problemler p where k.kul_no=p.kul_no";
            i.listele(gvSorun, sql_sorun);
        }
    }


    protected void gvSorun_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbSecKul.Text = gvSorun.SelectedRow.Cells[1].Text;
        tbSorun.Text = gvSorun.SelectedRow.Cells[2].Text;
    }

    protected void gvDestek_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbPersonel.Text = gvDestek.SelectedRow.Cells[1].Text;
    }

    protected void btGonder_Click(object sender, EventArgs e)
    {
        lbAciklama.Text = "Sorun Personele Gönderildi";
    }

    protected void btCikis_Click(object sender, EventArgs e)
    {
        Response.Redirect("giris.aspx");
    }
}