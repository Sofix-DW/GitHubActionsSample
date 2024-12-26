namespace SampleApplication.Info;

public class PlayerInfo
{
    private readonly Random _random;

    public string Name { get; private set; }
    public int Score { get; private set; }
    public int TotalScore { get; private set; }

    public PlayerInfo(string name)
    {
        Name = name;
        _random = new Random();
    }

    public void RollDice()
    {
        Score = _random.Next(1, 7); // 1から6の値を生成
    }

    public void AddScore()
    {
        TotalScore++;
    }
}
