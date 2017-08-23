using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie color = new HttpCookie("coloun");
        color.Value = DropDownList1.SelectedValue;
        color.Expires = DateTime.Now.AddSeconds(10);        //this create permanent cookie
        Response.Cookies.Add(color);
        Response.Redirect("cooki_perm2.aspx");

    }
}