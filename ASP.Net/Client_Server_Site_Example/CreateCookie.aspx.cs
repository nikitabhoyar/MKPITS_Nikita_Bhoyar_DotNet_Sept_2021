using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client_server_Site_Example
{
    public partial class WebForm4 : System.Web.UI.Page
    {

        HttpCookie mycookie;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "prn";
            int count = 0;
            mycookie = new HttpCookie("printercookie");// Employee e1=new Employee()
            foreach (ListItem p in CheckBoxList1.Items)
            {
                if (p.Selected == true)
                {
                    count++;
                    s = s + count;  //prn1
                    mycookie.Values.Add(s, p.Text);

                    //key prn1,p.Text="HP"
                    //key prn2,p.Text="L and T"

                }

            }

            this.Response.Cookies.Add(mycookie);
            Response.Redirect("Readcookie.aspx");

        }
    }
}