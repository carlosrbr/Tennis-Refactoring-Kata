using Tennis.Entities;

namespace Tennis.Common
{
    public class DeuceHandle : AbstractHandler
    {
        public override string Handle(Player player1,Player player2)
        { 
            if (player1.Point == player2.Point && player1.Point > 2)
                return "Deuce";
            
            return base.Handle(player1, player2);
        }
    }
}