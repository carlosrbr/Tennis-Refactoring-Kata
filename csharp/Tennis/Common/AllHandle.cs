using Tennis.Entities;
using Tennis.ValueObjects;

namespace Tennis.Common
{
    public class AllHandle : AbstractHandler
    {
        public override string Handle(Player player1, Player player2)
        {
            if (player1.Point == player2.Point && player1.Point < 3)
            {
                return $"{Score.GetScoreName(player1.Point)}-All";
            }

            return base.Handle(player1, player2);
        }
    }
}