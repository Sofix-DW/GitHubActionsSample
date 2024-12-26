using System;
using System.IO;

namespace SampleApplication.Test
{
    public class PlayerFactoryTest
    {
        [Fact(DisplayName = "Factory Test")]
        public void CreatePlayers_ShouldReturnCorrectNumberOfPlayers()
        {
            var name1 = "Hoge1";
            var name2 = "Hoge2";
            var name3 = "Hoge3";
            var input1 = new StringReader($"{name1}\n{name2}\n{name3}");

            Console.SetIn(input1);

            // Act
            var players = PlayerFactory.CreatePlayers(3);

            // Assert
            Assert.Equal(3, players.Count); // プレイヤー数が正しいか
            Assert.Equal(name1, players[0].Name); // プレイヤー1の名前を確認
            Assert.Equal(name2, players[1].Name); // プレイヤー2の名前を確認
            Assert.Equal(name3, players[2].Name); // プレイヤー3の名前を確認
        }
    }
}
