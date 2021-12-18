using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Get_Post_Example
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        string s1, s2 ,s3 , s4;
        protected void Page_Load(object sender, EventArgs e)
        {

            s1 = Request.Form.Get("Firstname").ToString();
            s2 = Request.Form.Get("Lastname").ToString();
            s3 = Request.Form.Get("Rollno").ToString();
            s4 = Request.Form.Get("Class").ToString();
         
            Label1.Text = s1;
            Label2.Text = s2;
            Label3.Text = s3;
            Label4.Text = s4;
           
        }
    }
}