// See https://aka.ms/new-console-template for more information
using SampleApplication;

Console.WriteLine("=== Dice Battle Games ===");

Console.Write("\nPlease enter the number of players: ");
int playerCount;
while (!int.TryParse(Console.ReadLine(), out playerCount) || playerCount <= 1)
{
    Console.WriteLine("\nEnter the number of active players (integer greater than or equal to 2):");
}

// Creating a player list
var players = PlayerFactory.CreatePlayers(playerCount);

Console.Write("\nPlease enter the number of rounds: ");
int totalRounds;
while (!int.TryParse(Console.ReadLine(), out totalRounds) || totalRounds <= 0)
{
    Console.WriteLine("Enter the number of valid rounds (integer greater than or equal to 1):");
}

Console.WriteLine("\nThe game is now set up.");
Console.WriteLine("\nNow let's start the game.");

Console.WriteLine("\n=== 3 ===");
Console.WriteLine("\n=== 2 ===");
Console.WriteLine("\n=== 1 ===");
Console.WriteLine("\n=== Redy... ===");
Console.WriteLine("\n=== Start!! ===");

// Create round management class
var roundManager = new RoundManager(players);

// Play by round
for (var round = 1; round <= totalRounds; round++)
{
    Console.WriteLine($"\n--- Rounds {round} ---");
    roundManager.PlayRound(round);
}

// Show final results
Console.WriteLine("\n=== Final Results ===");

// Rankings are determined by total points
var ranking = players.OrderByDescending(p => p.TotalScore).ToList();
for (var rank = 0; rank < ranking.Count; rank++)
{
    Console.WriteLine($"{rank + 1} place: {ranking[rank].Name} (Score: {ranking[rank].TotalScore})");
}

// Show winners
if (ranking.Count > 1 && ranking[0].TotalScore == ranking[1].TotalScore)
{
    Console.WriteLine("\nThe top is a draw!");
}
else
{
    Console.WriteLine($"\nChampionship: {ranking[0].Name}！!");
}

Console.WriteLine("\nEnd of game. Thank you for your hard work!");
