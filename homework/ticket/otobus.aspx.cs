using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class otobus : System.Web.UI.Page
{
    yolculuk y = new yolculuk();
    void koltrolet(Button bt)
    {
        bool kontrol;
        kontrol = y.dolumu(bt, ViewState["seferno"].ToString());
        if (kontrol == true)
        {
            btsat.Enabled = false;
            btiptal.Enabled = true;
            tbkoltuk.Text = bt.Text;
        }
        else
        {
            btsat.Enabled = true;
            btiptal.Enabled = false;
            tbkoltuk.Text = bt.Text;
        }
    }
    void yenile()
    {
        y.dolumu(bt1, ViewState["seferno"].ToString());
        y.dolumu(bt2, ViewState["seferno"].ToString());
        y.dolumu(bt3, ViewState["seferno"].ToString());
        y.dolumu(bt4, ViewState["seferno"].ToString());
        y.dolumu(bt5, ViewState["seferno"].ToString());
        y.dolumu(bt6, ViewState["seferno"].ToString());
        y.dolumu(bt7, ViewState["seferno"].ToString());
        y.dolumu(bt8, ViewState["seferno"].ToString());
        y.dolumu(bt9, ViewState["seferno"].ToString());
        y.dolumu(bt10, ViewState["seferno"].ToString());
        y.dolumu(bt11, ViewState["seferno"].ToString());
        y.dolumu(bt12, ViewState["seferno"].ToString());
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           ViewState["seferno"] =   Request.QueryString["seferno"].ToString();
           yenile();
        }
    }

    protected void bt1_Click(object sender, EventArgs e)
    {
        koltrolet(bt1);
    }
    protected void bt2_Click(object sender, EventArgs e)
    {
        koltrolet(bt2);
    }
    protected void bt3_Click(object sender, EventArgs e)
    {
        koltrolet(bt3);
    }
    protected void bt4_Click(object sender, EventArgs e)
    {
        koltrolet(bt4);
    }
    protected void bt5_Click(object sender, EventArgs e)
    {
        koltrolet(bt5);
    }
    protected void bt6_Click(object sender, EventArgs e)
    {
        koltrolet(bt6);
    }
    protected void bt7_Click(object sender, EventArgs e)
    {
        koltrolet(bt7);
    }
    protected void bt8_Click(object sender, EventArgs e)
    {
        koltrolet(bt8);
    }
    protected void bt9_Click(object sender, EventArgs e)
    {
        koltrolet(bt9);
    }
    protected void bt10_Click(object sender, EventArgs e)
    {
        koltrolet(bt10);
    }
    protected void bt11_Click(object sender, EventArgs e)
    {
        koltrolet(bt11);
    }
    protected void bt12_Click(object sender, EventArgs e)
    {
        koltrolet(bt12);
    }
    protected void btsat_Click(object sender, EventArgs e)
    {
        string sql = "insert into biletler " +
            "(yolcu,sefer_no,koltuk_no) " +
            "values ('" + tbyolcu.Text + "', " +
            ViewState["seferno"].ToString() + "," +
            tbkoltuk.Text + ")";
        y.calistir(sql);
        yenile();
    }
    protected void btiptal_Click(object sender, EventArgs e)
    {
        string sql = "delete biletler where koltuk_no=" +
            tbkoltuk.Text + " and sefer_no=" +
            ViewState["seferno"].ToString();
        y.calistir(sql);
        yenile();
    }
}