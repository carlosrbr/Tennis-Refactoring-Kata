using Tennis.Entities;

namespace Tennis.Common
{
    public class DefaultHandler : AbstractHandler
    {
        public override string Handle(Player player1, Player player2)
        {
            return $"{TennisGameRefactored.GetScoreName(player1.Point)}-{TennisGameRefactored.GetScoreName(player2.Point)}";
        }
    }
}