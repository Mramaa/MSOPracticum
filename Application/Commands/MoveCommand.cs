using Practicum.Directions;

namespace Practicum.Commands
{
    public class MoveCommand : ICommand
    {
        private int _steps;
        
        public MoveCommand(int steps)
        {
            _steps = steps;
        }
        public void Execute(Character c, Grid g)
        {
            IDirection dir = c.Direction;
            for (int i = 0; i < _steps; i++) {
                dir.Move(c.Position, g);
            }
            
        }
    }
}