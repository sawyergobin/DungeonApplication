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

                //TODO FIX FLEE FUNCTIONALITY
                //TODO FIX Looting from room itemlist
                //TODO Redo camp description reassignment in new style


                #region TitleCard
                Console.WriteLine(@" 

    ▄▄▄▄▀ ▄  █ ▄███▄       ██▄   ▄███▄   ██   ██▄       ████▄ ▄████         ▄▄▄▄▀ ▄  █ ▄███▄          ▄   ▄█   ▄▀   ▄  █    ▄▄▄▄▀ 
 ▀▀▀ █   █   █ █▀   ▀      █  █  █▀   ▀  █ █  █  █      █   █ █▀   ▀     ▀▀▀ █   █   █ █▀   ▀          █  ██ ▄▀    █   █ ▀▀▀ █    
     █   ██▀▀█ ██▄▄        █   █ ██▄▄    █▄▄█ █   █     █   █ █▀▀            █   ██▀▀█ ██▄▄        ██   █ ██ █ ▀▄  ██▀▀█     █    
    █    █   █ █▄   ▄▀     █  █  █▄   ▄▀ █  █ █  █      ▀████ █             █    █   █ █▄   ▄▀     █ █  █ ▐█ █   █ █   █    █     
   ▀        █  ▀███▀       ███▀  ▀███▀      █ ███▀             █           ▀        █  ▀███▀       █  █ █  ▐  ███     █    ▀      
           ▀                               █                    ▀                  ▀               █   ██            ▀            
                                         ▀       
                                          ,,,,,,,                                                               '
                                ,╖@╫╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╬@╦╓,                           .                '               
                           ┌@╢▒▒▒▒▒▒▒▒▒▒░░░░░░╜▒▒▒▒▒▒▒▒▒▒╢╣▓%╖        `                      `            '   
                       ,╦╣▒▒▒░░░░░░░▒▒▒▒░░░░░░░░░░░▒▒▒░▒▒▒╢╣╫╢▒▓N,           '                   '                    
                    ,╗╣▒▒▒▒▒░░░░░░░▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒▒╣╢╢╫╣╫╢▒▒@,      '        `      `           '             
                  ┌╬▒▒▒▒▒▒▒▒▒░░░▒▒╢▒▒▒░░▒░░░░░░░░▒@╣╢▒╫▒▒▒▒╢▒╢▒▒▒╢╢▒▒╣╖               `           '             
                ┌╣▒▒▒▒▒▒▒▒▒▒▒▒▒▒╢▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒╢╢▒▒╣w      '             '                  
              ,╣▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░▒▒▒▒▒▒▒▒░░░▒░▒▒▒▒▒▒▒▒  ╣╢╢▒▒▓,            `          '
             ╓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒╢▒▒▒▒▒▒▒▒▒ ╢▒▒╢▒╢▒╣@                 '
            ╫▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░▒░▒▒▒▒▒╢╣▒▒▒▒╢▒▒▒▒    ▒▒▒╢▒▒▓         `          .
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

                #region Weapons
                //Starter Weapons, identical stats.
                Weapon stolenSword = new Weapon("Stolen Sword", "It's better if no one asks where you got this...", WeaponType.IronSword, 10, 1, 6, false);
                Weapon familySword = new Weapon("Family Sword", "It's old and well used. It has served your family for 3 generations now.", WeaponType.IronSword, 10, 1, 6, false);
                Weapon decorativeSword = new Weapon("Decorative Sword", "Intended to be buried with a warrior, not used in combat. But the blade is sharp and the tip still stabs.", WeaponType.IronSword, 10, 1, 6, false);
                Weapon ironSword = new Weapon("Iron Sword", "Your trusty iron sword, but it's nothing fancy", WeaponType.IronSword, 10, 1, 6, false);
                //Iron Sword is a placeholder default weapon.

                Weapon ruggedAxe = new Weapon("Rugged Axe", "It's seen heavy use, but this axe's sturdy construction has held thus far.", WeaponType.RuggedAxe, 5, 2, 5, false);
                Weapon ornateDagger = new Weapon("Ornate Dagger", "A small blade of masterful crafstmanship. Its handle and blade are inlaid with gold." +
                    "\nIt's very accurate but deals little damage", WeaponType.OrnateDagger, 30, 1, 4, false);
                Weapon fineSteelSword = new Weapon("Fine Steel Sword", "A well-made blade that any adventurer would be proud to call their own. You just happen to currently be that adventurer." +
                    "\nIt's stats are exceptionally well-rounded", WeaponType.FineSteelSword, 20, 3, 10, true);
                Weapon antiqueSpear = new Weapon("Antique Spear", "Don't let the fact that it's an antique fool you, \n" +
                    "this spear boasts solid construction and a jagged tip that deals large amounts of damage.", WeaponType.AntiqueSpear, 10, 5, 12, false);
                Weapon blessedSilverSword = new Weapon("Silvered Sword", "This masterwork blade was originally wielded by PLACEHOLDER.", WeaponType.BlessedSilverSword, 25, 5, 10, true);

                Weapon developerBlade = new Weapon("DEVELOPER BLADE", "Now that's OP", WeaponType.DevBlade, 50, 30, 30, true);
                #endregion

                #region Books
                Book tatteredJournal = new Book("Tattered Journal", "It appears this small, leather-bound book was well used prior to a long exposure to the elements. Most of it is unreadable but the last passage is legible.", "Tattered Journal PLACEHOLDER CONTENT");
                #endregion

                #region Other Items
                OtherItem HolyWaterAmulet = new OtherItem("Holy Water Amulet", "Folklore says having this on your person helps ward off undead. Can't hurt to have it, right?", true);

                #endregion

                #endregion

                #region Monsters
                //TODO Create All Monsters
                //TODO Create Vampire child class
                Monster batSwarm = new Monster("Swarm of Bats", 10, 10, 30, 10, "This swarm of hungry bats works together with a " +
                    "\ncohesion that seems nearly sentient", 1, 4);


                List<Monster> allMonsters = new List<Monster>() {
                batSwarm

            };

                #endregion


                #region Rooms

                //Remember to create RoomLoot list before the room.
                List<Weapon> drawBridgeEntranceWeaponLoot = new List<Weapon>() { ruggedAxe};//empty
                List<Book> drawBridgeEntranceBookLoot = new List<Book>() { tatteredJournal};//empty
                List<OtherItem> drawBridgeEntranceOtherLoot = new List<OtherItem>() { HolyWaterAmulet};//empty
                Room drawBridgeEntrance = new Room("Your Camp / Drawbridge Entrance", "" +
                    "\nYour campfire is here, a welcome respite from the freezing cold. " +
                    "\nThe castle looms in the distance. " +
                    "\nThe drawbridge is closed and you can see the large, wooden lever that would open it. " +
                    "\nNearby lies an old corpse with a tattered leather satchel" +
                    "\n*Home Sweet Tiny-Campfire-In-The-Shadow-Of-A-Spooky-Castle*", drawBridgeEntranceWeaponLoot, drawBridgeEntranceBookLoot, drawBridgeEntranceOtherLoot, false, false, false);

                List<Weapon> mainHallWeaponLoot = new List<Weapon>() { };//empty
                List<Book> mainHallBookLoot = new List<Book>() { };//empty
                List<OtherItem> mainHallOtherLoot = new List<OtherItem>() { };//empty
                Room mainHall = new Room("Main Hall", "" +
                    "\nThe once lavish furnishings of this grand entry hall are now decaying and covered in dust and (a frankly impressive amount of) cobwebs " +
                    "\nThis room serves to connect residents to many other rooms. " +
                    "\nIt seems some time ago the massive central chandelier broke free and crashed to the floor." +
                    "\n*You should have seen this place in its heyday*", mainHallWeaponLoot, mainHallBookLoot, mainHallOtherLoot, false, false, false); //Some type of easter egg puzzle for the main hall? Or maybe a dev mode weapon

                List<Weapon> diningRoomWeaponLoot = new List<Weapon>() { };//empty
                List<Book> diningRoomBookLoot = new List<Book>() { };//empty
                List<OtherItem> diningRoomOtherLoot = new List<OtherItem>() { };//empty
                Room diningRoom = new Room("Dining Room", "" +
                    "\nThis large dining room has an arched ceiling adorned by a faded and chipping mural depicting happy little farmers harvesting all manner of crops." +
                    "\nThere are multiple standing cabinets lining the walls that at one time probably held sets of expensive dishware but most are currently broken or topped over. A few cabinets still have intact glass and a dusty wine collection is displayed within the largest cabinet." +
                    "\nThe center of the room is inhabited by a massive table that appears to be hewn from a single tree that must have been massive in its pre-dining-room-table days. The table itself is still set in a manner that suggests a dinner for two but the thick layering of dust and cobwebs reveals that the dishes haven't been touched in years." +
                    "\nOf the table's ten chairs, two are toppled over among the cabinet debris and one has been reduced to splinters near the meal setting for two" +
                    "\n*Seems like someone got up and left in the middle of meal... 10 years ago.*", diningRoomWeaponLoot, diningRoomBookLoot, diningRoomOtherLoot, false, true, false);

                List<Weapon> artGalleryWeaponLoot = new List<Weapon>() { };//empty
                List<Book> artGalleryBookLoot = new List<Book>() { };//empty
                List<OtherItem> artGalleryOtherLoot = new List<OtherItem>() { };//empty
                //Room artGallery = new Room("Art Gallery", "" +
                    //"/nThis room is long and narrow, with low ceilings",);


                #endregion

                List<Weapon> weaponInventory = new List<Weapon>(); //null initializing player's inventory
                List<Book> bookInventory = new List<Book>();
                List<OtherItem> otherInventory = new List<OtherItem>();
                #region Backstory Selection

                bool exitBackstorySelection = false;
                PlayerBackstory chosenBackstory = new PlayerBackstory();//Null initialization
                Weapon backgroundSword = ironSword;
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome to -{applicationTitle}-, player!  \n\nTo play this game, please you select with your number keys from a series of choices presented to you. \n\nIn this adventure you take on the role of a character who has sought out the rumored lair of an infamous vampire lord known as Marlon the Cruel. \nYour objective is to battle and defeat the nefarious undead. \nSurely this task will prove neither simple nor easy, but your motivations for undertaking it are your own. \nChoose one of the following backstories to determine your character's history and motivations. \n\nIn other words: Who are you?");
                    Console.WriteLine(@"
+++++++++++++++
|Fortune Seeker:
+++++++++++++++
You grew up a nobody and have always been treated as such. 
That’s about to change. Marlon's terrible reign has gone on far 
too long, and the hero that kills him will instantly become a legend.
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
The only thing stronger than your family’s sword at your side is your will.");
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
                            weaponInventory.Add(stolenSword);
                            backgroundSword = stolenSword;
                            exitBackstorySelection = true;
                            break;

                        case ConsoleKey.D2://righteous crusader
                        case ConsoleKey.NumPad2:
                            Console.Clear();
                            Console.WriteLine("You have chosen Righteous Crusader. Your will shines like a beacon in the dark.\n");
                            chosenBackstory = PlayerBackstory.RighteousCrusader;
                            weaponInventory.Add(familySword);
                            backgroundSword = familySword;
                            exitBackstorySelection = true;
                            break;

                        case ConsoleKey.D3://discredited scholar
                        case ConsoleKey.NumPad3:
                            Console.Clear();
                            Console.WriteLine("You have chosen Discredited Scholar. You'll show those stuck up fools you were right " +
                                "\neven if it's the last thing you do.\n");
                            chosenBackstory = PlayerBackstory.DiscreditedScholar;
                            weaponInventory.Add(decorativeSword);
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
Some would call rushing headlong into danger with weapons brandished brave. Others would call it foolish. 
You would say the fine details aren’t really all that important, and it’s got you this far. 
You know how to get the most out of any weapon you may use and you wear a patchwork set of armor for protection.
(+Weapon Damage, +Defense)

+++++++
|Thief:
+++++++
Thief, Rogue, Swashbuckler, call it what you will. It’s no matter of debate that you possess a particular set of skills. 
All that’s left is to put them to a good use in a place full of treasures, traps, and tricks. Luckily, you know just the place...
When you attack, you do so with unerring accuracy and if you must flee, your light armor helps you get away safely.
(+Weapon Accuracy, +Very high Dodge Chance when fleeing)

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
                Console.Write(@"A great philosopher once said,

""Words may hold meaning
but names hold power"" 

What is your name?: ");
                string chosenName = Console.ReadLine().Trim();
                #endregion
                PlayerCharacter hero = new PlayerCharacter(chosenName, 30, 30, 40, 5, chosenBackstory, chosenClass, backgroundSword, weaponInventory, bookInventory, otherInventory);
                //TODO Horse's Name? + pet at camp?)

                //Intro Text:
                Console.Clear();//Some ascii art here?
                Console.WriteLine(@"
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
----------------------------------------------------------------------------------------
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Your journey to reach the dreaded castle takes just over 2 weeks from the nearest 
town. Even after scaling the mountain that the castle is built upon, an unpassably
wide river with a strong current forces you to change course several times. 
The weather shifts from biting cold to downright dreadful during your last days of travel
and when you finally glimpse the keep's silhouette it's through a curtain of snowfall.
Luckily you packed warm and plenty of extra rations.

Your journey was the most arduous one of your life but you finally make 
your camp at the castle's gate.
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
----------------------------------------------------------------------------------------
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

");
                drawBridgeEntrance.IsCurrentRoom = true;
                while (!exitApplication)
                {


                    #region Camp/DrawbridgeEntrance
                    while (drawBridgeEntrance.IsCurrentRoom && !exitApplication)
                    {

                        Console.WriteLine(drawBridgeEntrance);
                        if (!drawBridgeEntrance.IsPuzzleComplete)
                        {
                            Console.WriteLine(@"
 [1] View your Inventory
 [2] Rest at campfire (restore all health)
 [3] Look At Castle
 [4] Search Corpse
 [5] Pull Drawbridge Lever");
                        }
                        else
                        {
                            Console.WriteLine(@"
 [1] View your Inventory
 [2] Rest at campfire (restore all health)
 [3] Look At Castle
 [4] Search Corpse
 [5] Cross Drawbridge");
                        }
                        ConsoleKey roomMenuChoice = Console.ReadKey(true).Key;

                        switch (roomMenuChoice)
                        {
                            case ConsoleKey.D1://view player inv
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Formatting.ViewHeroInventory(hero);
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Formatting.FullHeal(hero);
                                Console.WriteLine("You take time to drive the chill from your bones and heal your wounds." +
                                    "\nYou are healed and ready to face your challenges.");
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                Formatting.DisplayCastleArt();//Randomize response here?
                                Console.WriteLine("You look at the castle and feel apprehensive of what's to come.");
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                Formatting.ViewRoomInventory(hero, drawBridgeEntrance);
                                break;

                            case ConsoleKey.D5:
                            case ConsoleKey.NumPad5:
                                if (!drawBridgeEntrance.IsPuzzleComplete)
                                {

                                    Console.Clear();
                                    Console.WriteLine("Pulling the old wooden lever sets into motion the grinding of ancient sounding gears in the castle. " +
                                        "\nThe drawbridge slowly lowers across the moat" +
                                        "\nThe wood of the bridge is old and rotted and the chains that hold it up are rusted" +
                                        "\nThe drawbridge is able to be crossed");
                                    drawBridgeEntrance.Description = "Your campfire is here, a welcome respite from the freezing cold. " +
                                        "\nThe castle looms in the distance. " +
                                        "\nYou have pulled the lever and the drawbridge over the raging river is ready to be crossed. " +
                                        "\nNearby lies an old corpse with a tattered leather satchel." +
                                        "\n*Home Sweet Tiny-Campfire-In-The-Shadow-Of-A-Spooky-Castle*";
                                    drawBridgeEntrance.IsPuzzleComplete = true;
                                }//end if
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You make your way across the rickety bridge and approach the castle.");
                                    if (!drawBridgeEntrance.IsMonsterDead)
                                    {

                                        Console.WriteLine("It seems the commotion has awoken a swarm of hungry bats!");

                                        #region Combat Functionality

                                        Monster enemy = batSwarm; //Individualized enemy here
                                        Console.WriteLine($"A {enemy.Name} is attacking you! Get ready to fight!"); //Customize per encounter
                                        Console.WriteLine("Press any button to begin the fight!");//Pics maybe?
                                        Console.ReadKey(true);

                                        bool exitFight = false;
                                        do
                                        {
                                            Console.WriteLine(@"A Swarm of Bats is attacking you!
 ____.                            .____               
  ..'     ''\                      /''     '..
.'     .. . .'\.                ./. .  ..     '.
 ')__.'  ...    '.)          (.'    ...  '.__('
  '  )_.'     .   :          :   .     '._(  '
       )_.__.'    '.        .'    '.__._(
            )__.'   '.    .'   '.__(        
            '   \._..:^::^:.._./   '
                 '   :o..o:   '
                    .:'!!':.
                    ''    ''
");
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
                                                        Formatting.RedText("As you flee, the {enemy} attempts to attack!");
                                                        Combat.Attack(enemy, hero);
                                                    }
                                                    exitFight = true;
                                                    break;

                                                case ConsoleKey.D3://View Player Stats
                                                case ConsoleKey.NumPad3:
                                                    Console.WriteLine(hero);
                                                    break;

                                                case ConsoleKey.D4://View Monster Stats
                                                case ConsoleKey.NumPad4:
                                                    Console.WriteLine(enemy);
                                                    break;

                                                case ConsoleKey.D5://View Inventory
                                                case ConsoleKey.NumPad5:
                                                    Formatting.ViewHeroInventory(hero);
                                                    break;

                                                default:
                                                    Console.Clear();
                                                    Console.WriteLine($"{userChoice} is an invalid option, please try again.");
                                                    break;
                                            }//end menu switch
                                            if (hero.Life <= 0)
                                            {
                                                Formatting.RedText($"You have been slain by the {enemy.Name}.");
                                                exitApplication = true;
                                            }


                                        } while (!exitFight && !exitApplication);

                                        #endregion

                                        drawBridgeEntrance.IsMonsterDead = true;
                                    }//end bat fight
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You cross the drawbridge and enter the looming castle");
                                    }
                                    if (batSwarm.Life <= 0)
                                    {
                                        drawBridgeEntrance.IsCurrentRoom = false;
                                        mainHall.IsCurrentRoom = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You flee and return to your camp");
                                    }
                                }//end else
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine($"{roomMenuChoice} was not a valid option. Select again");
                                break;
                        }//end switch

                    }//end drawbridge isCurrentRoom
                    #endregion

                    #region MainHall

                    while (mainHall.IsCurrentRoom && !exitApplication)
                    {
                        #region Vamp Confrontation

                        if (!mainHall.IsMonsterDead)
                        {
                            if (hero.OtherInventory.Contains(HolyWaterAmulet))
                            {
                                Console.WriteLine(@"
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
----------------------------------------------------------------------------------------
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
You press open the heavy castle doors and enter the main hall.
You take a few steps inside, marvelling at what was once very lavish decor.
Your marvelling is cut short by the hair on the back of your neck standing up as you
sense that you are being watched by some dark creature.

You whirl around just in time to see a tall, well-dressed, and deathly pale man step 
out from the shadows, fangs bared. He's only an arm's length away!

As you turn, the Amulet of Holy Water begins to glow brightly and you can see the creature
recoil.
This show of weakness is your moment to strike!
You slash at him with your blade only to feel the tingling reverberation of metal hitting stone.
Your blade glances off his skin with sparks and not so much as a scratch!

You both pause for a moment as you find yourselves at a stalemate: he is unable to bite you
while you wear the amulet and you cannot harm him with your weapon.

A wry smile crosses the vampire's alabaster face and his dark amber eyes 
shine from their tired-looking sockets.
""Well that's inconvenient, I was quite looking forward to some fresh blood.
It's honestly not worth the effort to kill you if I don't get a nice meal out
of it,"" he casually remarks while he examines the tear in his 
garments from your weapon strike. He clearly isn't taking you seriously.

Insulted, you strike out again only to have him step of range of the strike with a supernatural
quickness. In the blink of an eye he's across the room at the foot of a staircase. 
He smoothly tucks his shoulder-length, inky-black hair behind his ear.
""I really cannot be bothered with this today of all days,
so make yourself at home, I suppose.
I'm sure the castle will deal with you swiftly,"" he says.

With that, he turns to ascend the spiraling staircase.
You run after him but by the time to reach the stairs, you hear a heavy door closing
and locking at the top of the stairs.
");

                                //TODO Diologue Option here?
                                mainHall.IsMonsterDead = true;
                            }//end inventorycontainsamulet if branch
                            else
                            {
                                Console.WriteLine(@"
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
----------------------------------------------------------------------------------------
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
You slowly open the massive, wooden doors to the main hall and take a few 
steps inside while marvelling at what was once very lavish decor.
");
                                Formatting.RedText("Suddenly the hair on your neck stands up as you sense you are being watched by some dark creature. Before you can react, you feel a stabbing pain on the side of your neck and unnaturally strong arms restrain you." +
                                    "\nAfter a moment of struggling to free yourself, your strength has seeped from your body and your eyes begin to close." +
                                    "\nYour body crumples to the floor and that last of your life fades as you glimpse a well-dressed figure wiping the blood from their lips with an embroidered kerchief." +
                                    "\n\nYou have died." +
                                    "\n*While waltzing in the front door unprepared is brave, it seems it was also quite foolish.*");//Kicked the bucket
                                exitApplication = true;
                            }

                        }//end first vamp confrontation

                        #endregion
                        if (mainHall.IsMonsterDead) //Start regular Main Hall area
                        {
                            Console.WriteLine(mainHall);
                            Console.WriteLine(@"
[1] View your inventory
[2] Go to the Dining Room 
[3] Go to the Art Gallery
[4] Go to the Old Library
[5] Go to the Crypt
[6] Go to the Tower 
[7] Cross the drawbridge to your Camp");
                            ConsoleKey roomMenuChoice = Console.ReadKey(true).Key;

                            switch (roomMenuChoice)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Formatting.ViewHeroInventory(hero);
                                    break;

                                case ConsoleKey.D2://to dining room
                                case ConsoleKey.NumPad2:
                                    Console.Clear();

                                    diningRoom.IsCurrentRoom = true;
                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.D3://to art gallery
                                case ConsoleKey.NumPad3:
                                    Console.Clear();

                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.D4://to old library
                                case ConsoleKey.NumPad4:
                                    Console.Clear();

                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.D5://to crypt
                                case ConsoleKey.NumPad5:
                                    Console.Clear();

                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.D6://to tower
                                case ConsoleKey.NumPad6:
                                    Console.Clear();

                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.D7://to camp
                                case ConsoleKey.NumPad7:
                                    Console.Clear();
                                    Console.WriteLine("You return to your camp");
                                    drawBridgeEntrance.IsCurrentRoom = true;
                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.Spacebar:
                                    Console.Clear();
                                    Console.WriteLine("You pick up (and equip) the legendary DEVELOPER'S BLADE. This will make things easier");
                                    hero.WeaponInventory.Add(developerBlade);
                                    hero.EquippedWeapon = developerBlade;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine($"{roomMenuChoice} was not a valid option. Select again");
                                    break;
                            }//end roomMenu switch

                        }//end no vamp confrontation
                    }//end mainhall.IsCurrentRoom

                    #endregion
                    #region Dining Room
                    while (diningRoom.IsCurrentRoom)
                    {
                        Console.WriteLine("WIP");
                    }
                    #endregion
                }//end MAIN GAME loop
                
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
