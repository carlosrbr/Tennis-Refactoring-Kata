using Tennis.Entities;

namespace Tennis.Tests
{
    public static class ScoreAdder
    {
        public static void AddScore(int i, Player player)
        {
            for (int j = 0; j < i; j++)
            {
                player.Score();
            }
        }
    }
}