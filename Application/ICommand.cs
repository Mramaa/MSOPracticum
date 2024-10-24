namespace Practicum
{
    public interface ICommand
    {
        void Execute(Character c, Grid g);

        //void Move(int steps);

        //void Turn(string turn);

        //void Repeat(int amount, List<string> commands);
    }
}