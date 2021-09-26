using Tennis.Entities;

namespace Tennis.Interfaces
{
    public interface ITennisGame
    {
        void WonPoint(Player playerName);
        void WonPoint(string playerName);
        string GetScore();
    }
}

