using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FantasySports.Models
{
    public class HeroMaker
    {
        public static List<Hero> getAllHeroes()
        {
            using (var context = new FantasySportsEntities())
            {
                List<Hero> allHeroes = (List<Hero>) context.Heroes.Where(s => s.name != null); 
                return allHeroes;
            }
        }

        public static List<Hero> GetAllHeroes2()
        {
            List<Hero> heroes = new List<Hero>();

            string connectionString = ConfigurationManager.ConnectionStrings["ADOString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(QueryAllHeroes(), connection);
                cmd.CommandType = CommandType.Text;
                connection.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string name = rdr["name"].ToString();
                    int hp = Convert.ToInt32(rdr["hp"]);
                    int damage = Convert.ToInt32(rdr["damage"]);
                    string combatClass = rdr["name"].ToString();

                    heroes.Add(new Hero(hp, damage, name, combatClass));
                }
                return heroes;
            }
        }

        public static String QueryAllHeroes()
        {
            return
                "SELECT * From Heroes";
        }
    }
}