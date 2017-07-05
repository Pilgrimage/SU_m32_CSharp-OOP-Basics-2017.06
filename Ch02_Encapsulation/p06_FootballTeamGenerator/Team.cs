namespace p06_FootballTeamGenerator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Team
    {
        private string name;
        private int rating;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
            CalculateRating();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public int Rating
        {
            get { return this.rating; }
            private set { this.rating = value; }
        }
        

        public void AddPlayer(Player player)
        {
            if (IsPlayerInTeam(player.Name))
            {
                throw  new InvalidOperationException($"Player {player.Name} already play in {this.Name} team.");   // Unofficial
            }
            this.players.Add(player);
            CalculateRating();
        }

        public void RemovePlayer(string playerName)
        {
            if (!IsPlayerInTeam(playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }
            Player player = this.players.FirstOrDefault(n => n.Name == playerName);
            players.Remove(player);
            CalculateRating();
        }


        private void CalculateRating()
        {
            if (players.Count == 0)
            {
                this.Rating = 0;
            }
            else
            {
                double sum = this.players.Sum(s => s.Stats);
                this.Rating = Convert.ToInt32(Math.Round(sum / players.Count));
            }
        }

        private bool IsPlayerInTeam(string playerName)
        {
            return this.players.Any(n => n.Name == playerName);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
