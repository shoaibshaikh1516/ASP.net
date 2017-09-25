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

        showGrid();                 // for 1st time display result
        
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
        cn.Close();
        showGrid();         // for again display result
        

    }
    protected void But_update_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();//
        cmd.CommandText = "update emp2 set name='"+txtName.Text+"', salary="+txtSal.Text+" where Eid="+txt_eid.Text+" ";  //dont use this security issue
        cmd.Connection = cn;

        cn.Open();

        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("updated ");

        }
        else
            Response.Write("else");
        cn.Close();
        showGrid();         // for again display result
       
    }
    protected void But_sear_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select *from emp2 where Eid=" + txt_eid.Text + "", cn);
        cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            txtName.Text = dr["name"].ToString();   //imp sring 
            txt_eid.Text=dr[1].ToString();
            txtSal.Text = dr[2].ToString();
            txt_dof.Text = dr[3].ToString();
        }

    }
    protected void But_del_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from emp2 where Eid='"+txt_eid.Text+"'";  //dont use this security issue
        cmd.Connection = cn;

        cn.Open();
        

        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("deleted ");

        }
        else
            Response.Write("else");
        cn.Close();
        showGrid();                 // for again display result
    }
    protected void txt_upd_para_Click(object sender, EventArgs e)
    {

        SqlCommand cmd = new SqlCommand("update emp2 set name=@newname,Eid=@newEid,salary=@newsalary,dof=@newdof  where Eid=@newEid", cn);
        //SqlParameter sp = new SqlParameter(); not used here but imp

        cmd.Parameters.Add("@newname",SqlDbType.VarChar,20,"name").Value=txtName.Text;
                            //var ,sql datatype, size of datatype,sql column name
                            //size is optional


        cmd.Parameters.Add("@newEid", SqlDbType.Int).Value = Convert.ToInt32(txt_eid.Text);   //imp for int

        cmd.Parameters.Add("newsalary", SqlDbType.Int).Value = Convert.ToInt32(txtSal.Text);   //imp for int

        cmd.Parameters.Add("@newdof", SqlDbType.DateTime, 20, "dof").Value = txt_dof.Text;  // can work with SqlDbType.VarChar also

        cn.Open();

        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("updated ");

        }
        else
            Response.Write("else");
        cn.Close();
        showGrid();                 // for again display result



    }
    protected void But_ins_para_Click(object sender, EventArgs e)
    {



        SqlCommand cmd = new SqlCommand("insert into emp2 values(@newname,@newEid,@newsalary,@newdof)", cn);
        //SqlParameter sp = new SqlParameter(); not used here but imp

        cmd.Parameters.Add("@newname", SqlDbType.VarChar, 20, "name").Value = txtName.Text;
        //var ,sql datatype, size of datatype,sql column name
        //size is optional


        cmd.Parameters.Add("@newEid", SqlDbType.Int).Value = Convert.ToInt32(txt_eid.Text);   //imp for int

        cmd.Parameters.Add("newsalary", SqlDbType.Int).Value = Convert.ToInt32(txtSal.Text);   //imp for int

        cmd.Parameters.Add("@newdof", SqlDbType.DateTime, 20, "dof").Value = txt_dof.Text;  // can work with SqlDbType.VarChar also;


        cn.Open();

        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("insert ");

        }
        else
            Response.Write("else");
        cn.Close();
        showGrid();                 // for again display result

    }
    protected void But_del_proc_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("spdel",cn);  // stored proc name
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@eid",SqlDbType.Int).Value=Convert.ToInt32(txt_eid.Text);//varaible from stored proc    @eid

         cn.Open();

        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("deleted ");

        }
        else
            Response.Write("else");
        cn.Close();
        showGrid();
    }
}