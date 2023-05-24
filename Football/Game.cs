using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Game
    {
        private Team team1;
        private Team team2;
        private Referee referee;
        public List<string> goals = new List<string>();
        private string result;
        private Team winner;

        public Game(Team team1, Team team2, Referee referee)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.referee = referee;

        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            string goal = $"{minute}': {player.Name}";
            goals.Add(goal);
        }

        public void SetResult(string result, Team winner)
        {
            this.result = result;
            this.winner = winner;
        }

        public void PrintMatchDetails()
        {
            Console.WriteLine("Match Details:");
            Console.WriteLine();
            Console.WriteLine("Team 1:");
            foreach (var player in team1.Players)
            {
                Console.WriteLine("{0} - Number: {1}", player.Name, player.Number);
            }
            
            Console.WriteLine();
            Console.WriteLine("Team 2:");
            foreach (var player in team2.Players)
            {
                Console.WriteLine($"{player.Name} - Number: {player.Number}");
            }
            Console.WriteLine();
            Console.WriteLine("Referee: {0}",referee.Name);
            Console.WriteLine("Coach of team 1: {0}", team1.Coach.Name);
            Console.WriteLine("Coach of team 2: {0}", team2.Coach.Name);
            Console.WriteLine();
            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal);
            }
            Console.WriteLine();
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
            Console.WriteLine("Winner the team of the couch: {0}", winner.Coach.Name);
        }
    }




}
