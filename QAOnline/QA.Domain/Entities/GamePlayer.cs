namespace QA.Domain.Entities
{
    public class GamePlayer
    {
        public int PlayerId { get; set; }

        public int GameId { get; set; }

        public virtual Player Player { get; set; }

        public virtual Game Game { get; set; }
    }
}
