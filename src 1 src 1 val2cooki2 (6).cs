using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class val2cooki2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie obj = Request.Cookies["mycook"];   //imp  
        if(obj!=null)
        {
            Label1.Text = obj["value1"].ToString();
            Label2.Text = obj["value2"].ToString();

        }
    }
}