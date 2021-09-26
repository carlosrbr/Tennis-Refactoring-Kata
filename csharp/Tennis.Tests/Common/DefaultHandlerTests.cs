using System.Diagnostics.CodeAnalysis;
using Tennis.Common;
using Tennis.Entities;
using Xunit;

namespace Tennis.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public class DefaultHandleTests
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public DefaultHandleTests()
        {
            this._playerOne = new Player("player1");
            this._playerTwo = new Player("player2");
        }

        [Fact]
        public void Given_TwoPlayerWithTwoScore_When_handle_Then_TheReturnShouldHaveAll()
        {
            // Arrange 
            var defaultHandler = new DefaultHandler();

            ScoreAdder.AddScore(1, _playerOne);
            ScoreAdder.AddScore(3, _playerTwo);

            // Act
            var status = defaultHandler.Handle(_playerOne, _playerTwo);

            // Assert
            Assert.Equal("Fifteen-Forty", status);
        }
    }
}