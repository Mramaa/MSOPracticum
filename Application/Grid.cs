namespace Practicum
{
    public class Grid
    {
        private int width;
        public int Width { get; set; }

        private int height;
        public int Height { get; set; }


        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
