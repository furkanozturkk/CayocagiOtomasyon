using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kategoriekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnKategoriEkle_Click(object sender, EventArgs e)
    {
        DB.getInstance().SqlCalistir("Insert into tbl_kategori(kategori_ad,cayocagi_id) Values('" + txtKategoriAdi.Text + "', '" + Session["cayocagi_id"] + "')");
    }
}