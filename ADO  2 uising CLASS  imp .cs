using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;              //imp
using System.Data.SqlClient;    //imp

public partial class _Default : System.Web.UI.Page
{

    SqlConnection cn = new SqlConnection("Data Source=CC-38;Initial Catalog=KJcollege;Integrated Security=True");
   
    public void showGrid()
    {    
        //connection string
        

        SqlCommand cmd = new SqlCommand("select *from emp2", cn);//usually use 3rd overload
        cn.Open();

        SqlDataReader dr = cmd.ExecuteReader();

        GridView1.DataSource = dr;
        GridView1.DataBind();
        cn.Close();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        showGrid();
        
    }
    protected void But_Insert_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();//
        cmd.CommandText = "insert into emp2 values('" + txtName.Text + "'," + txt_eid.Text + "," + txtSal.Text + ",'" + txt_dof.Text + "')";  //this not security issue
        cmd.Connection=cn;

        cn.Open();

        int i=cmd.ExecuteNonQuery();
        if(i>0)
        {
        Response.Write("data Added");
        
        }
        else
        Response.Write("else");
         
        

    }
}