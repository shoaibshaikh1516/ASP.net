using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Query : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)		//query string
    {
        string str = "query2.aspx?Name=" + txtName.Text;   //TEXT  ID NAME(PROPERTY)
        str += "&Age=" + txtAge.Text;			   //& CONCAT STRING
        Response.Redirect(str);

    }
}	