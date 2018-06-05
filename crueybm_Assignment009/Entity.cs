/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/26/2017
 * Assignment: 009
 * Description: This class is designed to be the base class for all entities in the "game".  
 * It contains basic stats, such as hit points, attack, defense, and speed.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment009
{
    class Entity
    {
        private int hitPoints;      //Declares int hitPoints
        private int attack;         //Declares int attack
        private int defense;        //Declares int defense
        private int speed;          //Declares int speed

        public Entity(int hitPoints, int attack, int defense, int speed)    //Creates the "Entity" constructor
        {
            setHitPoints(hitPoints);                                        //Sets int hitPoints
            setAttack(attack);                                              //Sets int attack
            setDefense(defense);                                            //Sets int defense
            setSpeed(speed);                                                //Sets int speed
        }

        public int getHitPoints() { return hitPoints; }                     //Getter for hitPoints
        public int getAttack() { return attack; }                           //Getter for attack
        public int getDefense() { return defense; }                         //Getter for defense
        public int getSpeed() { return speed; }                             //Getter for speed

        public void setHitPoints(int hitPoints) { this.hitPoints = hitPoints; }     //Setter for hitPoints
        public void setAttack(int attack) { this.attack = attack; }                 //Setter for attack
        public void setDefense(int defense) { this.defense = defense; }             //Setter for defense
        public void setSpeed(int speed) { this.speed = speed; }                     //Setter for speed
    }
}
