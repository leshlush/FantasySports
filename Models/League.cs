using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasySports.Models
{
    public class League
    {
        private int id;
        private List<Player> players;
        private Dictionary<Player, Team> teams;
        private string leagueName;

        public League(int id, List<Player> players, Dictionary<Player, Team> teams, string leagueName)
        {
            this.id = id;
            this.players = players;
            this.teams = teams;
            this.leagueName = leagueName;
        }

        public bool addPlayerIfNotInLeague(Player player)
        {
            if(!players.Contains(player))
            {
                players.Add(player);
                return true;
            }
            return false;
        }

        public bool addTeamIfNotInLeague(Team team)
        {
            if(!teams.ContainsKey(team.player))
            {
                teams.Add(team.player, team);
                return true;
            }
            return false;
        }

        

    }
}