using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Dinosaur
    {
       
        
            //Dino (HAS A)
            public string Name;
            public int Health;
            public int AttackPower;

            public Dinosaur(string name)
            //Constructor (build)
            {
                Name = name;
                Health = 100;
                AttackPower = 20;





            }
            //(Member Methods (CAN DO)

            
            public void AttackRobot(Robot robotToAttack)
            {
                robotToAttack.Health -= AttackPower;
            }



        }
    }
