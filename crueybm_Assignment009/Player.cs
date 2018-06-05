/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/26/2017
 * Assignment: 009
 * Description: This class is the "player's" character. 
 * It is derived from Entity, so it inherits those variables.
 * The "playerClass" and "weapon" variables are also set in this class.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment009
{
    class Player : Entity
    {
        private Entity entity;          //Declares Entity "entity"
        private String playerClass;     //Declares String playerClass
        private String weapon;          //Declares String weapon


        public Player(int hitPoints, int attack, int defense, int speed, String playerClass, String weapon)     //Creates the "Player" constructor
            : base(hitPoints, attack, defense, speed)
        {
            setEntity(entity);              //Sets the "player" as an Entity
            setPlayerClass(playerClass);    //Sets playerClass
            setWeapon(weapon);              //Sets weapon
        }

        public Entity getEntity() { return entity; }            //Getter for entity
        public String getPlayerClass() { return playerClass; }  //Getter for playerClass
        public String getWeapon() { return weapon; }            //Getter for weapon
        public void setEntity(Entity entity) { this.entity = entity; }                      //Setter for entity
        public void setPlayerClass(String playerClass) { this.playerClass = playerClass; }  //Setter for playerClass
        public void setWeapon(String weapon) { this.weapon = weapon; }                      //Setter for weapon
    }
}
