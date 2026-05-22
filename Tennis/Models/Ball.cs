namespace Tennis.Models
{
    public class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }

        public Ball(int startX, int startY)
        {
            X = startX;
            Y = startY;
            SpeedX = 5;
            SpeedY = 5;
        }

        public void Move()
        {
            X += SpeedX;
            Y += SpeedY;
        }

        public void ReverseX()
        {
            SpeedX = -SpeedX;
        }

        public void ReverseY()
        {
            SpeedY = -SpeedY;
        }
    }
}
