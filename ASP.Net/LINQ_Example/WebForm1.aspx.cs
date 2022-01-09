using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        int[] nums = new int[] { 0, 1, 2, 3, 4, 5, 6, 73 };
        int[] Numbers = { 20, 40, 60, 80, 100, 120 };
        int[] factorof300 = { 2, 3, 2, 5, 5, 6, 7, 8, 9 };  
        string[] digits = { "zero", "one ", "two ", "three ", "four ", "five ", " six", "seven", " eight ", "nine" };
        int[] numbers = { 1, 11, 3, 19, 4, 45, 41, 65, 19 };


        int[] numberA = { 0, 1, 2, 4, 5, 6, 8, 9 };
        int[] numberB = { 1, 3, 5, 7, 8 };
       


       protected void Page_Load(object sender, EventArgs e)
        {
            var result = from n in nums select n;   //num is a datasource//

            var dresult = (from d in digits
                           where d[1] == 'i' 
                           select d).Reverse();

            var uniquefactor = factorof300.Distinct(); 

            var uniquenumbers= from n in numberA.Union(numberB)
                                orderby n
                                select n ;

            var commonfactor = numberA.Intersect(numberB);

            var aOnlyNumbers = numberA.Except(numberB);

            Label1.Text = Numbers.Max().ToString();
            Label2.Text = Numbers.Min().ToString();
            Label3.Text = Numbers.Sum().ToString();
            Label4.Text = Numbers.Average().ToString();
            Label5.Text = Numbers.Count().ToString();


            string[] words = { "Believe", "relief", "receipt", "field" };
            bool iAfterE = words.Any(w => w.Contains("ei"));    //Find a word  w in words if any so that it contains ei

            bool eAfteri = words.All(w => w.Contains("e"));     //find a word w if all the words have ei //
            Label6.Text = iAfterE.ToString();
            Label7.Text = eAfteri.ToString();
            bool onlyodd = numbers.All(n => n % 2 == 1);

           
                                                               //And-> All Any ->OR
           


            // var desult = from d in digits select d;//

            // var  factorresult = from  f  in factorof300 select f;

            //var  Numbersresult = from  num  in Numbers select  num;


            if (!Page.IsPostBack)
            {
                DropDownList2.DataSource = result;

                DropDownList3.DataSource = dresult;

                DropDownList4.DataSource = uniquefactor;

                DropDownList5.DataSource = uniquenumbers;

                DropDownList6.DataSource = commonfactor;

                DropDownList7.DataSource = aOnlyNumbers;

                Page.DataBind();

            }
        }
    }
}