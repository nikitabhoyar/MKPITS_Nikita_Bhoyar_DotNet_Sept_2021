using System;

namespace C_Dec4_Abstract_Rupee_Conversion_Prog
{
class Program
    {
        static void Main(string[] args)
        {
            //Currrency c1 = new Dollar();    //calling function by DOllar
            //c1.ToRupees();
            //Console.WriteLine(".................");

            //Currrency c2 = new Dollar(15);    //calling function by Dollar
            //c2.ToRupees();
            //Console.WriteLine(".................");

            //Currrency c3 = new Dollar(20);    //calling function by Dollar
            //c3.ToRupees();
            //Console.WriteLine(".................");
            
            //Currrency c = new Pound(20);    //calling function by Pound
            //c.ToRupees();
            //Console.WriteLine(".................");
            
            //Currrency c4 = new Pound(100);    //calling function by Pound
            //c4.ToRupees();
            //Console.WriteLine(".................");
            
            //Currrency c5 = new Euro(100);   
            //calling function by Euro
            //c5.ToRupees();
            //Console.WriteLine(".................");

            Currency[] currency = new Currency[6];
            currency[0] = new Dollar();
            currency[1] = new Euro();
            currency[2] = new Pound();
            currency[3] = new Dollar(100);
            currency[4] = new Euro(100);
            currency[5] = new Pound(100);
            foreach (Currency c in currency)
            {
               c.ToRupees();
            }
        }
    }
}

