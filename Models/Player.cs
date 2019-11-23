using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasySports.Models
{
    public class Player
    {
        private int id;
        public String name { get; set; }

        public override bool Equals(Object other)
        {
            if(other == null || !(other is Player))
            {
                return false;
            }
            else 
            {
                Player otherPlayer = (Player) other;
                return id == otherPlayer.id;
            }
        }

        public override int GetHashCode()
        {
            return id;
        }

    }
}