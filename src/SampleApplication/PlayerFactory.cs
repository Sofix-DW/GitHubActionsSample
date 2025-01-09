using SampleApplication.Info;

namespace SampleApplication;

/// <summary>
/// Factory player information class
/// </summary>
public class PlayerFactory
{
    /// <summary>
    /// Create Player
    /// </summary>
    /// <param name="number">Player number</param>
    /// <returns>Player information</returns>
    public static PlayerInfo CreatePlayer(int number)
    {
        Console.Write($"Please enter the name of the Player{number}: ");
        var name = Console.ReadLine();
        return new PlayerInfo(name ?? "Unknown");
    }

    /// <summary>
    /// Create a player list
    /// </summary>
    /// <param name="count">Number of players to create</param>
    /// <returns>Join players</returns>
    public static List<PlayerInfo> CreatePlayers(int count)
    {
        List<PlayerInfo> players = [];

        for (var i = 1; i <= count; i++)
        {
            players.Add(CreatePlayer(i));
        }

        return players;
    }
}