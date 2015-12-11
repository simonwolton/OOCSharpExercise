using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PocketMonsters
{
    public class Player
    {
        //Attributes
        string playerName;
        Monster activeMonster;
        Monster[] monsterParty = new Monster[6];
        Color playerColour;
        //Constructor
        public Player(string playerNameIn, Color playerColourIn)
        {
            playerName = playerNameIn;
            playerColour = playerColourIn;
        }

        //Methods
        public bool addMonster(Monster monsterIn)
        {
            for (int i = 0; i < monsterParty.Length; i++)
            {
                if (monsterParty[i] == null) // If a players party has space, continue
                {
                    monsterParty[i] = monsterIn;
                    return true;
                }
            }
            return false; // No space, so return false 
        }

        public string getPlayerName() { return playerName; }
        public Monster getActiveMonster() { return activeMonster; }
        public Monster[] getMonsterParty() { return monsterParty; }
        public Color getColour() { return playerColour; }

        public void setActiveMonster(Monster activeMonsterIn) { activeMonster = activeMonsterIn; }
        
        public bool isDefeated()
        {
            for (int i = 0; i < monsterParty.Length; i++)
            {
                if (monsterParty[i].getCurrentHealth() > 0) // First monster to have health returns false
                    return false;
            }
            return true; // Otherwise, they must be all dead, so return true
        }
    }
}
