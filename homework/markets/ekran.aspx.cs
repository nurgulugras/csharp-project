using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ekran : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    islemler i = new islemler();
    protected void tburun_TextChanged(object sender, EventArgs e)
    {
        DataTable t = new DataTable();
        t = i.urun_getir(tburun.Text);
        gvurun.DataSource = t;
        gvurun.DataBind();
    }
}