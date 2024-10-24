namespace Practicum.Directions
{
    public class EastDirection : IDirection
    {
        //public (int,int) Move((int, int) a)
        public Position Move(Position p, Grid g)
        {
            if (p.X < g.Width) p.X++;
           
            return p;
        }
    }
}
