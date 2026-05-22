using Tennis.Models;

namespace Tennis.Controllers
{
    public class GameController
    {
        public Ball Ball { get; private set; }
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }
        public int CourtWidth { get; }
        public int CourtHeight { get; }

        public GameController(int courtWidth, int courtHeight)
        {
            CourtWidth = courtWidth;
            CourtHeight = courtHeight;
            Ball = new Ball(courtWidth / 2, courtHeight / 2);
            Player1 = new Player { Name = "Player 1" };
            Player2 = new Player { Name = "Player 2" };
        }

        public void UpdateBallPosition()
        {
            Ball.Move();

            // Collision avec les bords gauche et droit
            if (Ball.X <= 0 || Ball.X >= CourtWidth)
                Ball.ReverseX();

            // Collision avec les bords supérieur et inférieur
            if (Ball.Y <= 0)
                Ball.ReverseY();
            else if (Ball.Y >= CourtHeight)
            {
                // Ajouter un point au joueur
                if (Ball.Y >= CourtHeight)
                    Player1.IncrementScore();

                // Réinitialiser la balle
                ResetBall();
            }
        }

        public void ResetBall()
        {
            Ball.X = CourtWidth / 2;
            Ball.Y = CourtHeight / 2;
            Ball.SpeedX = 5;
            Ball.SpeedY = 5;
        }
    }
}
