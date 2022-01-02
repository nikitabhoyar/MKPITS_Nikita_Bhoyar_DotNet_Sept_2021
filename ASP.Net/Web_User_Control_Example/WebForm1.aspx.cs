using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace Web_User_Controls_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection con;
        public SqlCommand com;
        public SqlDataReader dr;
        private DataTable dt;

        protected void Page_load(object sender,EventArgs e)

        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB"].ToString());

            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Select id,fname,lname,salary from Employee";
            con.Open();
            dr =  com.ExecuteReader();
            dt = new DataTable(); 
            dt.Load(dr);
            con.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

   

        protected void Button4_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Insert into Employee(fname,lname,salary)values(@fname,@lname,@salary)";          
            SqlParameter p1 = new SqlParameter("@fname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@lname", SqlDbType.VarChar);
            SqlParameter p3 = new SqlParameter("@salary", SqlDbType.Decimal);

            p1.Value = TextBox1.Text;
            p2.Value = TextBox2.Text;
            p3.Value = Convert.ToInt32(TextBox3.Text);
         
          

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);

            //con.Open();
            com.ExecuteNonQuery();
            con.Close();

             
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Update Employee set fname=@fname,lname=@lname,salary=@salary,id=@id where id=@id";
            SqlParameter p1 = new SqlParameter("@fname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@lname", SqlDbType.VarChar);
            SqlParameter p3 = new SqlParameter("@salary", SqlDbType.Decimal);
            SqlParameter p4 = new SqlParameter("@id", SqlDbType.Int);

            p1.Value = TextBox1.Text;
            p2.Value = TextBox2.Text;
            p3.Value = Convert.ToInt32(TextBox3.Text);
            p4.Value = TextBox4.Text;


            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = "  ";
            TextBox4.Text = "  ";

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
