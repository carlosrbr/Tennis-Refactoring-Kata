using System;
using Tennis.Entities;

namespace Tennis.Common
{
    public class AdvantageHandle : AbstractHandler
    {
        public override string Handle(Player player1, Player player2)
        {
            var max = Math.Max(player1.Point, player2.Point);
            var min = Math.Min(player1.Point, player2.Point);

            return max > min && min >= 3
                ? $"Advantage {(player1.Point == max ? player1 : player2)}"
                : base.Handle(player1, player2);
        }
    }
}