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
    /// <param name="number"></param>
    /// <returns></returns>
    public static PlayerInfo CreatePlayer(int number)
    {
        Console.Write($"プレイヤー{number}の名前を入力してください: ");
        string? name = Console.ReadLine();
        return new PlayerInfo(name ?? "Unknown");
    }

    /// <summary>
    /// Create a player list
    /// </summary>
    /// <param name="count">Number of players to create</param>
    /// <returns></returns>
    public static List<PlayerInfo> CreatePlayers(int count)
    {
        List<PlayerInfo> players = [];

        for (int i = 1; i <= count; i++)
        {
            players.Add(CreatePlayer(i));
        }

        return players;
    }
}