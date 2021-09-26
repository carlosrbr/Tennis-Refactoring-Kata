using Tennis.Entities;

namespace Tennis.Common
{
    public class AdvantageHandle : AbstractHandler
    {
        public override string Handle(Player player1, Player player2)
        {
            if (player1.Point > player2.Point && player2.Point >= 3)
            {
                return $"Advantage {player1}";
            }

            if (player2.Point > player1.Point && player1.Point >= 3)
            {
                return $"Advantage {player2}";
            }

            return base.Handle(player1, player2);
        }
    }
}