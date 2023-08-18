using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Robot
    {

        //Robot (HAS A)
        public string Name;
        public Weapon activeWeapon;
        public int Health;

        public Robot(string name)
        {
            Name = name;
            Health = 100;
        }




        //Member Methods (CAN DO)
        public void AttackDinosaur(Dinosaur dinosaurToAttack)

        {

            dinosaurToAttack.Health -= activeWeapon.Damage;

        }
    }
    


