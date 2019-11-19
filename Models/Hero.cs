using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasySports.Models
{
    public class Hero
    {
        public int hp { get; set; }
        public int damage { get; set; }
        public string name{get; set;}
        public PlayerClassType classType { get; set; }

        public Hero(int hp, int damage, string name, PlayerClassType classType)
        {
            this.hp = hp;
            this.damage = damage;
            this.name = name;
            this.classType = classType;
        }

        public Hero(int hp, int damage, string name, string className)
        {
            this.hp = hp;
            this.damage = damage;
            this.name = name;
            this.classType = PlayerClassType.newSubclassInstance(className);
        }

        public static Hero createTestObject()
        {
            return new Hero(15, 15, "Bob", new Fighter());
        }

        //public abstract void ability();

        

    }
}