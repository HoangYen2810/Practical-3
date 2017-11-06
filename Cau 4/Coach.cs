using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau4
{
    class Coach : Person
    {
        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1)
                    year = 0;
                else
                    year = value;
            }
        }

        public Coach(int year)
        {
            Year = year;
        }
    }
}