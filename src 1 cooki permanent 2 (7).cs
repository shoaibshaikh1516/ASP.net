using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;           //imp

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie clr = Request.Cookies["coloun"];
        if (clr != null)
        {
            Label1.BackColor = Color.FromName(clr.Value);
        }
        else
        {
            Label1.BackColor=Color.FromName("gray");
            // Label1.BackColor=Color.purple 

        }

        
    }
}
