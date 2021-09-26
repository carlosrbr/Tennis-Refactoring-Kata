using System.Diagnostics.CodeAnalysis;
using Tennis.Common;
using Tennis.Entities;
using Xunit;

namespace Tennis.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public class WinnerHandleTests
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public WinnerHandleTests()
        {
            this._playerOne = new Player("player1");
            this._playerTwo = new Player("player2");
        }

        [Fact]
        public void Given_TwoPlayerWithSameScore_When_handle_Then_TheReturnShouldHaveDeuce()
        {
            // Arrange 
            var winnerHandler = new WinnerHandler();

            ScoreAdder.AddScore(4, _playerOne);
            ScoreAdder.AddScore(0, _playerTwo);

            // Act
            var status = winnerHandler.Handle(_playerOne, _playerTwo);

            // Assert
            Assert.Equal("Win for player1", status);
        }
    }
}