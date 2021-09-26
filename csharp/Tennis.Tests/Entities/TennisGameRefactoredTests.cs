using System;
using System.Diagnostics.CodeAnalysis;
using Tennis.Entities;
using Tennis.Interfaces;
using Tennis.Tests.Data;
using Xunit;

namespace Tennis.Tests.Entities
{
    [ExcludeFromCodeCoverage]
    public class TennisGameRefactoredTests
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public TennisGameRefactoredTests()
        {
            this._playerOne = new Player("player1");
            this._playerTwo = new Player("player2");
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TennisGameRefactored(int p1, int p2, string expected)
        {
            var game = new TennisGameRefactored
            (
                this._playerOne,
                this._playerTwo
            );
            CheckAllScores(game, p1, p2, expected);
        }

        private void CheckAllScores(ITennisGame game, int player1Score, int player2Score, string expectedScore)
        {
            // Arrange
            var highestScore = Math.Max(player1Score, player2Score);
            for (var i = 0; i < highestScore; i++)
            {
                if (i < player1Score)
                    game.WonPoint(_playerOne);
                if (i < player2Score)
                    game.WonPoint(_playerTwo);
            }

            // Act
            var result = game.GetScore();

            // Assert
            Assert.Equal(expectedScore, result);
        }
    }
}