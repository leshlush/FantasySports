using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FantasySports.Models;
using System.Data.SqlClient;
using System.Data;

namespace FantasySports.DataAccess
{
    public class HeroesData
    {
        public static List<Hero> getAllAvailableHeroes()
        {
            List<Hero> heroes = new List<Hero>();
            DataTable table = StoredProcedures.getRowsFromSproc("GetAllAvailableHeroes");

            foreach(DataRow row in table.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string name = row["name"].ToString();
                int hp = Convert.ToInt32(row["hp"]);
                int damage = Convert.ToInt32(row["damage"]);
                string combatClass = row["class"].ToString();

                heroes.Add(new Hero(id, hp, damage, name, combatClass));
            }
            return heroes;
        }
    }
}