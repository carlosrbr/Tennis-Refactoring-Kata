using System;

namespace Tennis.ValueObjects
{
    public static class Score
    {
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