using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Progam
    {
        static void Main()
        {
            FootballPlayer player1 = new FootballPlayer(4, 1.8, "Николай Кънчев", 28);
            FootballPlayer player2 = new FootballPlayer(10, 1.85, "Иван Иванов", 25);
            FootballPlayer player3 = new FootballPlayer(7, 1.78, "Петър Петров", 28);
            FootballPlayer player4 = new FootballPlayer(9, 1.92, "Георги Георгиев", 30);
            FootballPlayer player5 = new FootballPlayer(5, 1.80, "Мартин Мартинов", 23);
            FootballPlayer player6 = new FootballPlayer(3, 1.75, "Андрей Андреев", 27);
            FootballPlayer player7 = new FootballPlayer(11, 1.88, "Николай Николов", 31);
            FootballPlayer player8 = new FootballPlayer(8, 1.82, "Димитър Димитров", 29);
            FootballPlayer player9 = new FootballPlayer(6, 1.79, "Станислав Станиславов", 26);
            FootballPlayer player10 = new FootballPlayer(2, 1.76, "Илия Илиев", 24);
            FootballPlayer player11 = new FootballPlayer(1, 1.83, "Александър Александров", 32);




            Coach coach = new Coach { Name = "Coach 1", Age = 45 };

            List<FootballPlayer> PlayersTeam1 = new List<FootballPlayer>() { player1, player2, player3, player4, player5 };
            List<FootballPlayer> PlayersTeam2 = new List<FootballPlayer>() { player6, player7, player7, player8, player9, player10, player11 };
            // Create teams

            Team team1 = new Team { Coach = coach, Players = PlayersTeam1 } ;
            Team team2 = new Team { Coach = coach, Players = PlayersTeam2 } ;
            // ...

            // Calculate average age of team1 players
            double averageAge = team1.AvarageAge;
            Console.WriteLine("Average age of team1 players: " + averageAge);

            // Create referee
            Referee referee = new Referee { Name = "Referee 1", Age = 35 };

            // Create game
            Game game = new Game { Team1 = team1, Team2 = team2, Referee = referee };
            // ...

            // Отпечатване на резултата от мача
            Console.WriteLine("Game Result: " + game.Result);
            Console.WriteLine("Winner: " + game.Winner);
            Console.ReadKey();
        }
    }
}
