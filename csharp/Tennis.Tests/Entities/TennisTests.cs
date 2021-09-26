using System;
using Tennis.Entities;
using Tennis.Interfaces;
using Tennis.Tests.Data;
using Xunit;

namespace Tennis.Tests.Entities
{
    public class TennisTests
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis2Test(int p1, int p2, string expected)
        {
            var game = new TennisGame2();
            CheckAllScores(game, p1, p2, expected);
        }


        private static void CheckAllScores(ITennisGame game, int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            var highestScore = Math.Max(player1Score, player2Score);
            for (var i = 0; i < highestScore; i++)
            {
                if (i < player1Score)
                    game.WonPoint("player1");
                if (i < player2Score)
                    game.WonPoint("player2");
            }

            // Act
            var result = game.GetScore();

            // Assert
            Assert.Equal(expectedScore, result);
        }
    }
}