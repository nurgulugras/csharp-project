using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class sayfa : System.Web.UI.Page
{
    string bc = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog=yolculuk; integrated security=true";
    yolculuk y = new yolculuk();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            y.durak_getir(ddlNereden);
            y.durak_getir(ddlNereye);
        }
    }
    protected void btAra_Click(object sender, EventArgs e)
    {
        string nereden, nereye, tarih;
        nereden = ddlNereden.SelectedValue;
        nereye = ddlNereye.SelectedValue;
        tarih = cTakvim.SelectedDate.ToShortDateString();
        y.sefer_ara(gvSeferler, nereden, nereye, tarih);
    }
    protected void gvSeferler_SelectedIndexChanged(object sender, EventArgs e)
    {
        string seferno = gvSeferler.SelectedRow.Cells[1].Text;
        string kod;
        kod = "<script>open('otobus.aspx?seferno="+
            seferno + "','_blank','width=200 height=400')</script>";
        Response.Write(kod);
    }
}