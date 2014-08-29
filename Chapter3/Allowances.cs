using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public static class Allowances
    {
        public static double GetTotalAllowances(double GrossPay)
        {
            double TotalAllowances = GetClothing(GrossPay) + GetQuarter(GrossPay) + GetLaundry(GrossPay) + GetPera(GrossPay) + GetHazardPay(GrossPay);

            return TotalAllowances;
        }
        public static double GetClothing(double GrossPay)
        {
            return 200.00;
        }

        public static double GetQuarter(double GrossPay)
        {
            double quarter = 0;
            {
                if (GrossPay >= 14834 && GrossPay <= 16934)
                {
                    quarter = 400;
                }
                else if (GrossPay >= 18665 && GrossPay <= 21711)
                {
                    quarter = 450;
                }
                else if (GrossPay >= 23513 && GrossPay <= 27425)
                {
                    quarter = 500;
                }
                else if (GrossPay >= 32341 && GrossPay < 35312)
                {
                    quarter = 600;
                }
                else if (GrossPay >= 35312 && GrossPay < 37313)
                {
                    quarter = 650;
                }
                else if (GrossPay >= 37313 && GrossPay < 40298)
                {
                    quarter = 700;
                }
                else if (GrossPay >= 40298 && GrossPay < 47002)
                {
                    quarter = 800;
                }

                return quarter;

            }
        }
        public static double GetLaundry(double GrossPay)
        {
            double laundry = 0;
            {
                if (GrossPay >= 14834 && GrossPay <= 27425)
                {
                    laundry = 30.00;
                }
                else if (GrossPay >= 32341 && GrossPay <= 40298)
                {
                    laundry = 60.00;
                }

                return laundry;
            }
        }



        public static double GetPera(double GrossPay)
        {
            return 2000.00;
        }

        public static double GetHazardPay(double GrossPay)
        {
            return 240.00;
        }
       
    }
}
