using Tennis.Entities;
using Tennis.ValueObjects;

namespace Tennis.Common
{
    public class AllHandle : AbstractHandler
    {
        public override string Handle(Player player1, Player player2)
        {
            return player1.Point == player2.Point && player1.Point < 3
                ? $"{Score.GetScoreName(player1.Point)}-All"
                : base.Handle(player1, player2);
        }
    }
}