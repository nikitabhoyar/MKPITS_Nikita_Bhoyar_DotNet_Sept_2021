using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientSide_StateManagement
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        HttpCookie mycookee;

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "prn";
            int count = 0;
            mycookee = new HttpCookie("printercookie");// Employee e1=new Employee()
            foreach (ListItem p in CheckBoxList1.Items)
            {
                if (p.Selected == true)
                {
                    count++;
                    s = s + count;  //prn1
                    mycookee.Values.Add(s, p.Text);

                    //key prn1,p.Text="HP"
                    //key prn2,p.Text="L and T"

                }

            }
            this.Response.Cookies.Add(mycookee);
            mycookee.Expires.AddDays(29); //user ka broswer hai usme 29 day tak rhega
            Response.Redirect("Readcookee.aspx");       //filename has to be return here eg by file is (ReadCokee.aspx)

        }
    }
}
