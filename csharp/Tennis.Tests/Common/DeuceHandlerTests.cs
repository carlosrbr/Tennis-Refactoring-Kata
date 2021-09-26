using System.Diagnostics.CodeAnalysis;
using Tennis.Common;
using Tennis.Entities;
using Xunit;

namespace Tennis.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public class DeuceHandleTests
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public DeuceHandleTests()
        {
            this._playerOne = new Player("player1");
            this._playerTwo = new Player("player2");
        }

        [Fact]
        public void Given_TwoPlayerWithSameScore_When_handle_Then_TheReturnShouldHaveDeuce()
        {
            // Arrange 
            var defaultHandler = new DeuceHandle();

            ScoreAdder.AddScore(3, _playerOne);
            ScoreAdder.AddScore(3, _playerTwo);

            // Act
            var status = defaultHandler.Handle(_playerOne, _playerTwo);

            // Assert
            Assert.Equal("Deuce", status);
        }
    }
}