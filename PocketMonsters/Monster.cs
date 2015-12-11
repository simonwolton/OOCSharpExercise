using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PocketMonsters
{
    public class Monster
    {
        //Attributes
        string name;
        int maxHealth;
        int currentHealth;
        //  DIDN'T NEED bool active;
        Move[] movelist = new Move[4];
        
        //Constructor
        public Monster(string nameIn, int healthIn)
        {
            name = nameIn;
            currentHealth = maxHealth = healthIn;
        }

        public bool addMove(Move moveIn)
        {
            for (int i = 0; i < movelist.Length; i++)
            {
                if (movelist[i] == null)
                {
                    movelist[i] = moveIn;
                    return true;
                }
            }
            return false;
        }
        public string getName() { return name; }
        public int getMaxHealth() { return maxHealth; }
        public int getCurrentHealth() { return currentHealth; }
        public bool isDead()
        {
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                return true;
            }
            else return false;
        }

        //public Move getMove(string moveNameIn)
        //{
        //    for (int i = 0; i <= movelist.Length; i++)
        //    {
        //        if (movelist[i].getName() == moveNameIn)
        //            return movelist[i];
        //    }
        //    return null;
        //}
        public Move[] getMovelist() { return movelist; }
        //  DIDN'T NEED public bool isActive() { return active; }

        public void takeDamage(int damageTaken) { currentHealth -= damageTaken; }
        // DIDN'T NEED public void setActive() { active = true; }
        
    }
}
