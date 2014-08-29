using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class Personnel
    {
        public string FirstName { get; set; }   //1
        public string LastName { get; set; }    //2

        private string position;
  
        public string Position                  //3
        {
            get { return position; }
            set
            {
                position = value;

                SetGrossPay(position);

                //At this Point the Gross Pay has been updated

                //SetLongPay(HireDate);
                SetTotalDeductions();
                SetTotalSalary();
                SetTotalAllowances();
                
            }
        }

        public double GrossPay { get; private set; }    //4

        private DateTime hireDate;
        public DateTime HireDate                        //5
        {
            get {   return hireDate; }
            set
                {
                    hireDate = value;

                    SetLongPay(hireDate);

                }
        }

        public double LongPay {get; private set;}   //6
        
        public double Sgti {get; private set;}      //7
        public double PhilHealth{get; private set;} //8
        public double Tax {get; private set;}       //9
        //public double TotalDeductions{get; private set;}

        public double Pagibig { get; private set; } //10
        public double HazardPay { get; private set;}    //11
        public double Clothing { get; private set;}     //12
        public double Quarter {get; private set;}       //13
        public double Laundry { get; private set;}      //14
        public double Pera { get; private set; }        //15

        //private double pagibig;
        //private double hazardPay;
        //private double clothing;
        //private double quarter;
        //private double laundry;
        //private double pera;

        public double TotalSalary{get; private set;}    //16
        public double TotalDeductions       
        {
            get 
            {
                return Deductions.GetTotalDeductions(GrossPay);    
            }
        }

        public double TotalAllowances
        {
            get
            {
                return Allowances.GetTotalAllowances(GrossPay);
            }
        }

        public Personnel(string firstName = "Juan", string lastName = "Dela Cruz", string position = "PO1")

        {
            //Default HireDate is when creating an instance of the object
            HireDate = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
            Position = position;

        }

        //Methods

        private void SetLongPay(DateTime hireDate)
        {
            int yearsOfService = DateTime.Now.Year - hireDate.Year;

            switch (position)
            {

              case "PO1":
                {
                    if (yearsOfService >= 5 && yearsOfService < 10)
                    {
                        LongPay = 1483.00;
                    }
                    else if (yearsOfService >= 10 && yearsOfService < 15)
                    {
                         LongPay = 3115.00;
                    }
                    else if (yearsOfService >= 15 && yearsOfService < 20)
                    {
                        LongPay = 4910.00;
                    }
                    else if (yearsOfService >= 20 && yearsOfService < 25 )
                    {
                        LongPay = 6884.00;
                    }
                    else if (yearsOfService >= 25 && yearsOfService < 30 )
                    {
                        LongPay = 7417.00;
                    }
	
                    

                    break;



                }

               case "PO2":
                {
                    if (yearsOfService >= 5 && yearsOfService < 10)
                    {
                        LongPay = 1693.00; 
                    }
                    else if (yearsOfService >= 10 && yearsOfService < 15)
                    {
                        LongPay = 3556.00;
                    }
                    else if (yearsOfService >= 15 && yearsOfService < 20)
                    {
                        LongPay = 5605.00;
                    }
                    else if (yearsOfService >= 20 && yearsOfService < 25)
                    {
                        LongPay = 7859.00;
                    }
                    else if (yearsOfService >= 25 && yearsOfService < 30)
                    {
                        LongPay = 8467.00;
                    }


                    break;            

                }

              case "PO3":
               {
                    if (yearsOfService >= 5 && yearsOfService < 10)
                    {
                        LongPay = 1867.00;
                    }
                    else if (yearsOfService >= 10 && yearsOfService < 15)
                    {
                        LongPay = 3920;
                    }
                    else if (yearsOfService >= 15 && yearsOfService < 20 )
                    {
                        LongPay = 6178.00;
                    }
                    else if (yearsOfService >= 20 && yearsOfService < 25 )
                    {
                        LongPay = 8662.00;
                    }
                    else if (yearsOfService >= 25 && yearsOfService < 30)
                    {
                        LongPay = 9333.00;
                    }


                   break;
               }

             case "SPO1":
                 {
                    if (yearsOfService >= 5 && yearsOfService < 10)
                    {
                        LongPay = 2171.00;
                    }
                    else if (yearsOfService >= 10 && yearsOfService < 15 )
                    {
                        LongPay = 4559.00;
                    }
                    else if (yearsOfService >= 15 && yearsOfService < 20)
                    {
                        LongPay = 7186.00;
                    }
                    else if (yearsOfService >= 20 &&yearsOfService < 25 )
                    {
                        LongPay = 1076.00;
                    }
                    else if (yearsOfService >= 25 && yearsOfService < 30)
                    {
                        LongPay = 10856.00;
                    }

                     break;
                     
    
                 }

             case "SPO2":
                 {
                     if (yearsOfService >= 5 && yearsOfService < 10)
                     {
                         LongPay = 2351.00;
                     }
                     else if (yearsOfService >= 10 && yearsOfService < 15)
                     {
                         LongPay = 4938.00;
                     }
                     else if (yearsOfService >= 15 && yearsOfService < 20)
                     {
                         LongPay = 7783.00;
                     }
                     else if (yearsOfService >= 20 && yearsOfService < 25)
                     {
                         LongPay = 10912.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 30)
                     {
                         LongPay = 11757.00;
                     }

                     break;


                 }

             case "SPO3":
                 {
                     if (yearsOfService >= 5 && yearsOfService < 10)
                     {
                         LongPay = 2539.00;
                     }
                     else if (yearsOfService >= 10 && yearsOfService < 15)
                     {
                         LongPay = 5333.00;
                     }
                     else if (yearsOfService >= 15 && yearsOfService < 20)
                     {
                         LongPay = 8405.00;
                     }
                     else if (yearsOfService >= 20 && yearsOfService < 25)
                     {
                         LongPay = 11785.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 30)
                     {
                         LongPay = 12697.00;
                     }

                     break;


                 }

             case "SPO4":
                 {
                     if (yearsOfService >= 5 && yearsOfService < 10)
                     {
                         LongPay = 2743.00;
                     }
                     else if (yearsOfService >= 10 && yearsOfService < 15)
                     {
                         LongPay = 5759.00;
                     }
                     else if (yearsOfService >= 15 && yearsOfService < 20)
                     {
                         LongPay = 9078.00;
                     }
                     else if (yearsOfService >= 20 && yearsOfService < 25)
                     {
                         LongPay = 12728.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 30)
                     {
                         LongPay = 13713.00;
                     }

                     break;


                 }

             case "PINSP":
                 {
                     if (yearsOfService >= 5 && yearsOfService < 10)
                     {
                         LongPay = 3234.00;
                     }
                     else if (yearsOfService >= 10 && yearsOfService < 15)
                     {
                         LongPay = 6792.00;
                     }
                     else if (yearsOfService >= 15 && yearsOfService < 20)
                     {
                         LongPay = 10705.00;
                     }
                     else if (yearsOfService >= 20 && yearsOfService < 25)
                     {
                         LongPay = 15009.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 30)
                     {
                         LongPay = 16171.00;
                     }

                     break;

                 }


             case "PSINSP":
                 {
                     if (yearsOfService >= 5 && yearsOfService < 10)
                     {
                         LongPay = 3531.00;
                     }
                     else if (yearsOfService >= 10 && yearsOfService < 15)
                     {
                         LongPay = 7416.00;
                     }
                     else if (yearsOfService >= 15 && yearsOfService < 20)
                     {
                         LongPay = 11688.00;
                     }
                     else if (yearsOfService >= 20 && yearsOfService < 25)
                     {
                         LongPay = 16388.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 30)
                     {
                         LongPay = 17656.00;
                     }

                     break;
                 }

             case "PCINSP":
                 {
                     if (yearsOfService >= 5 && yearsOfService < 10)
                     {
                         LongPay = 3731.00;
                     }
                     else if (yearsOfService >= 10 && yearsOfService < 15)
                     {
                         LongPay = 7836.00;
                     }
                     else if (yearsOfService >= 15 && yearsOfService < 20)
                     {
                         LongPay = 12351.00;
                     }
                     else if (yearsOfService >= 20 && yearsOfService < 25)
                     {
                         LongPay = 17317.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 30)
                     {
                         LongPay = 18657.00;
                     }

                     break;


                 }

             case "PSUPT":
                 {
                     if (yearsOfService >= 5 && yearsOfService < 10)
                     {
                         LongPay = 4030.00;
                     }
                     else if (yearsOfService >= 10 && yearsOfService < 15)
                     {
                         LongPay = 8463.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 20)
                     {
                         LongPay = 13339.00;
                     }
                     else if (yearsOfService >= 20 && yearsOfService < 25)
                     {
                         LongPay = 18702.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 30)
                     {
                         LongPay = 20149.00;
                     }

                     break;
                 }

                case "PSSUPT":
                 {
                     if (yearsOfService >= 5 && yearsOfService < 10)
                     {
                         LongPay = 4030.00;
                     }
                     else if (yearsOfService >= 10 && yearsOfService < 15)
                     {
                         LongPay = 8463.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 20)
                     {
                         LongPay = 13339.00;
                     }
                     else if (yearsOfService >= 20 && yearsOfService < 25)
                     {
                         LongPay = 18702.00;
                     }
                     else if (yearsOfService >= 25 && yearsOfService < 30)
                     {
                         LongPay = 20149.00;
                     }

                     break;

                 }
            default:
                break;

        }
     }

     private void SetGrossPay(string Position)
     {

         switch (Position)
         {
            case "PO1":
                {
                    GrossPay = 14834.00;
                    break;
                }
                    
            case "PO2":
                {
                    GrossPay = 16934.00;
                    break;
                }
            case "PO3":
                {
                    GrossPay = 18665.00;
                    break;
                }
            case "SPO1":
                {
                    GrossPay = 21711.00;
                    break;
                }
            case "SPO2":
                {
                    GrossPay = 23513.00;
                    break;
                }
            case "SPO3":
                {
                    GrossPay = 25394.00;
                    break;
                }
            case "SPO4":
                {
                    GrossPay = 27425.00;
                    break;
                }
            case "PINSP":
                {
                    GrossPay = 32341.00;
                    break;
                }
            case "PSINSP":
                {
                    GrossPay = 35312.00;
                    break;
                }
            case "PCINSP":
                {
                    GrossPay = 37313.00;
                    break;
                }
            case "PSUPT":
                {
                    GrossPay = 40298.00;
                    break;
                }
            default:
                 break;
                    
         }            

     }


      //Getting the LongPay where LongPay is not a property, a user can set
        
      //public double GetLongPay()
      //      {
      //          return LongPay;
      //      } 
      
      //Getting the GrossPay where GrossPay is not a property, a user can set
        //public double GetGrossPay()
        //    {
        //        return GrossPay;
        //    }
       
      //private void SetAllownaces()
      //{
      //    clothing = Allowances.GetClothing(grossPay);
      //    quarter = Allowances.GetQuarter(grossPay);
      //    laundry = Allowances.GetLaundry(grossPay);
      //    pera = Allowances.GetPera(grossPay);
      //}
      
      //public double GetClothing()
      //{
      //    Clothing = Allowances.GetClothing(GrossPay);
      //    return Clothing;
      //}
      //public double GetQuarter()
      //{
      //    Quarter = Allowances.GetQuarter(GrossPay);
      //    return Quarter;
      //}
      //public double GetLaundry()
      //{
      //    Laundry = Allowances.GetLaundry(GrossPay);
      //    return Laundry;
      //}
      //public double GetPera()
      //{
      //    Pera = Allowances.GetPera(GrossPay);
      //    return Pera;
      //}
      //public double GetHazardPay()
      //{
      //    HazardPay = Allowances.GetHazardPay(GrossPay);
      //    return HazardPay;
      //}

      private void SetTotalAllowances()
     {
         Clothing = Allowances.GetClothing(GrossPay);
         Quarter = Allowances.GetQuarter(GrossPay);
         Laundry = Allowances.GetLaundry(GrossPay);
         Pera = Allowances.GetPera(GrossPay);
         HazardPay = Allowances.GetHazardPay(GrossPay);
     }

      private void SetTotalDeductions()
      {
          Sgti = Deductions.GetSGTI(GrossPay);
          Tax = Deductions.GetTax(GrossPay);
          PhilHealth = Deductions.GetPhilHealth(GrossPay);
          Pagibig = Deductions.GetPagibig(GrossPay);
          //TotalDeductions = Sgti + Tax + PhilHealth + Pagibig;
      }
      //public double GetSGTI()
      //{
      //    return Sgti;
      //}

      //public double GetTax()
      //{
      //    return Tax;
      //}
      //public double GetPhilHealth()
      //{
      //    return PhilHealth;
      //}
      //public double GetPagibig()
      //{
      //    return Pagibig;
      //}


      //public double TotalDeduction
      //{
      //    get
      //    {
      //        return Deductions.SetTotalDeductions(GrossPay);
      //    }
      //}

      //public double GetTotalSalary()

        private void SetTotalSalary()
      {
          //double TotalSalary = 0;
          TotalSalary = GrossPay + LongPay + Allowances.GetTotalAllowances(GrossPay) -
    Deductions.GetTotalDeductions(GrossPay);

          //return TotalSalary;
      }
                                
    }
}
