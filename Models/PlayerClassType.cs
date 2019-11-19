using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasySports.Models
{
    public abstract class PlayerClassType
    {
        public string className { get; }
        private static PlayerClassType defaultClass = new Fighter();
        private static Dictionary<string, PlayerClassType> typeByName = new Dictionary<string, PlayerClassType>();

        static PlayerClassType()
            {
            typeByName.Add("Fighter", new Fighter());
            typeByName.Add("Wizard", new Wizard());
            }

        public PlayerClassType(string classname)
        {
            this.className = classname;
        }

        public abstract void ability();

        public static PlayerClassType newSubclassInstance(String className)
        {
            PlayerClassType value;
            if (typeByName.TryGetValue(className, out value))
            {
                return value;
            }
            else
            {
                return defaultClass;
             }
        }

        
    }
}