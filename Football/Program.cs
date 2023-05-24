using Football;

Random random = new Random();

string[] goalkeeperNames = { "Atanas", "Georgi", "Nikola", "Petar", "Aleksandar", "Stanko", "Dimitar", "Vasil" };
string[] positions = { "Goalkeeper", "Defender", "Midfielder", "Striker" };

FootballPlayer[] team1Players = new FootballPlayer[11];

for (int i = 0; i < 11; i++)
{
    string position = positions[random.Next(positions.Length)];
    string playerName = goalkeeperNames[random.Next(goalkeeperNames.Length)];
    int playerNumber = random.Next(1, 30);
    int playerAge = random.Next(18, 30);
    int playerHeight = random.Next(160, 200);

    switch (position)
    {
        case "Goalkeeper":
            team1Players[i] = new Goalkeeper(playerName, playerAge, playerNumber, playerHeight);
            break;
        case "Defender":
            team1Players[i] = new Defender(playerName, playerAge, playerNumber,  playerHeight);
            break;
        case "Midfielder":
            team1Players[i] = new Midfielder(playerName, playerAge, playerNumber,  playerHeight);
            break;
        case "Striker":
            team1Players[i] = new Striker(playerName, playerAge, playerNumber,  playerHeight);
            break;
    }
}
Team team1 = new Team(new Coach("Ivan", 23), team1Players);

string[] goalkeeperNames2 = { "Martin", "Ivan", "Simeon", "Borislav", "Vladimir", "Stefan", "Dimitar", "Georgi" };

FootballPlayer[] team2Players = new FootballPlayer[11];

for (int i = 0; i < 11; i++)
{
    string position = positions[random.Next(positions.Length)];
    string playerName = goalkeeperNames2[random.Next(goalkeeperNames2.Length)];
    int playerAge = random.Next(18, 38);
    int playerNumber = random.Next(1, 100);
    int playerHeight = random.Next(160, 200);

    switch (position)
    {
        case "Goalkeeper":
            team2Players[i] = new Goalkeeper(playerName, playerAge, playerNumber, playerHeight);
            break;
        case "Defender":
            team2Players[i] = new Defender(playerName, playerAge, playerNumber, playerHeight);
            break;
        case "Midfielder":
            team2Players[i] = new Midfielder(playerName, playerAge, playerNumber,  playerHeight);
            break;
        case "Striker":
            team2Players[i] = new Striker(playerName, playerAge, playerNumber, playerHeight);
            break;
    }
}
Team team2 = new Team(new Coach("Stoqn", 23), team2Players);


Referee referee = new Referee("Rikardo", 29);

Game game = new Game(team1, team2, referee);
FootballPlayer randomPlayer1 = team1.Players[random.Next(team1.Players.Length)];
FootballPlayer randomPlayer2 = team2.Players[random.Next(team2.Players.Length)];
game.AddGoal(10, randomPlayer1);
game.AddGoal(30, randomPlayer2);
int team1Score = random.Next(5);
int team2Score = random.Next(5);

string result = $"{team1Score}-{team2Score}";
Team winner = (team1Score > team2Score) ? team1 : team2;
game.SetResult(result, winner);

Console.WriteLine("Average age in team 1 is : {0}", team1.GetAverageAge());
Console.WriteLine("Average age in team 2 is : {0}", team2.GetAverageAge());

game.PrintMatchDetails();

Console.ReadLine();