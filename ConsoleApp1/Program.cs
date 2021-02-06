using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;

namespace ConsoleApp1
{
  class Program
    {
    static void Main(string[] args)
     {
            bool exitApplication = false;
            do
            {

                string applicationTitle = "The Dead of the Night";
                Formatting.Header(applicationTitle);

                #region TitleCard
                Console.WriteLine(@" 

    ▄▄▄▄▀ ▄  █ ▄███▄       ██▄   ▄███▄   ██   ██▄       ████▄ ▄████         ▄▄▄▄▀ ▄  █ ▄███▄          ▄   ▄█   ▄▀   ▄  █    ▄▄▄▄▀ 
 ▀▀▀ █   █   █ █▀   ▀      █  █  █▀   ▀  █ █  █  █      █   █ █▀   ▀     ▀▀▀ █   █   █ █▀   ▀          █  ██ ▄▀    █   █ ▀▀▀ █    
     █   ██▀▀█ ██▄▄        █   █ ██▄▄    █▄▄█ █   █     █   █ █▀▀            █   ██▀▀█ ██▄▄        ██   █ ██ █ ▀▄  ██▀▀█     █    
    █    █   █ █▄   ▄▀     █  █  █▄   ▄▀ █  █ █  █      ▀████ █             █    █   █ █▄   ▄▀     █ █  █ ▐█ █   █ █   █    █     
   ▀        █  ▀███▀       ███▀  ▀███▀      █ ███▀             █           ▀        █  ▀███▀       █  █ █  ▐  ███     █    ▀      
           ▀                               █                    ▀                  ▀               █   ██            ▀            
                                         ▀       
                                          ,,,,,,,
                                ,╖@╫╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╬@╦╓,                                        
                           ┌@╢▒▒▒▒▒▒▒▒▒▒░░░░░░╜▒▒▒▒▒▒▒▒▒▒╢╣▓%╖        `                      `
                       ,╦╣▒▒▒░░░░░░░▒▒▒▒░░░░░░░░░░░▒▒▒░▒▒▒╢╣╫╢▒▓N,           '                     
                    ,╗╣▒▒▒▒▒░░░░░░░▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒▒╣╢╢╫╣╫╢▒▒@,              `      `       
                  ┌╬▒▒▒▒▒▒▒▒▒░░░▒▒╢▒▒▒░░▒░░░░░░░░▒@╣╢▒╫▒▒▒▒╢▒╢▒▒▒╢╢▒▒╣╖               `            
                ┌╣▒▒▒▒▒▒▒▒▒▒▒▒▒▒╢▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒╢╢▒▒╣w      '
              ,╣▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░▒▒▒▒▒▒▒▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒╣╢╢▒▒▓,            `          
             ╓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒╢▒▒▒▒▒▒▒▒▒▒╢▒▒╢▒╢▒╣@                 '
            ╫▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░▒░▒▒▒▒▒╢╣▒▒▒▒╢▒▒▒▒▒▒╫▒▒▒▒╢▒▒▓         `
           ╣▒▒▒▒▒▒▒▒▒▒░░░░▒░▒░░░░░░░░░░░░░░░░░░▒▒╢▒▒╣▒▒▒,   ╣▒▒▒╣▒▒▒▒▒▒▒▒▒▒▒▒╢ `           . 
          Æ╢▒╢╣▒▒▒▒▒▒░▒░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒  m╣▒▒╨▒▒▒▒▒▒▒▒▒▒▒▒▒╢
         ╒╣▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ,`,╓╫▒  `╙╩""]▒▒▒▒▒▒╫
         ╢╢╣╣▒▒░░▒░░░▒░░▒░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒▒▒▒@╗     ╣▒▒▒▒L
        ]▒▒▒▒▒▒░░░░╜(▒▒▒▒░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒╬   ,╙▒▒▒▒▒▒▒▒▒▒▓╣▒╢▒╣▒▒▒▒╫
        ║▒▒▒▒▒▒░░░▒▒`╓╖▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒[]▒▒, ╫╣▓▒╢▒╢▒▒╢▒╢▒▒╢▒
        ▒▒▒▒▒▒▒░░░▒ ╨╥╥'m▒▒░░░░░░░░░░░░░░░░░░▒░░░░▒╜▒   ░▒▒▒▒▒▒▒▒▒╦@╗▓╣╣╢╣▒▒╢╣▒▒╢▒⌐
        ▒▒▒▒▒▒▒▒░░░▒;=""╙ ╓░░░░░▒░░░▒▒▒░░░░░░░░░░░▒∩─┐  ,,,▒▒▒▒░░░░▒▒▒╢╢▒▒╣▒╢╣▒▒▒▒L
        ]▒▒▒▒▒▒░░░░▒▒▒`. └▒░░░░░░░░░░░░░░░░░░░░░`▒░░▒▒▒░░ ░░    ▒▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒`
         ▒▒▒▒▒▒░░░░▒░░░,  ▒░░░░░░▒`░░░░░░░░░░░ ░. ""▒▒▒░░     ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒
         ▒▒▒▒▒░▒░░░░▒░░░  ░░░░░░░  ░░░░░░░░ ,▒░░░░,─, ,░░░░░▒░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒╜
          ▒▒▒▒░░░░░▒░░░░  ,""░░,`  ,'░░░░░░░'▒░░,``▒░▒``▒░░░░░░░░░░░░░░░▒░▒▒▒░▒░▒
          '░░▒▒░░░░░▒ ``  ',,    ,  ░░░░░▒`▒▒▒░░▒╖  ,─░░░░░░░░░░░░░░░░░▒▒▒▒░░░░`
            ¡'▒░░░░▒▒▒╖.    ░:;        `*─ ]░░▒░░░░░░░░░,░░░░░░░░░░░░░░░░░░░░░'
            `░.,]░░░░░░░░            └ ,'    ∩░,, ░░░░░░░░░` ░░░`  `░░░░░░░░░`
               `` ░░░░░░,,░`     '~;  `  ─░░ '░░░``'░`░░` ` ░░░ `  ░░░░░░░░░
                    '░░░░░░░░,   :,        ░░░░░░`.░ ``   .░░░░░,,░░░▒░░░░`
                   '   `  ░░░░     `'    '░░░░░░░  ``'`````░░'²░░░░░░░░░
                                           '````   `   ` `' .,░░░░░░░'
                                         `             `   '░░░░░░░
                                                         ¡:░''
                                                        '  `
   __          __                 ___  __      __   __   __         
  |__) \ /    /__`  /\  |  | \ / |__  |__)    / _` /  \ |__) | |\ | 
  |__)  |     .__/ /~~\ |/\|  |  |___ |  \    \__> \__/ |__) | | \|  2021
                                                                  
                      Please play in fullscreen 

                      Press any key to begin!
     
");
                Formatting.MainTheme();
                Console.ReadKey(true);
                #endregion

                #region Items
                //TODO Create book class items
                //create potion class items
                //create potion class items
                #region Weapons
                //Starter Weapons, identical stats.
                Weapon stolenSword = new Weapon("Stolen Sword", "It's better if no one asks where you got this...", WeaponType.IronSword, 10, 1, 6, false);
                Weapon familySword = new Weapon("Family Sword", "It's old and well used. It has served your family for 3 generations now.", WeaponType.IronSword, 10, 1, 6, false);
                Weapon decorativeSword = new Weapon("Decorative Sword", "Intended to be buried with a warrior, not used in combat. But the blade is sharp and the tip still stabs.", WeaponType.IronSword, 10, 1, 6, false);
                Weapon ironSword = new Weapon("Iron Sword", "Your trusty iron sword, but it's nothing fancy", WeaponType.IronSword, 10, 1, 6, false);
                //Iron Sword placeholder default weapon.

                Weapon ruggedAxe = new Weapon("Rugged Axe", "It's seen heavy use, but this axe's sturdy construction has held thus far.", WeaponType.RuggedAxe, 5, 2, 5, false);
                Weapon ornateDagger = new Weapon("Ornate Dagger", "A small blade of masterful crafstmanship. Its handle and blade are inlaid with gold." +
                    "\nIt's very accurate but deals little damage", WeaponType.OrnateDagger, 30, 1, 4, false);
                Weapon fineSteelSword = new Weapon("Fine Steel Sword", "A well-made blade that any adventurer would be proud to call their own. You just happen to currently be that adventurer." +
                    "\nIt's stats are exceptionally well-rounded", WeaponType.FineSteelSword, 20, 3, 10, true);
                Weapon antiqueSpear = new Weapon("Antique Spear", "Don't let the fact that it's an antique fool you, \n" +
                    "this spear boasts solid construction and a jagged tip that deals large amounts of damage.", WeaponType.AntiqueSpear, 10, 5, 12, false);
                Weapon blessedSilverSword = new Weapon("Silvered Sword", "This masterwork blade was originally wielded by PLACEHOLDER.", WeaponType.BlessedSilverSword, 25, 5, 10, true);
                #endregion

                #endregion
                //TODO Create book class items
                //create potion class items
                //create potion class items

                #region Monsters
                Monster batSwarm = new Monster("Swarm of Bats", 10, 10, 30, 10, "This swarm of hungry bats works together with a " +
                    "\ncohesion that seems nearly sentient", 1, 4);


                List<Monster> allMonsters = new List<Monster>() {
                batSwarm

            };

                #endregion

                //TODO create room class and room index. Branch with room index number
                #region Rooms

                #endregion
                List<Item> inventory = new List<Item>(); //needs created before backstory for sword.
                #region Backstory Selection

                bool exitBackstorySelection = false;
                PlayerBackstory chosenBackstory = new PlayerBackstory();//Null initialization
                Weapon backgroundSword = ironSword;
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome to -{applicationTitle}-, player!  \n\nTo play this game, please you select with your number keys from a series of choices presented to you. \n\nIn this adventure you take on the role of a character who has sought out the rumored lair of an infamous vampire lord known as Avernia The Cruel \nYour objective is to battle and defeat the nefarious undead. \nSurely this task will prove neither simple nor easy, but your motivations are undertaking it are your own. \nChoose one of the following backstories to determine your character's history and motivations. \n\nIn other words: Who are you?");
                    Console.WriteLine(@"
+++++++++++++++
|Fortune Seeker:
+++++++++++++++
You grew up a nobody, and have always been treated as such. 
That’s about to change. Avernia's terrible reign has gone on far 
too long and the hero that kills her will instantly become a legend.
Hopefully if you secure ""fame"" then ""fortune"" falls right into place. 
And now all that stands in your way is a musty old undead. 
The stolen sword at your side is itching for a fight.");
                    Console.WriteLine(@"
+++++++++++++++++++
|Righteous Crusader: 
+++++++++++++++++++
All your training has led you to this moment. 
You’ve vanquished zombies and banished ghosts, 
yet the land is still blighted with evil. 
In your quest to travel the realm and rid it of evil, no deed shall 
be as noble or as harrowing as braving the castle that looms before you. 
The only thing stronger than your father’s sword at your side is your will.");
                    Console.WriteLine(@"
++++++++++++++++++++
|Discredited Scholar:
++++++++++++++++++++
They’re fools, the lot of them. How dare they laugh at your theories? 
The years you spent on research and the myriad of discoveries 
you made were dismissed as nonsense by the Board of Undead Authority. 
You decided to take matters into your own hands and 
provide a little hard evidence for 
your ""Vanquishing Elder Undead"" thesis. 
The sword in your scabbard may be a decorative piece, 
but you hypothesize it’ll perform it's duty all the same.

[1] Fortune Seeker
[2] Righteous Crusader
[3] Discredited Scholar");
                    ConsoleKey backstoryChoice = Console.ReadKey(true).Key;

                    switch (backstoryChoice)
                    {
                        case ConsoleKey.D1://fortune seeker
                        case ConsoleKey.NumPad1:
                            Console.Clear();
                            Console.WriteLine("You have chosen Fortune Seeker. May you find what you seek.\n");
                            chosenBackstory = PlayerBackstory.FortuneSeeker;
                            inventory.Add(stolenSword);
                            backgroundSword = stolenSword;
                            exitBackstorySelection = true;
                            break;

                        case ConsoleKey.D2://righteous crusader
                        case ConsoleKey.NumPad2:
                            Console.Clear();
                            Console.WriteLine("You have chosen Righteous Crusader. Your will shines like a beacon in the dark.\n");
                            chosenBackstory = PlayerBackstory.RighteousCrusader;
                            inventory.Add(familySword);
                            backgroundSword = familySword;
                            exitBackstorySelection = true;
                            break;

                        case ConsoleKey.D3://discredited scholar
                        case ConsoleKey.NumPad3:
                            Console.Clear();
                            Console.WriteLine("You have chosen Discredited Scholar. You'll show those stuck up fools you were right " +
                                "\neven if it's the last thing you do.\n");
                            chosenBackstory = PlayerBackstory.DiscreditedScholar;
                            inventory.Add(decorativeSword);
                            backgroundSword = decorativeSword;
                            exitBackstorySelection = true;
                            break;

                        default: //default
                            Console.Clear();
                            Console.WriteLine($"{backstoryChoice} is not a valid option, press any key to try again.");
                            Console.ReadKey(true);
                            break;
                    } //end switch
                } while (!exitBackstorySelection);
                #endregion

                #region Class Selection
                //TODO class selection process:
                PlayerClass chosenClass = new PlayerClass();//null initialization
                bool exitClassSelection = false;

                do
                {
                    Console.WriteLine($"Next, choose your character class. This choice affects your attributes and determines your combat style:");
                    Console.WriteLine(@"
+++++++++
|Warrior:
+++++++++
Some would call rushing headlong into danger with weapons brandished brave. Others may call it foolish. 
You would say the fine details aren’t really all that important and it’s got you this far. 
You know how to get the most out of any weapon you may use and you wear a patchwork set of armor for protection.
(+Weapon Damage +Defense)

+++++++
|Thief:
+++++++
Thief, Rogue, Swashbuckler, call it what you will. It’s no matter of debate that you possess a particular set of skills. 
All that’s left is to put them to a good use in a place full of treasures, traps, and tricks. Luckily, you know just the place...
When you attack, you do so with unerring accuracy and if you must flee, your light armor helps you get away safely.
(+Weapon Accuracy +Very high Dodge Chance when fleeing)

[1] Warrior
[2] Thief

");
                    ConsoleKey classChoice = Console.ReadKey(true).Key;
                    switch (classChoice)
                    {

                        case ConsoleKey.D1://Warrior
                        case ConsoleKey.NumPad1:
                            Console.Clear();
                            Console.WriteLine("You've chosen to face your foes head on as a Warrior.\n");
                            chosenClass = PlayerClass.Warrior;
                            exitClassSelection = true;
                            break;

                        case ConsoleKey.D2://Thief
                        case ConsoleKey.NumPad2:
                            Console.Clear();
                            Console.WriteLine("You've chosen to strike carefully and fight with cunning as a Thief.\n");
                            chosenClass = PlayerClass.Thief;
                            exitClassSelection = true;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine($"{classChoice} is not a valid option, press any key to try again.");
                            Console.ReadKey(true);
                            break;
                    }

                } while (!exitClassSelection);
                #endregion

                #region Name Selection
                Console.Write(@"A great philosopher once said

""Words may hold meaning
but names hold power"" 

What is your name?: ");
                string chosenName = Console.ReadLine().Trim();
                #endregion
                //creating hero with ctor.
                PlayerCharacter hero = new PlayerCharacter(chosenName, 30, 30, 40, 5, chosenBackstory, chosenClass, backgroundSword, inventory);
                //TODO Character Creation Logic: Backstory, Class, Name, (Horse's Name)
                Console.WriteLine("Test Display: " + hero);

                #region Combat Functionality

                Monster enemy = batSwarm; //Individualized enemy here
                Console.WriteLine($"A {enemy.Name} is attacking you! Get ready to fight!"); //Customize per encounter

                bool exitFight = false;
                do
                {
                    Console.WriteLine($"Choose an Action:" +
                        $"\n[1] Attack the {enemy.Name}" +
                        $"\n[2] Flee (Enemy will attempt to attack)" +
                        $"\n[3] View Your Stats" +
                        $"\n[4] View {enemy.Name}'s Stats" +
                        $"\n[5] Access Your Inventory");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.D1://Attack
                        case ConsoleKey.NumPad1:
                            Combat.Battle(hero, enemy);
                            if (enemy.Life <= 0)
                            {
                                Formatting.GreenText($"The {enemy.Name} now lies dead before you.");
                                //Switch a room bool here?
                                exitFight = true;
                            }
                            break;

                        case ConsoleKey.D2://Flee
                        case ConsoleKey.NumPad2:
                            if (hero.PlayerClass == PlayerClass.Thief)
                            {
                                Console.WriteLine($"As a thief, you have a high chance to avoid the {enemy.Name}'s attack while you flee");
                                hero.Defense += 50;
                                Combat.Attack(enemy, hero);
                                hero.Defense -= 50;
                            }
                            else
                            {
                                Console.WriteLine("As you flee, the {enemy} attempts to attack!");
                                Combat.Attack(enemy, hero);
                            }
                            break;

                        case ConsoleKey.D3://View Player Stats
                        case ConsoleKey.NumPad3:
                            Console.WriteLine(hero);
                            //TODO Add backstory functionality here
                            break;

                        case ConsoleKey.D4://View Monster Stats
                        case ConsoleKey.NumPad4:
                            Console.WriteLine(enemy);
                            //TODO Add backstory functionality here
                            break;

                        case ConsoleKey.D5://View Inventory
                        case ConsoleKey.NumPad5:
                            Console.WriteLine(inventory);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine($"{userChoice} is an invalid option, please try again.");
                            break;
                    }//end menu switch
                    if (hero.Life <= 0)
                    {
                        Console.WriteLine($"You have been slain by the {enemy.Name}. Your bones will lie here forever");
                        exitApplication = true;
                    }


                } while (!exitFight && !exitApplication);

                #endregion








            } while (!exitApplication);

            //TODO rand gen the end screen?
            #region Game Over
            Formatting.GameOverTheme();
            Console.WriteLine(@"
                                   ▄▄▄▄N▀▀▀██▌▄▄▄▄,
                               ▄█▀▀▄▄▄██▄▄,  ╙▀▌█▌▄▀▀▄,
                         ,▄▄▄▄▀▄▄██▀▀╙     ▀▀▀▄,╙▀██████▄,
                         █,▄▄▄██▀              ╙▀▄▄▄, ██████▄
                        █▄██▀▀▀                     █▌ ▀▓▀▀▀▀▄
                     ▄▌▀██▀                          ▀█▄ ▀▄   ▀▄
                   ▐█▄██▀                              ▀█▄,▀▀▄▄▓██
                   ▐▌█▌                                  -█▌j███▓█⌐
                   ▐▌█▌                                   █ j███▓█
                   ▄█▀    █▀██▀▄        ███        █ █▀█  └█▄███▓█
                   █      █    █         █         █    ▌   ████▓█
                   █      █   ▄▀         █         █  ▄█    ████▓█⌐
                   ▀█▄    █▀ ▀▄          █         █ █     ▄▀███▓▓U
                    ▐█    █    █         █         █      █  ███▓█U
                    ▐█    ▀▀   ▀▀       ███        ▀      ▌  ███▓█▌
                    ▐█                                    █  █████▌
                    ▐█                                    █  ███▌█▌
                    ▐█                                    █  ███▌▓▌
                    ▐█                                    █  ████▓▌
                    ▐█                                    █  ████▌▌
                    j█                                    █  ████▌▌
                    -█                                    █  █████▌
                     █                                    █  ██████
                     █                                    █  ██████
                     █                                    ▐  ██████
                     █                                    ▐U ▓█████
                     █                                    █  ▐█████
                     █                                    █  ▐█████
                    ,█                                    ▐  ██████
                   j█                                      ▀▄██████
                   ▐█                                       ▐██████
                   ¬█                                       ▐██████
                    █                                       ▐██████
                    █                                       ▐██████U
                  ,▄█▄▄▄▄▄▄▄,,,,,,,,,,,,                    ▐██████▄▄▄,
             ]████▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄,▐,▐▐▐▐▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████████████▌
             ▐█             ``-- ``  ╙╙╙▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████████▌█▌
             j█                                                ▐███████▌█▌
             j█                                                J███████▌█▌
              █                                                ¬█████████▌
              █                                                j███████▌▌▌
     
     
");

            #endregion

            

        }//end Main()
  }//end class
}//end namespace
