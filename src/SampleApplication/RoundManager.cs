using SampleApplication.Info;

namespace SampleApplication;

/// <summary>
/// Class to manage rounds
/// </summary>
public class RoundManager
{
    private List<PlayerInfo> _players;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="players"></param>
    public RoundManager(List<PlayerInfo> players)
    {
        _players = players;
    }

    /// <summary>
    /// Play a round
    /// </summary>
    /// <param name="roundNumber"></param>
    public void PlayRound(int roundNumber)
    {
        // 全プレイヤーがダイスを振る
        foreach (var player in _players)
        {
            player.RollDice();
            Console.WriteLine($"{player.Name}のロール: {player.Score}");
        }

        // ラウンド勝者を決定
        var maxScore = -1;
        var roundWinners = new List<PlayerInfo>();

        foreach (var player in _players)
        {
            if (player.Score > maxScore)
            {
                maxScore = player.Score;
                roundWinners.Clear();
                roundWinners.Add(player);
            }
            else if (player.Score == maxScore)
            {
                roundWinners.Add(player);
            }
        }

        // 勝者の処理
        if (roundWinners.Count == 1)
        {
            roundWinners[0].AddScore();
            Console.WriteLine($"{roundWinners[0].Name}がラウンド {roundNumber} に勝利しました！");
        }
        else
        {
            Console.WriteLine($"ラウンド {roundNumber} は引き分けです！");
        }
    }
}
