using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class proje : System.Web.UI.Page
{
    string bcum = "provider=Microsoft.Jet.OleDb.4.0; data source= C:\\proje.mdb";
    islem islemim = new islem();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            islemim.ogrencileri_getir(gvOgrenci);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sirano, p_adi;
        p_adi = tbProje.Text;
        for(int i=0; i<lbGrup.Items.Count; i++)
        {
            sirano = lbGrup.Items[i].Value.ToString();
            islemim.proje_ata(sirano, p_adi);
        }
        lbGrup.Items.Clear();
        islemim.ogrencileri_getir(gvOgrenci);
    }
    protected void gvOgrenci_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sirano, isim;
        sirano = gvOgrenci.SelectedRow.Cells[1].Text;
        isim = gvOgrenci.SelectedRow.Cells[2].Text;
        ListItem eleman = new ListItem(isim,sirano);
        lbGrup.Items.Add(eleman);
    }
}