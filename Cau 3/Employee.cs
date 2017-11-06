using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    class Employee
    {
        protected string name;
        protected Address address;
        protected Date date;

        public Employee(string name, int year, int month, int day)
        {
            this.name = name;
            date = new Date(year, month, day);
        }

        ~Employee() { }

        public void SetAddress(string city, string street)
        {
            address = new Address(city, street);
        }

        public string DisplayStat()
        {
            return name + "\n" + address.city + " - " + address.street + "\n"
                   + date.year + "-" + date.month + "-" + date.day;
        }
    }
}