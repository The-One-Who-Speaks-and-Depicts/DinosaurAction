﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Int32;

namespace TrialGame
{
    public class Tile
    {
        int m_coordX = 0;
        int m_coordY = 0;

       

        public static void CreatureCall(YourCreature a, YourCreature.EnemyCreature b, int key)
        {
            Console.WriteLine("To attack {0}, press 1, to stealth attack {0}, press 2", b.name);
            int m_decision = Program.ChoosingRightKey();
            switch (m_decision)
            {
                case 1:
                    YourCreature.EnemyCreature.Attack(a, b);
                    break;
                case 2:
                    YourCreature.EnemyCreature.StealthAttack(a, b);
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }

        enum ELandscape
        {
            Peak,
            Mountainside,
            Waterfall,
            Cloud_forest,
            Forest,
            Steppe,
            Riverside,
            Nest
        }

        enum EYearTime
        {
            Winter,
            Spring,
            Summer,
            Fall
        }

        enum EDirection
        {
            northEast,
            north,
            northWest,
            west,
            southWest,
            south,
            southEast,
            east,
            noDir
        }

        string[] m_yeartimeDesc = new string[] 
        {
            "winter. The night of the existence, the night eternal. It is cold, and sometimes water in the skies freezes, unleashing a phenomenon of blue stars, which have not been there for years. Leaves and pins fall, and only little amount of trees does stand green and bold in this kingdom of nothingness. Life, however, still makes it through.",
            "spring. The great renewal, when the first rays of still weak sun shine over the domain of darkness, which Antarctica used to be for months and months. Every single being awakens from the state of sleepness and apathy, and the vegetation is again green and flourishing. For the single moment hope is again in this land.",
            "summer. Warm, sometimes even hot. The period of mating and big hunt for all and for each in this place. Sun shines throughout all the summer, which is good for both predators and prey, but for different reasons. Occasional rains does not spoil the overall great impression, and for some make it even better.",
            "fall. The time of beautiful sunsets and yellow leaves, when the new life begins its harsh journey through the very being in this region. It is time of nesting for ones and going out of eggs for others. And the end of year is coming, so nights are longer and colder, until sun is no more."
        };
        string[] m_landscapeDesc = new string[] 
        {
            "one of the highest peaks in the Antarctica of early Jurassic, the predecessor of Terror volcano. The witness of collisions that took place long before this day, before even the continent of the Whole Earth was formed. It is slippery and dangerous, and virtually nothing exists here. Even pterosauruses cry beneath you in the Deep of this mountains.",
            "hollow and lifeless, greyish with grains of white ice terrain of mountainside. Rare, desperate and miserable ones are to take courage by going there. Even grass does not grow here, and fish does not inhabitate small rivers that spring through the area. There is nobody to eat here, but at least there is something to drink.",
            "beautiful waterfall, an alliance of springs, culminating in great mass of water, falling down the mountain. Unfortunately, there is basically nobody to value this scape of beauty. Only some giant fish inhabits the pond beneath, waiting for its rare prey. And prey there is in a warm summer days, when river and air predators come for energetically valuable food, shrimps.",
            "clouds, coming through your feet. You are surrounded by the forest of taiga, where coniferous trees are growing. Pterosauruses are nesting somewhere here, and only the greatest specialists in survival can rival them in this area. Though, there are a lot of smaller, more unusual and wonderful creatures.",
            "gymnasia trees, the relatives of pine trees, that close the skies with their crowns. Pterosauruses cry highly above you. Lots of your fellow dinosaur predators are sneaking there, and herbivores are coming as well. It is also a nesting area, which promises both trouble and easy food. The rivers are full of fish, but river flows are strong, so the activity is quite dangerous.",
            "prehistoric bush, consisting mostly of trees of little size and some spore plants. It is a land of big herbivore dinosaurs, which are hunted by the most dangerous predators of the continent. It is a land of real danger for even adult cryolophosaurus, let alone the young ones. The only safe choice here would be fishing in big and calm rivers.",
            "area of plants and lakes, dominated by cryptogamics. Fish is in enormous quantities, and that attracts great packs of pterosaurus. The biggest herbivores find there their safe heaven, which is totally inacessible by the largest predators of land. However, deeps of lakes are inhabitated by ancient monsters, and it is still not fully secure to walk there jauntily.",
            "nest of dinosaur. A small mound of sand and dust that protects vulnerable eggs. For some, it means necessity of protection, for others it means a reason to attack and eat. The only choice is a practical one, and depends on whom one wishes to continue their live. And, of course, one had better to watch out for angry mother."
        };

        void choosingDirection(string direction)
        {
            if ((direction.Equals(EDirection.northEast.ToString())) || (direction.Equals(EDirection.north.ToString())) || (direction.Equals(EDirection.northWest.ToString())))
            {
                m_coordY++;
            }
            else if ((direction.Equals(EDirection.southEast.ToString())) || (direction.Equals(EDirection.south.ToString())) || (direction.Equals(EDirection.southWest.ToString())))
            {
                m_coordY--;
            }
            else if ((direction.Equals(EDirection.northEast.ToString())) || (direction.Equals(EDirection.east.ToString())) || (direction.Equals(EDirection.southEast.ToString())))
            {
                m_coordX++;
            }
            else if ((direction.Equals(EDirection.northWest.ToString())) || (direction.Equals(EDirection.west.ToString())) || (direction.Equals(EDirection.southWest.ToString())))
            {
                m_coordX--;
            }
            
        }

        void choosingYearTime (string yeartime)
        {
            if (yeartime.Equals(EYearTime.Winter.ToString()))
            {
                Console.WriteLine("It's {0}", m_yeartimeDesc[0]);
            }

            else if (yeartime.Equals(EYearTime.Spring.ToString()))
            {
                Console.WriteLine("It's {0}", m_yeartimeDesc[1]);
            }

            else if (yeartime.Equals(EYearTime.Summer.ToString()))
            {
                Console.WriteLine("It's {0}", m_yeartimeDesc[2]);
            }

            else if (yeartime.Equals(EYearTime.Fall.ToString()))
            {
                Console.WriteLine("It's {0}", m_yeartimeDesc[3]);
            }
        }

        void choosingLandscape(string landscape)
        {
            if (landscape.Equals(ELandscape.Peak.ToString()))
            {
                Console.WriteLine("You can see {0}", m_landscapeDesc[0]);
            }
            else if (landscape.Equals(ELandscape.Mountainside.ToString()))
            {
                Console.WriteLine("You can see {0}", m_landscapeDesc[1]);
            }
            else if (landscape.Equals(ELandscape.Waterfall.ToString()))
            {
                Console.WriteLine("You can see {0}", m_landscapeDesc[2]);
            }
            else if (landscape.Equals(ELandscape.Cloud_forest.ToString()))
            {
                Console.WriteLine("You can see {0}", m_landscapeDesc[3]);
            }
            else if (landscape.Equals(ELandscape.Forest.ToString()))
            {
                Console.WriteLine("You can see {0}", m_landscapeDesc[4]);
            }
            else if (landscape.Equals(ELandscape.Steppe.ToString()))
            {
                Console.WriteLine("You can see {0}", m_landscapeDesc[5]);
            }
            else if (landscape.Equals(ELandscape.Riverside.ToString()))
            {
                Console.WriteLine("You can see {0}", m_landscapeDesc[6]);
            }
            else if (landscape.Equals(ELandscape.Nest.ToString()))
            {
                Console.WriteLine("You can see {0}", m_landscapeDesc[7]);
            }
        }

        int CreatureAmount ()
        {
            Random creatureQuantity = new Random();
            int returnablecreatureQuantity = creatureQuantity.Next(1, 5);
            return returnablecreatureQuantity;
        }
       
        public Tile (string direction, string yeartime, string landscapetype, YourCreature a)
        {
            choosingDirection(direction);
            choosingYearTime(yeartime);
            choosingLandscape(landscapetype);
            int creatures = CreatureAmount();
            for (int creatureScore = 0; creatureScore < creatures; creatureScore++)
            {
                YourCreature.EnemyCreature.Spawn();
            }
            Console.WriteLine("Your coordinates are {0}, {1}", m_coordX, m_coordY);
            int click = -1;
            int m_decision = -1;
            do
            {
                Console.WriteLine("To see main menu, press 1");
                m_decision = Program.ChoosingRightKey();
                if (m_decision == 1)
                    do
                    {
                        Console.WriteLine("Press 7 to quit main menu, 8 to save, press 9 to get stats, press 0 to exit");
                        click = Program.ChoosingRightKey();
                        if (click == 0) Program.Exit_Game();
                        else if (click == 9) a.PrintCharacterStats();
                        else if (click == 8) Program.Save_Game();
                    }
                    while (click != 7);
            }
            while (m_decision != 2); 
        }

        public Tile(string direction, string yeartime, string landscapetype, YourCreature a, int creatureAmount, int spawnedCreature)
        {
            Console.WriteLine("Your coordinates are {0}, {1}", m_coordX, m_coordY);
            choosingDirection(direction);
            choosingYearTime(yeartime);
            choosingLandscape(landscapetype);
            int creatures = CreatureAmount();
            YourCreature.EnemyCreature b = YourCreature.EnemyCreature.TutorialSpawn(spawnedCreature);
            
            int click = -1;
            int m_decision = -1;
            do
            {
                Console.WriteLine("To see main menu, press 1");
                m_decision = Program.ChoosingRightKey();
                if (m_decision == 1)
                    do
                    {
                        CreatureCall(a, b, 1);
                        Console.WriteLine("Press 7 to quit main menu, 8 to save, press 9 to get stats, press 0 to exit");
                        click = Program.ChoosingRightKey();
                        if (click == 0) Program.Exit_Game();
                        else if (click == 9) a.PrintCharacterStats();
                        else if (click == 8) Program.Save_Game();
                    }
                    while (click != 7);
            }
            while (m_decision != 2); 
        }
        
        

        
    }
}