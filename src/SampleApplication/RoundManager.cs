using SampleApplication.Info;

namespace SampleApplication;

/// <summary>
/// Class to manage rounds
/// </summary>
/// <remarks>
/// Constructor
/// </remarks>
/// <param name="players">Join player list</param>
public class RoundManager(List<PlayerInfo> players)
{
    private readonly List<PlayerInfo> _players = players;

    /// <summary>
    /// Play a round
    /// </summary>
    /// <param name="roundNumber"></param>
    public void PlayRound(int roundNumber)
    {
        // 全プレイヤーがダイスを振る
        foreach (PlayerInfo player in _players)
        {
            player.RollDice();
            Console.WriteLine($"{player.Name}のロール: {player.Score}");
        }

        // ラウンド勝者を決定
        int maxScore = -1;
        List<PlayerInfo> roundWinners = new List<PlayerInfo>();

        foreach (PlayerInfo player in _players)
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
