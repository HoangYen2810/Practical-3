using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau4
{
    class Person
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                    name = value;
                else
                    name = "";
            }
        }
        protected int age { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 7)
                    age = value;
                else
                    age = 0;
            }
        }

        protected string nationality { get; set; }
        public string Nationality
        {
            get { return name; }
            set
            {
                if (value != "")
                    nationality = value;
                else
                    nationality = "";
            }
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Nationality: " + nationality);
        }
    }
}