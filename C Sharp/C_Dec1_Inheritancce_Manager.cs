using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec1_inheritance
{
    class Manager : Employee
    {
        public decimal Commission { get; set; }
        public int Saleqty { get; set; }

        public Manager() : base()
        {
            Commission = 350;
            Saleqty = 10;
        }
        public Manager(decimal commission, int salary, int id, string name, decimal sal) : base(id, name, sal)
        {
            Commission = 250;
            Saleqty = 10;
        }

        //public override void GrossSalary()
        //{
        //    Console.WriteLine("Manager's Gross Salary"+(BasicSal+Commission *Saleqty));
        //}
        public override decimal GrossSalary()
        {
            return (BasicSal + Commission * Saleqty);
        }

    }
}
