using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;




namespace Three_Tier_Application
{
    public class Employee
    {

        public SqlCommand com;
        public DataSet ds;
        public SqlDataAdapter da;
        public int Empid { get; set; }
        public  string Empname { get; set; } 

        public decimal Empsalary { get; set; }

        public DataSet GetEmployees()
        {
            myDb emp = new myDb();
            com = new SqlCommand("Select emp_id , emp_name , emp_salary ");
            ds = new DataSet();
        }


    }
}