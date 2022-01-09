using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControlaExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ArrayList fruits, cities;
        decimal[] price = { 20m, 30m, 35m, 59m, 45m, 56m, 67m, 78m };

        protected void Button1_Click(object sender, EventArgs e)
        {

            Label2.Text += DropDownList1.SelectedItem.ToString();
            Label9.Text += ListBox1.SelectedIndex.ToString(); //data accept and fill by user 
            Label6.Text += DropDownList1.SelectedIndex.ToString();
            Label8.Text += DropDownList1.SelectedIndex.ToString();

   

            protected void  Page_Load(object sender, EventArgs e)
            {
                //in memory datasource//

                if (!Page.IsPostBack)
                {

                    fruits = new ArrayList();
                    fruits.Add("Orane");
                    fruits.Add("Mango");
                    fruits.Add("Grapes");
                    fruits.Add("CustardApple");
                    fruits.Add("Lemon");
                    fruits.Add("PineApple");
                    fruits.Add("BlackBery");

                    ListBox1.DataSource = fruits;
                    ListBox1.DataBind();
                    for (int i = fruits.Count - 1; i >= 0; i--)
                    ListBox1.Items[i].Value = price[i].ToString();


                    //ListBox1.DataBind();
                    cities = new ArrayList();
                    cities.Add("Mumbai");
                    cities.Add("Banglore");
                    cities.Add("Mysore");
                    cities.Add("Pune");

                    DropDownList1.DataSource = cities;


                    Page.DataBind();
                }

            }
        }
    }
}

