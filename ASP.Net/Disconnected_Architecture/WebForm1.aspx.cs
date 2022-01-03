using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Disconnected_Architecture
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        private DataTable dt1;
        private DataTable dt2;

        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDBConnect"].ToString());
                ds = new DataSet();
                da = new SqlDataAdapter();

                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "Select id, fname , lname from employee1";
                da.SelectCommand = com;

              //  da = new SqlDataAdapter("select * from employee1; select id , fname from employee1 " , con );//
                da.Fill(ds);
                dt1 = new DataTable();
                dt1 = ds.Tables[0];
               // GridView1.DataSource = ds.Tables[0];//

                GridView1.DataSource = dt1;
                ////dt2 = new DataTable();
                //dt2 = ds.Tables[1];
                //GridView2.DataSource = ds.Tables[1];
                Page.DataBind();
               }

            catch(SqlException ex)
            {
                Label2.Text = ex.Message;

            }

        }
    }
}