namespace Tennis.Interfaces
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);
        string GetScore();
    }
}

