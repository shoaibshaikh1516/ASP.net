using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class query2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelName.Text = Request.QueryString["name"];
        LabelAge.Text = Request.QueryString["Age"];
    }

}