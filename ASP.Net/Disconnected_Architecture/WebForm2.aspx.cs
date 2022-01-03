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
    public partial class WebForm2 : System.Web.UI.Page
    {

        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        public SqlCommandBuilder bld;

       

        protected void Page_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDBConnect"].ToString());
            ds = new DataSet();
            da = new SqlDataAdapter("select  id , catName from Categary ", con);
            ds = new DataSet();
           
            da.Fill(ds,"cat");
            ddlCategary.Items.Add("Selected Categary");
            ddlCategary.DataSource = ds.Tables["cat"];
            ddlCategary.DataTextField = "catname";
            ddlCategary.DataValueField = "id";
            Page.DataBind();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {


            com = new SqlCommand();
            com.Connection = con;
       
            com.CommandText = "Insert into  product(productname,price,mfd,catId)values(@pname,@price,@mfd,@catid)";
            SqlParameter p1 = new SqlParameter("@pname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@price", SqlDbType.Decimal);
            SqlParameter p3 = new SqlParameter("@mfd", SqlDbType.Date);
            //SqlParameter p4 = new SqlParameter("@catid", SqlDbType.Int);

            p1.Value = Txtproductname.Text;
            p2.Value = Convert.ToDecimal(Txtprice.Text);
            p3.Value = Convert.ToDateTime(Txtmfd.Text);
            //p4.Value = Convert.ToInt32(ddlCategary.SelectedItem.Value.ToString());

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            //com.Parameters.Add(p4);

            da = new SqlDataAdapter();
            da.InsertCommand = com;
            bld = new SqlCommandBuilder(da);

           Lblmessage.Text = "record Added successfully";

            DataTable ProductTable = ds.Tables["product"];
            DataRow row = ProductTable.NewRow();
            row["Id"] = TextBox1.Text;
            row["Firstname"] = TextBox2.Text;
            row["Lastname"] = TextBox3.Text;
            row["Salary"] = TextBox4.Text;
            ProductTable.Rows.Add(row);
            da.Update(ds, "Product");








        }
    }
}
