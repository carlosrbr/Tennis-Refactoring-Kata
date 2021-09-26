using Tennis.Entities;

namespace Tennis.Common
{
    public class WinnerHandler : AbstractHandler
    {
        public override string Handle(Player player1, Player player2)
        {
            if (player1.Point >= 4 && player2.Point >= 0 && (player1.Point - player2.Point) >= 2)
            {
                return $"Win for {player1}";
            }

            if (player2.Point >= 4 && player1.Point >= 0 && (player2.Point - player1.Point) >= 2)
            {
                return $"Win for {player2}";
            }

            return base.Handle(player1, player2);
        }
    }
}