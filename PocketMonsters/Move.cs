using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocketMonsters
{
    public class Move
    {
        //Attributes
        string name;
        int power;
        //Constructor
        public Move(string nameIn, int powerIn) { name = nameIn; power = powerIn; }
        //Methods
        public string getName() { return name; }
        public int getPower() { return power; }

    }
}
