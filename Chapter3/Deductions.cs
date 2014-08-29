using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    //Take note, this is a Static class
    public static class Deductions
    {
        //Static Classes, use static Methods
        public static double GetTotalDeductions(double GrossPay)
        {
            double TotalDeductions = GetSGTI(GrossPay) + GetPhilHealth(GrossPay) +
    GetTax(GrossPay) + GetPagibig(GrossPay);
            
            return TotalDeductions;
        }

        public static double GetPagibig(double GrossPay)
        {
            return 100;
        }

        public static double GetSGTI(double GrossPay)
        {
            //EDIT
            return 6.00;
        }

        public static double GetPhilHealth(double GrossPay)
        {
            //Do logic for PhilHealth
            double philHealth = 0;
            {
                if (GrossPay >= 5000 && GrossPay < 6000)
                {
                    philHealth = 50.00;
                }
                else if (GrossPay >= 6000 && GrossPay < 7000)
                {
                    philHealth = 62.50;
                }
                else if (GrossPay >= 7000 && GrossPay < 8000)
                {
                    philHealth = 75.00;
                }
                else if (GrossPay >= 8000 && GrossPay < 9000)
                {
                    philHealth = 87.50;
                }
                else if (GrossPay >= 9000 && GrossPay < 10000)
                {
                    philHealth = 100.00;
                }
                else if (GrossPay >= 10000 && GrossPay < 11000)
                {
                    philHealth = 112.50;
                }
                else if (GrossPay >= 11000 && GrossPay < 12000)
                {
                    philHealth = 125.00;
                }
                else if (GrossPay >= 12000 && GrossPay < 13000)
                {
                    philHealth = 137.50;
                }
                else if (GrossPay >= 13000 && GrossPay < 14000)
                {
                    philHealth = 150.00;
                }
                else if (GrossPay >= 14000 && GrossPay < 15000)
                {
                    philHealth = 162.50;
                }
                else if (GrossPay >= 15000 && GrossPay < 16000)
                {
                    philHealth = 175;
                }
                else if (GrossPay >= 16000 && GrossPay < 17000)
                {
                    philHealth = 187.50;
                }
                else if (GrossPay >= 17000 && GrossPay < 18000)
                {
                    philHealth = 200.00;
                }
                else if (GrossPay >= 18000 && GrossPay < 19000)
                {
                    philHealth = 212.50;
                }
                else if (GrossPay >= 19000 && GrossPay < 20000)
                {
                    philHealth = 225.00;
                }
                else if (GrossPay >= 20000 && GrossPay < 21000)
                {
                    philHealth = 237.50;
                }
                else if (GrossPay >= 21000 && GrossPay < 22000)
                {
                    philHealth = 250.00;
                }
                else if (GrossPay >= 22000 && GrossPay < 23000)
                {
                    philHealth = 262.50;
                }
                else if (GrossPay >= 23000 && GrossPay < 24000)
                {
                    philHealth = 275.00;
                }
                else if (GrossPay >= 24000 && GrossPay < 25000)
                {
                    philHealth = 287.50;
                }
                else if (GrossPay >= 25000 && GrossPay < 26000)
                {
                    philHealth = 300;
                }
                else if (GrossPay >= 26000 && GrossPay < 27000)
                {
                    philHealth = 312.50;
                }
                else if (GrossPay >= 27000 && GrossPay < 28000)
                {
                    philHealth = 325;
                }
                else if (GrossPay >= 28000 && GrossPay < 29000)
                {
                    philHealth = 337.50;
                }
                else if (GrossPay >= 29000 && GrossPay < 30000)
                {
                    philHealth = 350;
                }
                else if (GrossPay >= 30000 && GrossPay < 57700)
                {
                    philHealth = 375;
                }

   
            }

            return philHealth;
        }
        public static double GetTax(double GrossPay)
        {
            //Do Tax computation
            return GrossPay * .12;
        }
      }

    
  
}