using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasySports.Models
{
    public class EnemyWave
    {
        private List<Enemy> enemies { get; set; }

        public EnemyWave()
        {
            enemies = new List<Enemy>();
            createEnemies();
        }

        private void createEnemies()
        {
            Random r = new Random();
            int size = r.Next(31);
            
            for(int i = 0; i < size; i++)
            {
                enemies.Add(Enemy.CreateRandomEnemy());
            }
        }


    }
}