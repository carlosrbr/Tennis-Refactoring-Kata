using Tennis.Interfaces;

namespace Tennis.Entities
{
    public class TennisGameRefactored : ITennisGame
    {
        private readonly Player _p1;
        private readonly Player _p2;
        // private int _p1Point;
        // private int _p2.Point;
        //
        private string _p1Res = "";
        private string _p2Res = "";

        public TennisGameRefactored(Player p1, Player p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public string GetScore()
        {
            var score = "";
            if (_p1.Point == _p2.Point && _p1.Point < 3)
            {
                if (_p1.Point == 0)
                    score = "Love";
                if (_p1.Point == 1)
                    score = "Fifteen";
                if (_p1.Point == 2)
                    score = "Thirty";
                score += "-All";
            }
            if (_p1.Point == _p2.Point && _p1.Point > 2)
                score = "Deuce";

            if (_p1.Point > 0 && _p2.Point == 0)
            {
                if (_p1.Point == 1)
                    _p1Res = "Fifteen";
                if (_p1.Point == 2)
                    _p1Res = "Thirty";
                if (_p1.Point == 3)
                    _p1Res = "Forty";

                _p2Res = "Love";
                score = _p1Res + "-" + _p2Res;
            }
            if (_p2.Point > 0 && _p1.Point == 0)
            {
                if (_p2.Point == 1)
                    _p2Res = "Fifteen";
                if (_p2.Point == 2)
                    _p2Res = "Thirty";
                if (_p2.Point == 3)
                    _p2Res = "Forty";

                _p1Res = "Love";
                score = _p1Res + "-" + _p2Res;
            }

            if (_p1.Point > _p2.Point && _p1.Point < 4)
            {
                if (_p1.Point == 2)
                    _p1Res = "Thirty";
                if (_p1.Point == 3)
                    _p1Res = "Forty";
                if (_p2.Point == 1)
                    _p2Res = "Fifteen";
                if (_p2.Point == 2)
                    _p2Res = "Thirty";
                score = _p1Res + "-" + _p2Res;
            }
            if (_p2.Point > _p1.Point && _p2.Point < 4)
            {
                if (_p2.Point == 2)
                    _p2Res = "Thirty";
                if (_p2.Point == 3)
                    _p2Res = "Forty";
                if (_p1.Point == 1)
                    _p1Res = "Fifteen";
                if (_p1.Point == 2)
                    _p1Res = "Thirty";
                score = _p1Res + "-" + _p2Res;
            }

            if (_p1.Point > _p2.Point && _p2.Point >= 3)
            {
                score = "Advantage player1";
            }

            if (_p2.Point > _p1.Point && _p1.Point >= 3)
            {
                score = "Advantage player2";
            }

            if (_p1.Point >= 4 && _p2.Point >= 0 && (_p1.Point - _p2.Point) >= 2)
            {
                score = "Win for player1";
            }
            if (_p2.Point >= 4 && _p1.Point >= 0 && (_p2.Point - _p1.Point) >= 2)
            {
                score = "Win for player2";
            }
            return score;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                _p1.Score();
            else
                _p2.Score();
        }

    }
}

