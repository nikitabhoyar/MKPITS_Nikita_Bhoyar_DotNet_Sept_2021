using System;

namespace Get_Post_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string s1, s2, s3, s4, s5;
        protected void Page_Load(object sender, EventArgs e)
        {

            s1 = Request.QueryString[0].ToString();
            s2 = Request.QueryString[1].ToString();
            s3 = Request.QueryString[2].ToString();
            s4 = Request.QueryString[3].ToString();
            s5 = Request.QueryString[4].ToString();


            Label1.Text = s1;
            Label2.Text = s2;
            Label3.Text = s3;
            Label4.Text = s4;
            Label5.Text = s5;

        }
    }
}