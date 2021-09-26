namespace Tennis.Entities
{
    public class GamePlayerPoint
    {
        private readonly Player _player;
        private int _points { get; set; }
        
        public GamePlayerPoint( Player player)
        {
            _player = player;
            _points = 0;
        }

        public void AddPoint()
        {
            _points++;
        }
        
    }
}