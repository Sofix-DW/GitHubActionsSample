using SampleApplication.Info;

namespace SampleApplication;

/// <summary>
/// Class to manage rounds
/// </summary>
/// <param name="players">Join player list</param>
public class RoundManager(List<PlayerInfo> players)
{
    private readonly List<PlayerInfo> _players = players;

    /// <summary>
    /// Play a round
    /// </summary>
    /// <param name="roundNumber">Round number</param>
    public void PlayRound(int roundNumber)
    {
        // All players roll dice
        foreach (var player in _players)
        {
            player.RollDice();
            Console.WriteLine($"{player.Name} roll results: {player.Score}");
        }

        // Round winners are determined
        var maxScore = -1;
        List<PlayerInfo> roundWinners = [];

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

        // Dealing with winners
        if (roundWinners.Count == 1)
        {
            roundWinners[0].AddScore();
            Console.WriteLine($"{roundWinners[0].Name} won round {roundNumber}!");
        }
        else
        {
            Console.WriteLine($"Round {roundNumber} is a draw.");
        }
    }
}
