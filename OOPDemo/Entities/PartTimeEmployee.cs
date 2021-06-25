using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo.Entities
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string firstName, 
                                string lastName, 
                                DateTime startDate) : base(firstName, lastName)
        {
            StartDate = startDate;
        }

        public int HoursWorked { get; set; }
        public decimal HourlyPayment { get; set; }
        public int OverHours { get; set; }



        public override string GetFullNameWithStatus()
        {
            return "PT - " + base.GetFullName();
        }
        //After taxes
        public override decimal GetNetSalary()
        {
            decimal netSalary = GetSalary();
            netSalary  = netSalary + (OverHours * HourlyPayment * 1.2m);
            netSalary *= 0.87m;
            netSalary += childSupport * NumberOfChildren;
            return netSalary;
        }

        public override decimal GetSalary()
        {
            return HourlyPayment * HoursWorked;
        }


    }
}
