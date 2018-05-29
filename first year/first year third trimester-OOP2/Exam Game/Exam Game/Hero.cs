using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Game
{
    abstract class Hero
    {
        public double hitPoints { get; internal set; }
        public double atackPoints { get;  }
        public double armorPoints { get;  }
        public string name { get; }

        public static Random rand = new Random();


        public Hero(double hitPoints,double atackPoints ,double armorPoints,string name)
        {
            this.hitPoints = hitPoints;
            this.atackPoints = atackPoints;
            this.armorPoints = armorPoints;
            this.name = name;
        }

        public abstract void Atack(Hero hero);
        public abstract void Defend(double incomingDamage);
        
    }
}
