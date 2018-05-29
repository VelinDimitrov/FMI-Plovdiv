using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero pesho = new Warior(100,15,15,"Peshaka");
            Hero gosho = new Assasin(80, 20, 5, "Goshko");
            GameEngine game = new GameEngine(pesho,gosho);
            game.Start();
        }
    }
}
