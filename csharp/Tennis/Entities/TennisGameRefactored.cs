using System;
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
            if (_p1.Point >= 4 && _p2.Point >= 0 && (_p1.Point - _p2.Point) >= 2)
            {
                return "Win for player1";
            }

            if (_p2.Point >= 4 && _p1.Point >= 0 && (_p2.Point - _p1.Point) >= 2)
            {
                return "Win for player2";
            }

            if (_p1.Point == _p2.Point && _p1.Point < 3)
            {
                return $"{GetScoreName(_p1.Point)}-All";
            }

            if (_p1.Point == _p2.Point && _p1.Point > 2)
                return "Deuce";

            if (_p1.Point > 0 && _p2.Point == 0)
            {
                return GetScoreName(_p1.Point) + "-" + "Love";
            }

            if (_p2.Point > 0 && _p1.Point == 0)
            {
                return "Love" + "-" + GetScoreName(_p2.Point);
            }

            if (_p1.Point > _p2.Point && _p1.Point < 4)
            {
                return GetScoreName(_p1.Point) + "-" + GetScoreName(_p2.Point);
            }

            if (_p2.Point > _p1.Point && _p2.Point < 4)
            {
                return GetScoreName(_p1.Point) + "-" + GetScoreName(_p2.Point);
            }

            if (_p1.Point > _p2.Point && _p2.Point >= 3)
            {
                return "Advantage player1";
            }

            if (_p2.Point > _p1.Point && _p1.Point >= 3)
            {
                return "Advantage player2";
            }

            throw new Exception("result not found.");
        }

        public void WonPoint(Player player)
        {
            player.Score();
        }

        public void WonPoint(string player)
        {
            throw new NotImplementedException();
        }

        private static string GetScoreName(int score)
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