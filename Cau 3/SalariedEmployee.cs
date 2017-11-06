using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    class SalariedEmployee : Employee
    {
        protected double salary;

        public SalariedEmployee(string name, double salary, int year, int month, int day) : base(name, year, month, day)
        {
            this.salary = salary;
        }

        public new string DisplayStat()
        {
            return name + " - " + salary + "\n"
                   + date.year + "-" + date.month + "-" + date.day;
        }
    }
}