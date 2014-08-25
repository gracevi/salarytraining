using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSalary
{
    //Take note, this is a Static Class
    public static class Deductions
    {
        //Static Classes, use static Methods
        public static double GetTotalDeductions(double grossPay)
        {
            double totalDeductions = GetSSS(grossPay) + GetPhilHealth(grossPay) + GetTax(grossPay);

            return totalDeductions;
        }


        public static double GetSSS(double grossPay)
        {
            //EDIT
            return 100;
        }

        public static double GetPhilHealth(double grossPay)
        {
            //DO Logic for PhilHealth
            return 100;
        }

        public static double GetTax(double grossPay)
        {
            //DO Tax Computation
            return 3000;
        }

    }
}
