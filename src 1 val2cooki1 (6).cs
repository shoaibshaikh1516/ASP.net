using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class val2cooki1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie cook = new HttpCookie("mycook");
        cook["value1"] = TextBox1.Text;
        cook["value2"] = TextBox2.Text;
        Response.Cookies.Add(cook);
        Response.Redirect("val2cooki2.aspx");
    }
}