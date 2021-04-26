using System;

namespace WebApi.Models
{
    public class Team
    {
        public string TeamName { get; set; }

        public Team()
        {

        }

        public Team(string team)
        {
            this.TeamName = team;
        }
    }
}
