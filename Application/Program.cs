namespace Practicum
{
    public class Program
    {
        private LinkedList<ICommand> _commands;

        public LinkedList<ICommand> Commands { get { return _commands; } }

        public Program()
        {
            _commands = new LinkedList<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            _commands.AddLast(command);
        }

        public ICommand GetCommand()
        {
            ICommand? headCommand = _commands.First?.Value;
            _commands.RemoveFirst();
            return headCommand;
        }
    }
}