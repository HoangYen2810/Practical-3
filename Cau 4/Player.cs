using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau4
{
    class Player : Person
    {
        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                if (value < 1)
                    number = 0;
                else
                    number = value;
            }
        }

        public string position;
        public string Position
        {
            get { return position; }
            set
            {
                if (value != "")
                    position = value;
                else
                    position = "";
            }
        }

        public Player(int number, string position)
        {
            Number = number;
            Position = position;
        }
    }
}