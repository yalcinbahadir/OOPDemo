using OOPDemo.Entities;
using OOPDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee fte = new FullTimeEmployee("Ali", "Alper", new DateTime(2012, 09, 15)) 
            {   MaritalStatus = MaritalStatus.Married,
                AnnualSalary=45000,
                NumberOfChildren=2, 
                JoinedToRetirement=new DateTime(2012, 09, 15) 
            };
            Employee pte = new PartTimeEmployee("Tarik", "Emre", new DateTime(2013, 03, 01)) 
            { MaritalStatus = MaritalStatus.Married,  
                HourlyPayment = 15, 
                HoursWorked=80, 
                OverHours=8, 
                NumberOfChildren = 2,
                JoinedToRetirement = new DateTime(2013, 03, 01)
            };

            List<Employee> employees = new List<Employee>
            {
                fte, pte
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("............Retirements .........................");
            List<IRetirement> clients = new List<IRetirement> { fte, pte };

            foreach (var client in clients)
            {
                Console.WriteLine($" Client :{ (client as Employee).GetFullNameWithStatus()} JoinedToRetirement :{client.JoinedToRetirement.ToShortDateString()} DaysToRetirement : {client.DaysToRetirement}");
                   
            }


            Console.ReadLine();
        }
    }
}
