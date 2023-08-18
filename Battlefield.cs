using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Battlefield
    {

        public void RunGame()
        {
            Console.WriteLine("Hello and welcome to the battle of Fluffy vs Botbot!");
            Dinosaur dino = new Dinosaur("Fluffy");
            Robot robot = new Robot("Botbot");
        }
    }
}
