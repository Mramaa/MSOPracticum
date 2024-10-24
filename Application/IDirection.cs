using System.ComponentModel;

namespace Practicum
{
    public interface IDirection
    {
        //(int, int) Move((int, int) p);
        Position Move (Position p, Grid g);
    }
}
