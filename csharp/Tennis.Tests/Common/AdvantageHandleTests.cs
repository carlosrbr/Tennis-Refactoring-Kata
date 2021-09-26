using System.Diagnostics.CodeAnalysis;
using Tennis.Common;
using Tennis.Entities;
using Xunit;

namespace Tennis.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public class AdvantageHandleTests
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public AdvantageHandleTests()
        {
            this._playerOne = new Player("player1");
            this._playerTwo = new Player("player2");
        }

        [Fact]
        public void Given_PlayerWithFourScore_When_handle_Then_TheWinnerShouldBeThePlayerOne()
        {
            // Arrange 
            var advantageHandle = new AdvantageHandle();

            ScoreAdder.AddScore(4,_playerOne);
            ScoreAdder.AddScore(3,_playerTwo);

            // Act
            var status = advantageHandle.Handle(_playerOne, _playerTwo);

            // Assert
            Assert.Equal("Advantage player1",status);
        }
    }
}