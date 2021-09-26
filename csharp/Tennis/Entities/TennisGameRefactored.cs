using System;
using Tennis.Common;
using Tennis.Interfaces;

namespace Tennis.Entities
{
    public class TennisGameRefactored : ITennisGame
    {
        private readonly Player _p1;
        private readonly Player _p2;

        public TennisGameRefactored(Player p1, Player p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public string GetScore()
        {
            var winner = new WinnerHandler();

            winner
                .SetNext(new AdvantageHandle())
                .SetNext(new DeuceHandle())
                .SetNext(new AllHandle())
                .SetNext(new DefaultHandler());
            return winner.Handle(_p1, _p2);
        }

        public void WonPoint(Player player)
        {
            player.Score();
        }

        public void WonPoint(string player)
        {
            throw new NotSupportedException("The TennisGameRefactored class does not implement the old functionality.");
        }

        public static string GetScoreName(int score)
        {
            return score switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty",
                _ => throw new ArgumentException("invalid parameter", nameof(score))
            };
        }
    }
}