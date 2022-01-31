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
        SqlConnection con;//sqlclient  
        SqlCommand com;//sqlclient
        SqlDataAdapter da;//sqlclient
        public SqlCommandBuilder bld;

        //data namespace
        DataSet ds;
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "insert into products(productname,price,mfd,catId)values(@productname,@price,@mfd,@catid)";
                SqlParameter p1 = new SqlParameter("@productname", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@price", SqlDbType.Decimal);
                SqlParameter p3 = new SqlParameter("@mfd", SqlDbType.Date);
                SqlParameter p4 = new SqlParameter("@catId", SqlDbType.Int);
                p1.Value = TextproductName.Text;
                p2.Value = Convert.ToDecimal(Textprice.Text);
                p3.Value = Convert.ToDateTime(TextMFD.Text);
                p4.Value = ddlcategory.SelectedItem.Value;
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                con.Open();
                com.ExecuteNonQuery();
                //llbmeesage.text="recoded added succfully"
                Llbmessage.Text = "Record Added Successfully";
            }
            catch (SqlException ex)
            {
                Llbmessage.Text = ex.Message;
            }
            con.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myDBconnect"].ToString());
            ds = new DataSet();
            da = new SqlDataAdapter("select id,catname from Categary", con);
            ds = new DataSet();
            da.Fill(ds,"pro");
            ddlcategory.DataSource = ds.Tables[0];
            ddlcategory.DataTextField = "catname";
            ddlcategory.DataValueField = "id";
            Page.DataBind();

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "Update products set productname=@productname,price = @price , mfd = @mfd where catid=@catid";
                SqlParameter p1 = new SqlParameter("@productname", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@price", SqlDbType.Decimal);
                SqlParameter p3 = new SqlParameter("@mfd", SqlDbType.Date);
                SqlParameter p4 = new SqlParameter("@catId", SqlDbType.Int);
                p1.Value = TextproductName.Text;
                p2.Value = Convert.ToDecimal(Textprice.Text);
                p3.Value = Convert.ToDateTime(TextMFD.Text);
                p4.Value = ddlcategory.SelectedItem.Value;
                SqlParameter sqlParameter = com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                con.Open();
                com.ExecuteNonQuery();
                //llbmeesage.text="recoded added succfully"
                Llbmessage.Text = "Record Updated Successfully.";

            }
            catch (SqlException ex)
            {
                Llbmessage.Text = ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "Delete from products where catid=@catid ";
                SqlParameter p1 = new SqlParameter("@productname", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@price", SqlDbType.Decimal);
                SqlParameter p3 = new SqlParameter("@mfd", SqlDbType.Date);
                SqlParameter p4 = new SqlParameter("@catId", SqlDbType.Int);
                p1.Value = TextproductName.Text;
                p2.Value = Convert.ToDecimal(Textprice.Text);
                p3.Value = Convert.ToDateTime(TextMFD.Text);
                p4.Value = ddlcategory.SelectedItem.Value;
                SqlParameter sqlParameter = com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                con.Open();
                com.ExecuteNonQuery();
                
                //llbmeesage.text="recoded added succfully"
                Llbmessage.Text = "Record Delete Successfully.";

            }
            catch (SqlException ex)
            {
                Llbmessage.Text = ex.Message;
            }
        }

        protected void btnClearClick(object sender, EventArgs e)
        { 
            {
                ClearInputs(Page.Controls);
            }
            void ClearInputs(ControlCollection ctrls)
            {
                foreach (Control ctrl in ctrls)
                {
                    if (ctrl is TextBox)
                        ((TextBox)ctrl).Text = string.Empty;
                    ClearInputs(ctrl.Controls);
                }
            }
        }
    }
}