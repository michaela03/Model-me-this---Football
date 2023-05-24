using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Team
    {
        public Coach Coach { get; set; }
        public FootballPlayer[] Players { get; set; }

        public Team(Coach coach, FootballPlayer[] players)
        {
            if (players.Count() != 11 && players.Count() >22)
            {
                throw new ArgumentException("A team must have exactly 11 players.");
            }

            Coach = coach;
            Players = players;
        }

        public int  GetAverageAge()

        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }

            return ((int)totalAge / Players.Count());
        }

    }


}
