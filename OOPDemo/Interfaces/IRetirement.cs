using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo.Interfaces
{
    public interface IRetirement
    {


        DateTime JoinedToRetirement { get; set; }
        int DaysToRetirement { get; }
        int CalculateCompulsoryPaymentInDays();



    }
}
