namespace Practicum.Directions
{
    public class WestDirection : IDirection
    {
        public Position Move(Position p, Grid g)
        {
            if (p.X > 0) p.X--;

            return p;
        }
    }
}
