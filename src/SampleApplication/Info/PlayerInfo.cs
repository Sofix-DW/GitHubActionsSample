namespace SampleApplication.Info;

/// <summary>
/// Player information class
/// </summary>
public class PlayerInfo
{
    private readonly Random _random;

    /// <summary>
    /// Playser name
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// Dice Roll Results
    /// </summary>
    public int Score { get; private set; }
    /// <summary>
    /// Total score
    /// </summary>
    public int TotalScore { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    public PlayerInfo(string name)
    {
        Name = name;
        _random = new Random();
    }

    /// <summary>
    /// Roll the dice
    /// </summary>
    public void RollDice()
    {
        Score = _random.Next(1, 7); // 1から6の値を生成
    }

    /// <summary>
    /// Add Score
    /// </summary>
    public void AddScore()
    {
        TotalScore++;
    }
}
