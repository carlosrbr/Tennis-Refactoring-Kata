using System.Diagnostics.CodeAnalysis;
using Tennis.Common;
using Tennis.Entities;
using Xunit;

namespace Tennis.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public class AllHandleTests
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public AllHandleTests()
        {
            this._playerOne = new Player("player1");
            this._playerTwo = new Player("player2");
        }

        [Fact]
        public void Given_TwoPlayerWithTwoScore_When_handle_Then_TheReturnShouldHaveAll()
        {
            // Arrange 
            var allHandle = new AllHandle();

            ScoreAdder.AddScore(2, _playerOne);
            ScoreAdder.AddScore(2, _playerTwo);

            // Act
            var status = allHandle.Handle(_playerOne, _playerTwo);

            // Assert
            Assert.Equal("Thirty-All", status);
        }
    }
}