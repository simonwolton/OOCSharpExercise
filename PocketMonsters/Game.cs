using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PocketMonsters
{
    public class Game
    {
        //Player p1 = new Player(
        //        "Player 1",
        //        new Monster("Charmander", 80, new Move("Flame Wheel", 25), new Move("Ember", 15), new Move("Flamethrower", 50), new Move("Slash", 35)),
        //        new Monster("Squirtle", 90, new Move("Water Gun", 25), new Move("Skull Bash", 40), new Move("Bite", 30), new Move("Hydro Pump", 45)),
        //        new Monster("Bulbasaur", 100, new Move("Vine Whip", 25), new Move("Razor Leaf", 35), new Move("SolarBeam", 40), new Move("Tackle", 20)),
        //        new Monster("Nidoking", 120, new Move("Poison Sting", 5), new Move("Horn Attack", 35), new Move("Double Kick", 20), new Move("Thrash", 40)),
        //        new Monster("Gengar", 80, new Move("Lick", 15), new Move("Shadow Ball", 50), new Move("Thunder", 60), new Move("Shadow Punch", 40)),
        //        new Monster("Alakazam", 80, new Move("Focus Punch", 60), new Move("Confusion", 30), new Move("Psybeam", 45), new Move("Psychic", 50)));

        //Player p2 = new Player(
        //        "Player 2",
        //        new Monster("Monster1", 80, new Move("Flame Wheel", 25), new Move("Ember", 15), new Move("Flamethrower", 50), new Move("Slash", 35)),
        //        new Monster("Monster2", 110, new Move("Water Gun", 25), new Move("Skull Bash", 40), new Move("Bite", 30), new Move("Hydro Pump", 45)),
        //        new Monster("Monster3", 110, new Move("Vine Whip", 25), new Move("Razor Leaf", 35), new Move("SolarBeam", 40), new Move("Tackle", 20)),
        //        new Monster("Monster4", 1110, new Move("Poison Sting", 5), new Move("Horn Attack", 35), new Move("Double Kick", 20), new Move("Thrash", 40)),
        //        new Monster("Monster5", 10, new Move("Lick", 15), new Move("Shadow Ball", 50), new Move("Thunder", 60), new Move("Shadow Punch", 40)),
        //        new Monster("Monster6", 110, new Move("Focus Punch", 60), new Move("Confusion", 30), new Move("Psybeam", 45), new Move("Psychic", 50)));

        //Attributes
        Player[] player = new Player[2];
        Player activePlayer;
        Player opposingPlayer;
        Player winner;
        //Constructor
        public Game() 
        {
            player = initialMonsters();
            activePlayer = player[0];
            opposingPlayer = player[1];
        }
        //Methods
        public bool addPlayer(Player playerIn)
        {
            for (int i = 0; i < player.Length; i++)
            {
                if (player[i] == null)
                {
                    player[i] = playerIn;
                    return true;
                }
            }
            return false;
        }

        //public Player getPlayer(int playerID) { return player[playerID]; }
        public Player getActivePlayer() { return activePlayer; }
        public Player getOpposingPlayer() { return opposingPlayer; }
        public Player getWinner() { return winner; }

        public void setActivePlayer(Player playerIn) {activePlayer = playerIn;}
        public void setOpposingPlayer(Player playerIn) { opposingPlayer = playerIn; }
        public void setWinner(Player playerIn) { winner = playerIn; }
        //public bool takeTurn()
        //{
        //    return true;
        //}
        public bool endTurn()
        {
            Player tempActivePlayer = getActivePlayer();
            setActivePlayer(getOpposingPlayer());
            setOpposingPlayer(tempActivePlayer);
            return true;
        }

        private Player[] initialMonsters()
        {
            // ### Moves ###

            // Normal Type
            Move slash = new Move("Slash", 35);
            Move skullbash = new Move("Skull Bash", 40);
            Move bite = new Move("Bite", 30);
            Move tackle = new Move("Tackle", 20);
            Move hornattack = new Move("Horn Attack", 35);
            Move thrash = new Move("Thrash", 40);
            Move headbutt = new Move("Headbutt", 35);
            Move megapunch = new Move("Mega Punch", 40);
            Move bodyslam = new Move("Body Slam", 40);
            Move stomp = new Move("Stomp", 35);
            Move swift = new Move("Swift", 30);


            // Electric Type
            Move thunderbolt = new Move("Thunderbolt", 45);
            Move thunder = new Move("Thunder", 60);
            Move thundershock = new Move("ThunderShock", 20);

            // Fire Type
            Move flamewheel = new Move("Flame Wheel", 25);
            Move ember = new Move("Ember", 15);
            Move flamethrower = new Move("Flamethrower", 60);

            // Water Type
            Move watergun = new Move("Water Gun", 25);
            Move hydropump = new Move("Hydro Pump", 60);

            // Grass Type
            Move vinewhip = new Move("Vine Whip", 25);
            Move razorleaf = new Move("Razor Leaf", 35);
            Move solarbeam = new Move("SolarBeam", 60);

            // Ghost Type
            Move lick = new Move("Lick", 15);
            Move shadowball = new Move("Shadow Ball", 60);
            Move shadowpunch = new Move("Shadow Punch", 40);

            // Psychic Type
            Move confusion = new Move("Confusion", 30);
            Move psybeam = new Move("Psybeam", 40);
            Move psychic = new Move("Psychic", 60);

            // Misc Type
            Move poisonsting = new Move("Poison Sting", 10);
            Move doublekick = new Move("Double Kick", 20);
            Move focuspunch = new Move("Focus Punch", 60);
            Move rockslide = new Move("Rock Slide", 30);

            // Ground Type
            Move earthquake = new Move("Earthquake", 60);

            // Ice Type
            Move icebeam = new Move("Ice Beam", 40);
            Move blizzard = new Move("Blizzard", 60);


            // ### Monsters ###

            Monster charmander = new Monster("Charmander", 80);
            charmander.addMove(flamewheel);
            charmander.addMove(ember);
            charmander.addMove(flamethrower);
            charmander.addMove(slash);

            Monster squirtle = new Monster("Squirtle", 90);
            squirtle.addMove(watergun);
            squirtle.addMove(skullbash);
            squirtle.addMove(bite);
            squirtle.addMove(hydropump);

            Monster bulbasaur = new Monster("Bulbasaur", 100);
            bulbasaur.addMove(vinewhip);
            bulbasaur.addMove(razorleaf);
            bulbasaur.addMove(solarbeam);
            bulbasaur.addMove(tackle);

            Monster nidoking = new Monster("Nidoking", 120);
            nidoking.addMove(earthquake);
            nidoking.addMove(hornattack);
            nidoking.addMove(icebeam);
            nidoking.addMove(thrash);

            Monster gengar = new Monster("Gengar", 80);
            gengar.addMove(lick);
            gengar.addMove(shadowball);
            gengar.addMove(shadowpunch);
            gengar.addMove(thunderbolt);

            Monster alakazam = new Monster("Alakazam", 80);
            alakazam.addMove(focuspunch);
            alakazam.addMove(confusion);
            alakazam.addMove(psybeam);
            alakazam.addMove(psychic);

            Monster pikachu = new Monster("Pikachu", 80);
            pikachu.addMove(thundershock);
            pikachu.addMove(thunderbolt);
            pikachu.addMove(megapunch);
            pikachu.addMove(thunder);

            Monster dugtrio = new Monster("Dugtrio", 80);
            dugtrio.addMove(bodyslam);
            dugtrio.addMove(rockslide);
            dugtrio.addMove(slash);
            dugtrio.addMove(earthquake);

            Monster rapidash = new Monster("Rapidash", 80);
            rapidash.addMove(ember);
            rapidash.addMove(flamethrower);
            rapidash.addMove(stomp);
            rapidash.addMove(swift);

            Monster nidoqueen = new Monster("Nidoqueen", 100);
            nidoqueen.addMove(bodyslam);
            nidoqueen.addMove(poisonsting);
            nidoqueen.addMove(megapunch);
            nidoqueen.addMove(blizzard);

            Monster gyarados = new Monster("Gyarados", 80);
            gyarados.addMove(hydropump);
            gyarados.addMove(tackle);
            gyarados.addMove(icebeam);
            gyarados.addMove(thunderbolt);

            Monster snorlax = new Monster("Snorlax", 130);
            snorlax.addMove(headbutt);
            snorlax.addMove(bodyslam);
            snorlax.addMove(solarbeam);
            snorlax.addMove(earthquake);

            // ### Players ###

            Player p1 = new Player("Player 1", Color.Red);
            p1.addMonster(charmander);
            p1.addMonster(squirtle);
            p1.addMonster(bulbasaur);
            p1.addMonster(nidoking);
            p1.addMonster(gengar);
            p1.addMonster(alakazam);

            Player p2 = new Player("Player 2", Color.Blue);
            p2.addMonster(pikachu);
            p2.addMonster(dugtrio);
            p2.addMonster(rapidash);
            p2.addMonster(nidoqueen);
            p2.addMonster(gyarados);
            p2.addMonster(snorlax);

            Player[] output = {p1, p2};
            return output;
        }

        public void anyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) //If the User Closed a form
                Environment.Exit(1); // Close the application entirely
        }
    }
}
