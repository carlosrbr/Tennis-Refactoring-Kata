using Tennis.Entities;
using Tennis.ValueObjects;

namespace Tennis.Common
{
    public class DefaultHandler : AbstractHandler
    {
        public override string Handle(Player player1, Player player2)
        {
            return $"{Score.GetScoreName(player1.Point)}-{Score.GetScoreName(player2.Point)}";
        }
    }
}