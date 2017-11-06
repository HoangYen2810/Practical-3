using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    class WagedEmployee : Employee
    {
        private double wage;
        private double hours;

        public WagedEmployee(string name, double wage, double hours,
                             int year, int month, int day) : base(name, year, month, day)
        {
            this.wage = wage;
            this.hours = hours;
        }

        public new string DisplayStat()
        {
            return name + " - " + wage + " - " + hours + "\n"
                   + date.year + "-" + date.month + "-" + date.day;
        }
    }
}