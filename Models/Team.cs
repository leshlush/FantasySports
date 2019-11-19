using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasySports.Models
{
    public class Team
    {
        private List<Hero> players;

        public Team()
        {
            players = new List<Hero>();
        }

        public bool addPlayer(Hero player)
        {
            if(players.Contains(player))
            {
                players.Add(player);
                return true;
            }
            return false;
                
        }

        public void removePlayer(Hero player)
        {
            players.Remove(player);
        }
    }
}