using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] != null)
            Response.Redirect("Default.aspx");
    }
    protected void btnGiris_Click(object sender, EventArgs e)
    {
        //DB.getInstance().SqlCalistir("INSERT INTO tbl_personel (email,password) VALUES('asd', '" + Fonksiyon.CalculateSHA256("asd", Encoding.UTF8) + "')");

        Hashtable ht = new Hashtable();
        ht.Add("@email", txtEmail.Text);
        ht.Add("@password", Fonksiyon.CalculateSHA256(txtPassword.Text, Encoding.UTF8));
        String[,] rows = DB.getInstance().getRows("SELECT * FROM tbl_personel WHERE email = @email AND password= @password", ht);

        if (rows.Length > 0)
        {
            Session.Add("user_id", rows[0, 0]);
            Session.Add("user_tip", "personel");
            Session.Add("cayocagi_id", rows[0, 5]);
            Response.Redirect("Default.aspx");
        }
            
    }
}