using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Game
{
    class GameEngine
    {
        public Hero hero { get; }
        public Hero enemy { get; }

        public GameEngine(Hero hero,Hero enemy)
        {
            this.hero = hero;
            this.enemy = enemy;
        }

        public void Start()
        {
            Console.WriteLine("\t\tGAME STARTED!!!!!!");
            Console.WriteLine($"\t\t{hero.name} vs {enemy.name}");
            Console.WriteLine();

            while (hero.hitPoints>0&&enemy.hitPoints>0)
            {
                hero.Atack(enemy);
                if (hero.hitPoints<0||enemy.hitPoints<0)
                {
                    break;
                }
                enemy.Atack(hero);
            }


            if (hero.hitPoints>0)
            {
                Console.WriteLine($"\t{enemy.name} is dead!!!");
                Console.WriteLine($"\t{hero.name} WON!!!!");
            }
            else
            {
                Console.WriteLine($"\t{hero.name} is dead!!!");
                Console.WriteLine($"\t{enemy.name} WON!!!!");
            }
            Console.WriteLine("\tGame ended!!!");
        }
    }
}
