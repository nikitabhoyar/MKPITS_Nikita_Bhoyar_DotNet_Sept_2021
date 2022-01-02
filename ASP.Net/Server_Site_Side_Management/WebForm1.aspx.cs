using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sever_Site_Side_Management
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text=Application["message"].ToString();
            TextBox1.Text = Application["Count"].ToString();

        }

      
        protected void Button1_Click1(object sender, EventArgs e)
        {

             Response.Write("See the Session Id " + Session.SessionID);
            Session["username"] = TextBox2.Text;
            Response.Redirect("WebForm2.aspx");


        }
    }
}