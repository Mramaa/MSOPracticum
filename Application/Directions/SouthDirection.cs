namespace Practicum.Directions
{
    public class SouthDirection : IDirection
    {
        public Position Move(Position p, Grid g)
        {
            if (p.Y < g.Height) p.Y++;

            return p;
        }
    }
}
