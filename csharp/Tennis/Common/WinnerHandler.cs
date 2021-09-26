using System;
using Tennis.Entities;

namespace Tennis.Common
{
    public class WinnerHandler : AbstractHandler
    {
        public override string Handle(Player player1, Player player2)
        {
            var max = Math.Max(player1.Point, player2.Point);
            var min = Math.Min(player1.Point, player2.Point);

            return max >= 4 && min >= 0 && (max - min) >= 2
                ? $"Win for {(player1.Point == max ? player1 : player2)}"
                : base.Handle(player1, player2);
        }
    }
}