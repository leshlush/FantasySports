using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasySports.Models
{
    public class Enemy
    {
        private Race race;

        
        public Enemy(Race race)
        {
            this.race = race;
        }

        private static Race GetRandomRace()
        {
            Array raceValues = Enum.GetValues(typeof(Race));
            Race race = (Race) raceValues.GetValue(new Random().Next(raceValues.Length));
            return race;
        }

        public static Enemy CreateRandomEnemy()
        {
            Enemy enemy = new Enemy(GetRandomRace());
            return enemy;

        }


        public enum Race
        {
            GOBLIN, TROLL, MINOTAUR
        }
    }
}