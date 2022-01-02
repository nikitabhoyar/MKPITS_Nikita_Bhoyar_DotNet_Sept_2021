using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Web_User_Controls_Example
{
    public partial class SearchPage : System.Web.UI.Page
    {
        public SqlConnection con;
        public SqlCommand com;
        public SqlDataReader dr;
        private readonly DataTable dt;


      
       protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDB"].ToString());

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Single record search operation//
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select fname,lname,salary from employee where id=@id";
            SqlParameter p1 = new SqlParameter("@id", System.Data.SqlDbType.Int);
            p1.Value = Convert.ToInt32(TextBox1.Text);
            com.Parameters.Add(p1);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                TextBox2.Text = dr[0].ToString();
                TextBox3.Text = dr[1].ToString();
                TextBox4.Text = dr[2].ToString();
            }

            con.Close();
        }
    }
}