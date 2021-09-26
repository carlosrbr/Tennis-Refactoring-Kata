using System;
using Tennis.Entities;
using Tennis.Interfaces;
using Xunit;

namespace Tennis.Tests
{
    public class TennisGameRefactoredTests
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TennisGameRefactored(int p1, int p2, string expected)
        {
            var game = new TennisGameRefactored
            (
                new Player("Player 1"),
                new Player("Player 2")
            );
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