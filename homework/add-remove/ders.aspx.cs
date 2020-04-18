using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ders : System.Web.UI.Page
{
    islemler islemim = new islemler();
  void yenile()
    {
        islemim.ders_listele(Session["ogrno"].ToString(), gvekle, 'a');
        islemim.ders_listele(Session["ogrno"].ToString(), gvsil, 's');
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            yenile();
        }
    }
    protected void gvekle_SelectedIndexChanged(object sender, EventArgs e)
    {
        string dno, ogr_no;
        dno = gvekle.SelectedRow.Cells[1].Text;
        ogr_no = Session["ogrno"].ToString();
        islemim.ekle_sil(ogr_no, dno, 'e');
        yenile();
        
    }
    protected void gvsil_SelectedIndexChanged(object sender, EventArgs e)
    {
        string dno, ogr_no;
        dno = gvsil.SelectedRow.Cells[1].Text;
        ogr_no = Session["ogrno"].ToString();
        islemim.ekle_sil(Session["ogrno"].ToString(), dno, 's');
        yenile();
        
    }
}