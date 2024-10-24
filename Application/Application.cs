using Practicum.Directions;
using System.Security.Cryptography.X509Certificates;

namespace Practicum
{
    public class Application
    {
        public Program _program;
        private Character _character;
        private Grid _grid;

        public Application()
        {
            _program = new Program();
            _character = new Character(new Position(0,0), new EastDirection());
            _grid = new Grid(10, 10);
        }

        public void Import()
        {

        }

        public void LoadExample()
        {

        }

        public void CalculateMetrics()
        {

        }

        public void ExecuteProgram()
        {
            for (LinkedListNode<ICommand> node = _program.Commands.First; node != null; node = node.Next)
            {
                ICommand command = node.Value;
                command.Execute(_character, _grid);
            }
        }
    }
}
