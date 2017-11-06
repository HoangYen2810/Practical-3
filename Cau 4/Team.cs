using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau4
{
    class Team
    {
        private string nameOfTeam;
        public string NameOfTeam
        {
            get { return nameOfTeam; }
            set
            {
                if (value != "")
                    nameOfTeam = value;
                else
                    nameOfTeam = "";
            }
        }

        public List<Player> players { get; set; }
        public Coach coach { get; set; }

        public Team(string nameOfTeam, int year, int number, string position)
        {
            NameOfTeam = nameOfTeam;
            coach = new Coach(year);
            players.Add(new Player(number, position));
        }

        public void Display()
        {
            Console.WriteLine("Name of team: " + nameOfTeam);
            Console.WriteLine("Year: " + coach.Year);
            Console.WriteLine(players);
        }
    }
}