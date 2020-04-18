using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class randevual : System.Web.UI.Page
{
    randevu r = new randevu();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string sql = "select * from poller";
            r.listboxalistele(lbPol, sql);
            r.rand_listele(gvRandevu);
        }
    }

    protected void btRandevu_Click(object sender, EventArgs e)
    {
        string tc, isim, doktorno, tarih, saatno;
        tc = Tbtc.Text;
        isim = Tbisim.Text;
        doktorno = lbDoktor.SelectedValue.ToString();
        tarih = cTarih.SelectedDate.ToShortDateString();
        saatno = lbsaat.SelectedValue.ToString();
        r.randuvual(tc, isim, doktorno, tarih, saatno);
        r.rand_listele(gvRandevu);
    }
    protected void lbPol_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select * from doktorlar where polno= " + lbPol.SelectedValue.ToString();
        r.listboxalistele(lbDoktor, sql);
    }
    protected void cTarih_SelectionChanged(object sender, EventArgs e)
    {
        string sql = "select * from saatler " +
                     "where saatno not in( " +
                     "select saatno from randevular " +
                     "where doktorno="+lbDoktor.SelectedValue.ToString() + " " +
        "and tarih= '" + cTarih.SelectedDate.ToShortDateString()  + "' ) " ;
                     r.listboxalistele(lbsaat,sql);
          
    }
}