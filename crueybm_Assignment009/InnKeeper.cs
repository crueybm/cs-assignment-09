/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/26/2017
 * Assignment: 009
 * Description:  This class is used to create all Inn Keepers for the "game".  
 * It is derived from both Entity and NonPlayerCharacter, so it inherits the variables from the base classes.
 * The variable "name" is declared here.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crueybm_Assignment009
{
    class InnKeeper : NonPlayerCharacter
    {
        private NonPlayerCharacter nonPlayerCharacter;  //Declares NonPlayerCharacter nonPlayerCharacter
        private String name;                            //Declares String name

        public InnKeeper(int hitPoints, int attack, int defense, int speed, int rewardedExperience, String occupation, String name) //Creates the "InnKeeper" constructor
            : base(hitPoints, attack, defense, speed, rewardedExperience, occupation)
        {
            setNonPlayerCharacter(nonPlayerCharacter);  //Sets nonPlayerCharacter
            setName(name);                              //Sets name
        }

        public NonPlayerCharacter getNonPlayerCharacter() { return nonPlayerCharacter; }    //Getter for nonPlayerCharacter
        public String getName() { return name; }                                            //Getter for name
        public void setNonPlayerCharacter(NonPlayerCharacter nonPlayerCharacter) { this.nonPlayerCharacter = nonPlayerCharacter; }  //Setter for nonPlayerCharacter
        public void setName(String name) { this.name = name; }  //Setter for name
    }
}
