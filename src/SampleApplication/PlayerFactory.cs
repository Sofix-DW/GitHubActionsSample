using SampleApplication.Info;

namespace SampleApplication;

public class PlayerFactory
{
    // プレイヤーを作成するメソッド
    public static PlayerInfo CreatePlayer(int number)
    {
        Console.Write($"プレイヤー{number}の名前を入力してください: ");
        var name = Console.ReadLine();
        return new PlayerInfo(name ?? "Unkown");
    }

    // プレイヤーリストを作成するメソッド
    public static List<PlayerInfo> CreatePlayers(int count)
    {
        var players = new List<PlayerInfo>();

        for (var i = 1; i <= count; i++)
        {
            players.Add(CreatePlayer(i));
        }

        return players;
    }
}