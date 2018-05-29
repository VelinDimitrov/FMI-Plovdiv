using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Game
{
    class Monk : Hero
    {
        public static readonly int MONK_DEFEND_CHANCE=30;
        public Monk(double hitPoints, double atackPoints, double armorPoints,string name)
            : base(hitPoints, atackPoints, armorPoints,name)
        {
        }

        public override void Atack(Hero defendingHero)
        {

            if (defendingHero.hitPoints < 0)
            {               
                return;
            }
            double rawDamage = (rand.Next(80, 120) / 100.0) * atackPoints;
            defendingHero.Defend(rawDamage);

        }

        public override void Defend(double incomingDamage)
        {
            
            if (rand.Next(0,100)<=MONK_DEFEND_CHANCE)
            {
                Console.WriteLine($"{this.name} avoided the attack and recieve no Damage");
                Console.WriteLine();
                return;
            }
            double currentArmorPoints = (rand.Next(80, 120) / 100.0) * armorPoints;

            incomingDamage -= currentArmorPoints;
            if (incomingDamage<=0)
            {
                Console.WriteLine("The atack wasn't effective.It did no harm to opponent");
                return;
            }
            hitPoints -= incomingDamage;
            Console.WriteLine($"{this.name} recieved {incomingDamage} damage.Remaining health:{(hitPoints > 0 ? Math.Round(hitPoints, 2) : 0)}");
        }
    }
}
