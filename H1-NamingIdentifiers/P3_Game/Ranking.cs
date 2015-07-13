namespace Application2
{
    public class Ranking
    {
        public string Player { get; set; }

        public int Points { get; set; }

        public Ranking()
        {
        }

        public Ranking(string name, int points)
        {
            this.Player = name;
            this.Points = points;
        }
    }
}
