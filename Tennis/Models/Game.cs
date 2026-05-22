namespace Tennis.Models
{
    public class Game
    {
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public Game(string player1Name, string player2Name)
        {
            Player1 = new Player { Name = player1Name };
            Player2 = new Player { Name = player2Name };
        }

        public string GetScore()
        {
            return $"{Player1.Score} - {Player2.Score}";
        }

        public void ResetGame()
        {
            Player1.ResetScore();
            Player2.ResetScore();
        }
    }
}
