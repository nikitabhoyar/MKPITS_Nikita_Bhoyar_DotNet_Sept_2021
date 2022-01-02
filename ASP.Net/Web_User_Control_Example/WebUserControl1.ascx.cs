using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_User_Controls_Example
{
    public partial class WebUserControl11 : System.Web.UI.UserControl
    {
    
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblPlaces.Text = "You chose: " + ddlCountry.SelectedItem.Text + " and " + ddlState.SelectedItem.Text;
            lbltime.Text = DateTime.Now.ToString("T");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}