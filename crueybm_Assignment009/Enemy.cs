/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/26/2017
 * Assignment: 009
 * Description:  This is the base class for all "enemy" characters in the "game".  
 * It is a derived from Entity, so it inherits the base class's variables.
 * It also adds the "element" and "rewardedExperience" variables.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment009
{
    class Enemy : Entity
    {
        private Entity entity;          //Declares Entity entity
        private String element;         //Declares String element
        private int rewardedExperience; //Declares int rewardedExperience

        public Enemy(int hitPoints, int attack, int defense, int speed, String element, int rewardedExperience) //Creates the "Enemy" constructor
            : base(hitPoints, attack, defense, speed)
        {
            setEntity(entity);                          //Sets entity
            setElement(element);                        //Sets element
            setRewardedExperience(rewardedExperience);  //Sets rewardedExperience
        }

        public Entity GetEntity() { return entity; }    //Getter for entity
        public String getElement() { return element; }  //Getter for element
        public int getRewardedExperience() { return rewardedExperience; }   //Getter for rewardedExperience
        public void setEntity(Entity entity) { this.entity = entity; }      //Setter for entity
        public void setElement(String element) { this.element = element; }  //Setter for element
        public void setRewardedExperience(int rewardedExperience) { this.rewardedExperience = rewardedExperience; } //Setter for rewardedExperience

    }
}
