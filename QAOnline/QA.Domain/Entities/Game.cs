using System;
using System.Collections.Generic;

namespace QA.Domain.Entities
{
    public class Game
    {
        public int Id { get; set; }

        public bool IsFinished { get; set; }

        public int NumberOfPlayers { get; set; }

        public virtual List<GamePlayer> GamePlayers { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
