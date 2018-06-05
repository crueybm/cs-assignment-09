/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/26/2017
 * Assignment: 009
 * Description:  This class is used to create all zombies for the "game".  
 * It is derived from both Entity and Enemy, so it inherits the variables from the base classes.
 * The variable "noise" is declared here.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment009
{
    class Zombie : Enemy
    { 
        private Enemy enemy;    //Declares Enemy enemy
        private String noise;   //Declares String noise

        public Zombie(int hitPoints, int attack, int defense, int speed, String element, int rewardedExpreience, String noise)  //Creates the "Zombie" constructor
            : base(hitPoints, attack, defense, speed, element, rewardedExpreience)
        {
            setEnemy(enemy);    //Sets enemy
            setNoise(noise);    //Sets noise
        }

        public Enemy getEnemy() { return enemy; }       //Getter for enemy
        public String getNoise() { return noise; }      //Getter for noise
        public void setEnemy(Enemy enemy) { this.enemy = enemy; }   //Setter for enemy
        public void setNoise(String noise) { this.noise = noise; }  //Setter for noise
        
    }
}
