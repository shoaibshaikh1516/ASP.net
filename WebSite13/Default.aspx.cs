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
    protected void But_Reg_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int myAge = Convert.ToInt32(txt_age.Text);
        DateTime dt = DateTime.Parse(args.Value);
        TimeSpan ts = DateTime.Today - dt;
        int age = ts.Days/ 365;
        if (age <= 18 || age >= 45 || age != myAge)
        {
            args.IsValid = false;
        }
        else 
        {
            args.IsValid = true;
        }

    }
}