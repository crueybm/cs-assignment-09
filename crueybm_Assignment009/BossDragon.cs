/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/26/2017
 * Assignment: 009
 * Description:  This class is used to create all Boss Dragons for the "game".  
 * It is derived from both Entity and Enemy, so it inherits the variables from the base classes.
 * The variable "loot" is declared here.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment009
{
    class BossDragon : Enemy
    {
        private Enemy enemy;    //Declares enemy
        private String loot;    //Declares loot

        public BossDragon(int hitPoints, int attack, int defense, int speed, String element, int rewardedExpreience, String loot)  //Creates the "BossDragon" constructor
            : base(hitPoints, attack, defense, speed, element, rewardedExpreience)
        {
            setEnemy(enemy);    //Sets enemy
            setLoot(loot);    //Sets loot
        }

        public Enemy getEnemy() { return enemy; }       //Getter for enemy
        public String getLoot() { return loot; }      //Getter for loot
        public void setEnemy(Enemy enemy) { this.enemy = enemy; }   //Setter for enemy
        public void setLoot(String loot) { this.loot = loot; }  //Setter for loot
    }
}
