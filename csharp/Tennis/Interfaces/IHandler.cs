using Tennis.Entities;

namespace Tennis.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
		
        string Handle(Player player1,Player player2);
    }
}