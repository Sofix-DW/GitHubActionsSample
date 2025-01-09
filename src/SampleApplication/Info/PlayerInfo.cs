namespace SampleApplication.Info;

/// <summary>
/// Player information class
/// </summary>
public class PlayerInfo(string name)
{
    private readonly Random _random = new();

    /// <summary>
    /// Player name
    /// </summary>
    public string Name { get; private set; } = name;
    /// <summary>
    /// Dice Roll Results
    /// </summary>
    public int Score { get; private set; }
    /// <summary>
    /// Total score
    /// </summary>
    public int TotalScore { get; private set; }

    /// <summary>
    /// Roll the dice
    /// </summary>
    public void RollDice()
    {
        Score = _random.Next(1, 7); // Generate values from 1 to 6
    }

    /// <summary>
    /// Add Score
    /// </summary>
    public void AddScore()
    {
        TotalScore++;
    }
}
