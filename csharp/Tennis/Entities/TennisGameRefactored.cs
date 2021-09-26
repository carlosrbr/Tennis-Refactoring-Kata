using System;
using Tennis.Common;
using Tennis.Interfaces;

namespace Tennis.Entities
{
    public class TennisGameRefactored : ITennisGame
    {
        private readonly Player _playerOne;
        private readonly Player _playerTwo;

        public TennisGameRefactored(Player playerOne, Player playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
        }

        public string GetScore()
        {
            var winner = new WinnerHandler();

            winner
                .SetNext(new AdvantageHandle())
                .SetNext(new DeuceHandle())
                .SetNext(new AllHandle())
                .SetNext(new DefaultHandler());
            return winner.Handle(_playerOne, _playerTwo);
        }

        public void WonPoint(Player player)
        {
            player.Score();
        }

        public void WonPoint(string player)
        {
            throw new NotSupportedException("The TennisGameRefactored class does not implement the old overload of WonPoint.");
        }
    }
}