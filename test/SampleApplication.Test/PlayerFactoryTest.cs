using System;
using System.IO;

namespace SampleApplication.Test
{
    public class PlayerFactoryTest
    {
        [Fact(DisplayName = "Factory�e�X�g")]
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
            Assert.Equal(3, players.Count); // �v���C���[������������
            Assert.Equal(name1, players[0].Name); // �v���C���[1�̖��O���m�F
            Assert.Equal(name2, players[1].Name); // �v���C���[2�̖��O���m�F
            Assert.Equal(name3, players[2].Name); // �v���C���[3�̖��O���m�F
        }
    }
}