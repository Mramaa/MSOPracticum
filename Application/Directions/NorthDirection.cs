namespace Practicum.Directions
{
    public class NorthDirection : IDirection
    {
        public Position Move(Position p, Grid g)
        {
            if (p.Y > 0) p.Y--;

            return p;
        }
    }
}
