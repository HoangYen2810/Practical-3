using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    class Date
    {
        public int year;
        public int month;
        public int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string DisplayStat()
        {
            return year + "-" + month + "-" + day;
        }
    }
}