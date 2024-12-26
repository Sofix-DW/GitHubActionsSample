using SampleApplication.Info;

namespace SampleApplication.Test
{
    public class PlayerInfoTest
    {
        [Fact(DisplayName = "名前が正しく反映されているか")]
        public void ConstructorTest()
        {
            var playerName = "Test Player";

            // Arrange
            var player = new PlayerInfo(playerName);

            // Assert
            Assert.Equal(playerName, player.Name);
        }

        [Fact(DisplayName = "ダイスロール範囲内")]
        public void RollDice_ShouldGenerateNumberBetween1And6()
        {
            // Arrange
            var player = new PlayerInfo("Test Player");

            // Act
            player.RollDice();

            // Assert
            Assert.InRange(player.Score, 1, 6);
        }

        [Fact(DisplayName = "得点の加算が正しいか")]
        public void AddScore_ShouldIncreaseTotalScore()
        {
            // Arrange
            var player = new PlayerInfo("Test Player");

            // Act
            player.AddScore();
            player.AddScore();

            // Assert
            Assert.Equal(2, player.TotalScore);
        }
    }
}