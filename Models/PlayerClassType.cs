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
       

        public PlayerClassType(string classname)
        {
            this.className = classname;
        }

        public abstract void ability();

        public static PlayerClassType newSubclassInstance(String className)
        {
            Type playerClass = Type.GetType(className);
            try
            {
                return (PlayerClassType) Activator.CreateInstance(playerClass);                 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return defaultClass;     
             }
        }
    }
}