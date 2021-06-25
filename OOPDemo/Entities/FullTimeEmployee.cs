using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo.Entities
{
    public class FullTimeEmployee : Employee
    {
        public decimal AnnualSalary { get; set; }

        public FullTimeEmployee(string firstName, 
                               string lastName,
                               DateTime startDate):base(firstName, lastName)
        {
            StartDate = startDate;
        }


        public override string GetFullNameWithStatus()
        {
            return "FT - "+base.GetFullName();
        }

        public override decimal GetNetSalary()
        {
            decimal netSalary = GetSalary();
            netSalary *= 0.82m;
            netSalary += childSupport*NumberOfChildren;
            return netSalary;
        }

        public override decimal GetSalary()
        {
            return AnnualSalary / 12;
        }



    }
}
