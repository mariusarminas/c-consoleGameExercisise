using Praktine_uzduotis.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_uzduotis
{
    class GameScreen
    {
        private int Width;
        private int Height;

        private Hero hero;
        private List<Enemy> enemies = new List<Enemy>();
        private Frame frame;

        public GameScreen(int GameWidth, int GameHeight)
        {
            Width = GameWidth;
            Height = GameHeight;
            frame = new Frame(0, 0, Width, Height, '+');
        }

        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void Render()
        {
            frame.Render();
            hero.Render();
            foreach (Enemy enemy in enemies)
            {
                if (!enemy.IsDead())
                    enemy.Render();
            }
        }

        public Hero GetHero()
        {
            return hero;
        }

        public void AddEnemy()
        {
            Random random = new Random();
            int x = random.Next(0, Width);
            AddEnemy(new Enemy(0, x, 1, "Name"));
        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
                if (enemy.GetY() == Height - 1)
                {
                    enemy.SetIsDead(true);
                }
            }
        }

        public Enemy getEnemyById(int id)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }

            return null;
        }
    }
}