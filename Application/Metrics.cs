namespace Practicum
{
    public class Metrics
    {
        public int Commands;
        public int Nesting;
        public int Repeat;

        public Metrics()
        {
            Commands = 0;
            Nesting = 0;
            Repeat = 0;
        }

        public void NumberOfCommands()
        {
            Commands += 1;
        }

        public void MaximumNesting()
        {
            Nesting += 1;
        }

        public void NumberOfRepeat()
        {
            Repeat += 1;
        }
    }
}
