using OOPDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo.Entities
{
    public enum MaritalStatus {Married, Singel, Others }
    public abstract class Employee : IRetirement
    {
        protected const decimal childSupport = 125;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public DateTime StartDate { get; set; }
        public int NumberOfChildren { get; set; }
        public DateTime JoinedToRetirement { get; set; }

        public int DaysToRetirement => CalculateCompulsoryPaymentInDays();

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public abstract string GetFullNameWithStatus();
        public abstract decimal GetNetSalary();
        public abstract decimal GetSalary();


        public int CalculateCompulsoryPaymentInDays()
        {
            TimeSpan timeSpan = JoinedToRetirement.AddYears(20).Subtract(DateTime.Today);
            var totalMonths = timeSpan.TotalDays;
            return (int)totalMonths;
        }


        public override string ToString()
        {
            return $" Employee: {GetFullNameWithStatus()} - MaritalStatus : {MaritalStatus} Children : {NumberOfChildren} date : {StartDate.ToShortDateString()} - Salary: {GetSalary()} - Net Salary : {GetNetSalary()} DaysToRetirement: {DaysToRetirement}";
        }

    }
}
