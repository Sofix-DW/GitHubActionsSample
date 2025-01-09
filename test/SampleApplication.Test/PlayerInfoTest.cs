using SampleApplication.Info;

namespace SampleApplication.Test
{
    public class PlayerInfoTest
    {
        [Fact(DisplayName = "Testing to see if names are reflected correctly")]
        public void ConstructorTest()
        {
            var playerName = "Test Player";

            // Arrange
            var player = new PlayerInfo(playerName);

            // Assert
            Assert.Equal(playerName, player.Name);
        }

        [Fact(DisplayName = "Test for die roll range")]
        public void RollDice_ShouldGenerateNumberBetween1And6()
        {
            // Arrange
            var player = new PlayerInfo("Test Player");

            // Act
            player.RollDice();

            // Assert
            Assert.InRange(player.Score, 1, 6);
        }

        [Fact(DisplayName = "Test for correct addition of scores")]
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