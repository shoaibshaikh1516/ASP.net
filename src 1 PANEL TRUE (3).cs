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
        Panel1.Visible = false;
        Panel3.Visible = false;
        

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Panel3.Visible = true;
    }
}

//property

//group by       	 in radio button
//navigateurl    	 in hyperlink
//panel1.visible=false   on pageload