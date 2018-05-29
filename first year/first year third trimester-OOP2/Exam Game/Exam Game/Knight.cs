using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Game
{
    class Knight : Hero
    {
        public static int KNIGHT_DEFEND_CHANCE = 20;
        public static int KNIGHT_INCREASE_ATACK_CHANCE = 10;
        public static int KNIGHT_BONUS_ATACK_DAMAGE = 2;
        public Knight(double hitPoints, double atackPoints, double armorPoints,string name) : base(hitPoints, atackPoints, armorPoints,name)
        {

        }

        public override void Atack(Hero defendingHero)
        {

            if (defendingHero.hitPoints < 0)
            {
                 return;
            }
            double rawDamage = (rand.Next(80, 120) / 100.0) * atackPoints;

            if (rand.Next(0,100)<=KNIGHT_INCREASE_ATACK_CHANCE)
            {
                Console.WriteLine($"{this.name} got lucky and got his atack increased by {KNIGHT_BONUS_ATACK_DAMAGE * 100}%");
                Console.WriteLine();
                rawDamage *= 2;
            }
            defendingHero.Defend(rawDamage);

        }

        public override void Defend(double incomingDamage)
        {
            
            if (rand.Next(0, 100) <= KNIGHT_DEFEND_CHANCE)
            {
                Console.WriteLine($"{this.name} blocked the attack and recieved no Damage");
                return;
            }


            double currentArmorPoints = (rand.Next(80, 120) / 100.0) * armorPoints;
            incomingDamage -= currentArmorPoints;
            if (incomingDamage <= 0)
            {
                Console.WriteLine("The atack wasn't effective.It did no harm to opponent");
                return;
            }
            hitPoints -= incomingDamage;
            Console.WriteLine($"{this.name} recieved {incomingDamage} damage.Remaining health:{(hitPoints > 0 ? Math.Round(hitPoints, 2) : 0)}");
            Console.WriteLine();
        }
    }
}
