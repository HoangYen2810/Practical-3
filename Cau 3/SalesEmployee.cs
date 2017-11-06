using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    class SalesEmployee : SalariedEmployee
    {
        private double commission;
        private double sales;

        public SalesEmployee(string name, double salary, double commission, double sales,
                             int year, int month, int day) : base(name, salary, year, month, day)
        {
            this.commission = commission;
            this.sales = sales;
        }

        public new string DisplayStat()
        {
            return name + " - " + salary + " - " + commission + " - " + sales + "\n"
                   + date.year + "-" + date.month + "-" + date.day;
        }
    }
}