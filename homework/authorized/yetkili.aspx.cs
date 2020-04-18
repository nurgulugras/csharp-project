using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class yetkili : System.Web.UI.Page
{
    string bcum = "data source=ACER-BILGISAYAR\\SQLEXPRESS; initial catalog= okul; integrated security=true";
    islemler i = new islemler();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable t = new DataTable();
        int kulno;
        kulno = Convert.ToInt32(Session["kulno"]);
        t = i.menu_getir(kulno);
        blMenu.DataSource = t;
        blMenu.DataTextField = "menu_adi";
        blMenu.DataBind();
    }
    }
