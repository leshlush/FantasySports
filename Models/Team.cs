using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasySports.Models
{
    public class Team
    {
        private int id;
        private List<Hero> heroes;
        public Player player { get; set; }

        public Team(Player player)
        {
            heroes = new List<Hero>();
            this.player = player;
        }

        public bool addHero(Hero hero)
        {
            if(heroes.Contains(hero))
            {
                heroes.Add(hero);
                return true;
            }
            return false;                
        }

        public void removeHero(Hero hero)
        {
            heroes.Remove(hero);
        }

        public override bool Equals(Object other)
        {
            if (other == null || !(other is Team))
            {
                return false;
            }
            else
            {
                Team otherTeam = (Team)other;
                return id == otherTeam.id;
            }
        }

        public override int GetHashCode()
        {
            return id;
        }

    }
}