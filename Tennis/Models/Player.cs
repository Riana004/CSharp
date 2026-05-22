namespace Tennis.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; private set; }

        public void IncrementScore()
        {
            Score++;
        }

        public void ResetScore()
        {
            Score = 0;
        }
    }
}
