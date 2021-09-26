namespace Tennis.Entities
{
    public class Player
    {
        private readonly string _name;
        public int Point { get; private set; }

        public Player(string name)
        {
            _name = name;
            Point = 0;
        }

        public void Score()
        {
            Point++;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}