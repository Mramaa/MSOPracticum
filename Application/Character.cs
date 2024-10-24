using Practicum.Directions;

namespace Practicum
{
    public class Character
    {
        private static Character _instance;

        private Position _position;
        public Position Position { get; set; }

        private IDirection _direction;
        public IDirection Direction { get; set; }
        
        public Character(Position position, IDirection direction)
        {
            this._position = position;
            this._direction = direction;
        }
        
        public static Character getInstance()
        {
            if (_instance == null)
                _instance = new Character(new Position(0, 0), new EastDirection());
            return _instance;
        }
    }
}