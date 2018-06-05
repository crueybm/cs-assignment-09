/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/26/2017
 * Assignment: 009
 * Description:  This class is used to create all skeletons for the "game".  
 * It is derived from both Entity and Enemy, so it inherits the variables from the base classes.
 * The variables "weapon" and "rattle" are both declared here.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment009
{
    class Skeleton : Enemy
    {
        private Enemy enemy;        //Declares Enemy enemy
        private String weapon;      //Declares String weapon
        private String rattle;      //Declares String rattle

        public Skeleton(int hitPoints, int attack, int defense, int speed, String element, int rewardedExpreience, String weapon, String rattle) //Creates the "Skeleton" constructor
            : base(hitPoints, attack, defense, speed, element, rewardedExpreience)
        {
            setEnemy(enemy);        //Sets enemy
            setWeapon(weapon);      //Sets weapon
            setRattle(rattle);      //Sets rattle
        }

        public Entity getEnemy() { return enemy; }      //Getter for enemy
        public String getWeapon() { return weapon; }    //Getter for weapon
        public String getRattle() { return rattle; }    //Getter for rattle
        public void setEnemy(Enemy enemy) { this.enemy = enemy; }       //Setter for enemy
        public void setWeapon(String weapon) { this.weapon = weapon; }  //Setter for weapon
        public void setRattle(String rattle) { this.rattle = rattle; }  //Setter for rattle
    }
}
