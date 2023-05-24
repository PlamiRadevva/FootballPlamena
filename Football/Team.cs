using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public double AvarageAge
        {
            get
            {
                int totalAge = 0;
                foreach (var player in Players)
                {
                    totalAge += player.Age;
                }
                return (double)totalAge / Players.Count;
            }
        }
    }
}
