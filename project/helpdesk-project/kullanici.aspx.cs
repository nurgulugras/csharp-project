using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web
    .UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class kullanici : System.Web.UI.Page
{
    string bagcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=projemiz; integrated security=true";
    islemlerimiz i = new islemlerimiz();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        { alan_listele();
        }
    }
    void alan_listele()
    {
        string sql = "select * from alan_turleri";
        SqlDataAdapter a = new SqlDataAdapter(sql, bagcum);
        DataTable t = new DataTable();
        a.Fill(t);
        ddlTur.DataSource = t;
        ddlTur.DataTextField = "alan";
        ddlTur.DataValueField = "alan_no";
        ddlTur.DataBind();
    }


    protected void ddlTur_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select p.* from kayitli_sorunlar ks, problemler p, alan_turleri at where ks.p_no=p.p_no and p.alan_no=at.alan_no and at.alan_no="+ddlTur.SelectedValue.ToString();
        
        SqlDataAdapter a = new SqlDataAdapter(sql, bagcum);
        DataTable t = new DataTable();
        a.Fill(t);
        lbSorun.DataSource = t;
        lbSorun.DataTextField = "problem";
        lbSorun.DataValueField = "p_no";
        lbSorun.DataBind();
        
    }

    protected void lbSorun_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select c.* from cozumler c, kayitli_sorunlar ks where c.p_no=ks.p_no and ks.p_no=" + lbSorun.SelectedValue.ToString();
        i.listele(gvCozum, sql);
    }

    protected void btYolla_Click(object sender, EventArgs e)
    {
       
    }

    protected void btCikis_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
}