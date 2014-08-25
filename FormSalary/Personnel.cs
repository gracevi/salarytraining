using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormSalary
{
    public class Personnel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _position;

        public string Position
        {
            get { return _position; }
            set
            {
                _position = value;

                SetGrossPay(_position);

                //At this Point the Gross Pay has been updated

                SetDeductions();
                SetTotalSalary();
            }
        }


        public double GrossPay { get; private set; }

        private DateTime _hireDate;
        public DateTime HireDate
        {
            get { return _hireDate; }
            set
            {
                _hireDate = value;


                SetLongPay(_hireDate);

            }
        }

        public double LongPay { get; private set; }

        public double Sss { get; private set; }
        public double PhilHealth { get; private set; }
        public double Tax { get; private set; }
        public double TotalDeductions { get; private set; }

        public double TotalSalary { get; private set; }

        public Personnel(string firstName = "Juan", string lastName = "Dela Cruz", string position = "PO1")
        {
            //Default HireDate is when creating an instane of the object
            HireDate = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
            Position = position;

        }

        //METHODS

        private void SetLongPay(DateTime hireDate)
        {
            int yearsOfService = DateTime.Now.Year - hireDate.Year;

            switch (Position)
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
                        //Continue the Else If
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
                        //Continue the Else If
                        break;
                    }
            }

        }

        private void SetGrossPay(string position)
        {

            switch (position)
            {
                case "PO1":
                    {
                        GrossPay = 14834.00;
                        break;
                    }

                case "PO2":
                    {
                        GrossPay = 16000.00;
                        break;
                    }
            }
        }

        private void SetDeductions()
        {
            Sss = Deductions.GetSSS(GrossPay);
            Tax = Deductions.GetTax(GrossPay);
            PhilHealth = Deductions.GetPhilHealth(GrossPay);
            TotalDeductions = Sss + Tax + PhilHealth;
        }

        private void SetTotalSalary()
        {
            TotalSalary = GrossPay + LongPay - TotalDeductions;
        }

    }

}
