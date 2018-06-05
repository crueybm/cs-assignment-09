/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 10/26/2017
 * Assignment: 009
 * Description:  This console application produces an example of how inheritance works.  
 * The main calls on the derived classes of "Entity" to play a "game" with them.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace crueybm_Assignment009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It Begins!");
            Player user = new Player(100, 30, 5, 5, "Barbarian", "Axe");                                //Creates a new Player named "user"
            InnKeeper ik1 = new InnKeeper(30, 5, 2, 3, 10, "Inn Keeper", "Amadeus");                    //Creates a new InnKeeper
            Zombie shambler = new Zombie(50, 10, 5, 5, "Poison", 10, "braaaaains");                     //Creates a new Zombie
            Skeleton warrior = new Skeleton(50, 15, 10, 5, "None", 15, "Sword", "Xylophone noises");    //Creates a new Skeleton
            Skeleton shiningWarrior = new Skeleton(75, 20, 10, 5, "None", 25, "Trumpet", "doot doot");  //Creates another Skeleton
            BossDragon ice = new BossDragon(300, 50, 50, 10, "ice", 100, "Ice Blade");                  //Creates a Boss Dragon
            Console.WriteLine("You have selected a " + user.getPlayerClass() + ", wielding an " + user.getWeapon() + ".");
            Console.WriteLine("Currently you are at level one, your hp is " + user.getHitPoints() + ", attack is " + user.getAttack() +
                              ", defense is " + user.getDefense() + ", speed is " + user.getSpeed());
            Console.WriteLine("Walking through the woods, you hear " + warrior.getRattle() + ", and are suddenly ambushed by a gang of spooky skeletons.");
            Console.WriteLine("They each try to attack you with their " + warrior.getWeapon() + ", but you fight back and defeat them all.");
            Console.WriteLine("Suddenly, a shining skeleton emerges from the trees, wielding a " + shiningWarrior.getWeapon() + ".");
            Console.WriteLine("It looks at you, brings the trumpet to its jaw, and you hear " + shiningWarrior.getRattle() + ", somehow despite it not having lungs.");
            Console.WriteLine("The skeleton runs away, and suddenly you hear something say " + shambler.getNoise() + ".  A lone zombie wanders towards you, " +
                              "but you strike it and deplete all " + shambler.getHitPoints() + " of it's hit points.");
            Console.WriteLine("After walking further into the snowy forest, you are attacked by an " + ice.getElement() + " dragon.");
            Console.WriteLine("You stand no chance, as its hp is " + ice.getHitPoints() + " and its defense is " + ice.getDefense() + ".");
            Console.WriteLine("The dragon freezes you solid, so you miss out on " + ice.getRewardedExperience() + " experience, and the " + ice.getLoot());
            Console.WriteLine("Waking up in the town inn, the " + ik1.getOccupation() + " " + ik1.getName() + " asks you how your nap was, and if you had any interesting dreams.");
        }
    }
}
