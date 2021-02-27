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
                Formatting.DisplayTitleCard(); //Titlecard art stored in Formatting Class and called with this method

                Formatting.MainTheme();
                Console.ReadKey(true);

                #endregion

                #region Items
                //Creating the items here to distribute them to room inventories later
                #region Weapons
                //Starter Weapons, identical stats, different flavors.
                Weapon stolenSword = new Weapon("Stolen Sword", "It's better if no one asks where you got this...", WeaponType.IronSword, 10, 1, 6, false);
                Weapon familySword = new Weapon("Family Sword", "It's old and well used. It has served your family for 3 generations now.", WeaponType.IronSword, 10, 1, 6, false);
                Weapon decorativeSword = new Weapon("Decorative Sword", "Intended to be buried with a warrior, not used in combat. But the blade is sharp and the tip still stabs.", WeaponType.IronSword, 10, 1, 6, false);
                Weapon ironSword = new Weapon("Iron Sword", "Placeholder starter sword", WeaponType.IronSword, 10, 1, 6, false);

                Weapon ruggedAxe = new Weapon("Rugged Axe", "It's seen heavy use, but this axe's sturdy construction has held thus far.", WeaponType.RuggedAxe, 5, 2, 7, false);
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
                Book tatteredJournal = new Book("Tattered Journal", "It appears this small, leather-bound book was well used prior to a long exposure to the elements. Most of it is unreadable but the last passage is legible.", @"
...and I think it was poisonous, it's the only explanation... 
+++++++++++++++++++++++++++++++++++++++++++++++++++
(the text here is stained with blood and illegible)
+++++++++++++++++++++++++++++++++++++++++++++++++++
...thought this stupid amulet would be good luck but this ""luck"" feels a lot like dying.
I guess technically I never got bitten by a vamp, but I also never saw a vamp, just wandered around
trying to find a way into that blasted crypt. I always did hate puzzl....

(the writing trails off down the page as if the writer's hand fell. There are no further entries)
");
                
                Book crumpledParchment = new Book("Crumpled Parchment", "This parchment seems to have been torn from some larger piece and only has part of an excerpt written on it. " +
                    "\nThe writing is penned in a refined handwriting style.", @"
...like it was yesterday she was standing above me, silver sword gleaming. It feels like but a moment ago she gazed upon me 
with pity instead of hatred. She saw me as I am, stripped of mythos, free of legend, devoid of ominious inferences. 
I try as I might to honor (""her memory"" is crossed out here) our memories, but it's not the honoring that is difficult. 
It's the eternity within which I must repeat the same meanial tasks day after day. An eternity of mediocrity, of hunger, of regret and grief that...
(This excerpt is all that is visible on the ripped parchment.
The note is penned in a refined handwriting style)");

                Book paintingInscription = new Book("Inscription on Shredded Painting", "The writing here was written on the back of a canvas in the art gallery. " +
                    "\nThough the painting this came from is not identifiable, it seems the painted side of the canvas is depicting a fine, " +
                    "\nred dress. It is penned in a scratchy handwriting style.", "" +
                    "\nTo my dearest friend and eternal companion on the night of our 35th wedding anniversary." +
                    "\nI've been practicing during the day and I'm pleased to present to you this self-portrait I've just" +
                    "\nbarely finished in time for our special night!" +
                    "\nAs my days number ever higher, I find comfort knowing that each shall be spent with you" +
                    "\nfrom moonrise to sunrise. Here's to 35 more!" +
                    "\nWith Love," +
                    "\n--Your Eleanor" +
                    "\n(It is dated with a date exactly 49 years ago from today's date, to the exact day." +
                    "\nThe inscription is penned in a scratchy handwriting style.)");

                Book oldPoem = new Book("Old Poem", "This poem is written on an old and brittle piece of parchment. It was penned in a refined handwriting style", @"
A Dead walked in the night
Braving a wild land with each step
Till wide river, riled and raging
Brought his wandering to a halt

A Dead stood in the night
While time brought Winter’s wrath
Winter’s wile, Winter’s unyielding force
‘Till river slept in cold repose

Now cross’t the river of Praydys Mere:
The Dead forged thoughts of living here

A Dead waited in the night
For seeds to thrive in dark soil
There, spring warmed the trees’ cold hearts
Deepening roots, ripening fruits, bearing songs of springtime

A Dead toiled in the night
Wide trunks fell into lumber
Mighty boughs found purpose
And from them grew a home

Thus, cross’t the river of Praydys Mere
The Dead sought strong solitude here

A Dead climbed in the night
Upon cliffs sheer and ledges sharp
With feet upon peak and spire he saw
A canyon wide at the mountain’s heart


A Dead toiled in the night
From walls of wood he shaped cliffs of stone
Battlements rose against the sky, defiant
His mighty fortress now rests at journey’s end

Many seasons have come and passed
Since he cross’t the river of Praydys Mere

The Dead now reigns eternal here

(The poem is unsigned and untitled. It's worth noting that the 
locals refer to the nearby mountain lake as Predyn's Mere.
It feels too close to be a coincidence. Perhaps the name changed over time?
The poem is penned in a refined handwriting style)
");

                Book burnedNote = new Book("Half-Burned Note", "It seems someone tried to burn this note in a fireplace but a stray draft of wind saved this legible portion of text." +
                    "\nThis note is written in a scratchy handwriting style", @"
...understand now what you meant. I'm sorry for how I acted and I'd like to ask your forgiveness. 
You said you couldn't (or wouldn't) condemn me to an enternity of torment. 
And I listened.

You remarked: ""Something isn't beautiful only because it lasts, it's in fact quite the opposite.""
And I thought deeply about it.

You declared that I wanted what everyone wants: ""To be loved unconditionally and all-consumingly.""
And I knew in my heart you spoke the truth. 
And I knew you already had that love for me.
I knew you spoke from kindness and love, not from the fear I drew on.

Thank you.

So please, Amadeus, you don't have to worry about my temptations anymore. Let's just live and love 
each other. Not forever, but for long enough.

Let's simply enjoy the time we have.

-E...

(The note is penned in a scratch handwriting style)
");
                #endregion

                #region Other Items
                OtherItem HolyWaterAmulet = new OtherItem("Holy Water Amulet", "Folklore says having this on your person helps ward off undead. Can't hurt to have it, right?", false);
                OtherItem darkRedWine = new OtherItem("Dark Red Wine", @"The wine in this bottle seems thicker and darker than even the most ""robust"" wines you've seen. It looks almost like it's filled with... blood.", false);
                OtherItem weddingRing = new OtherItem("Golden Wedding Ring", "The inscription inside the band reads: Together in Love, As Long As A Life", false);
                OtherItem lantern = new OtherItem("Wrought Iron Lantern", "The iron housing of this latern is made of tiny heart patterns. The flame inside burns continuously even without fuel.", false);
                
                #endregion

                #endregion

                #region Monsters

                Monster batSwarm = new Monster("Swarm of Bats", 10, 10, 30, 5, "This swarm of hungry bats works together with a " +
                    "\ncohesion that seems nearly sentient", 1, 4);
                Monster armorSuit = new Monster("Animated Armor", 14, 14, 35, 20, "It doesn't technically have an expression but you infer it looks angry.", 2, 6);
                Monster ancientSpider = new Monster("Giant Spider", 20, 20, 30, 10, @"A very dangerous answer to the very vexing question: ""What made all these webs?""", 4, 8);
                
                #endregion
                
                #region Rooms

                //RoomList needs to be created before the room
                List<Weapon> drawBridgeEntranceWeaponLoot = new List<Weapon>() { ruggedAxe};
                List<Book> drawBridgeEntranceBookLoot = new List<Book>() { tatteredJournal};
                List<OtherItem> drawBridgeEntranceOtherLoot = new List<OtherItem>() { HolyWaterAmulet};
                Room drawBridgeEntrance = new Room("Your Camp / Drawbridge Entrance", "" +
                    "\nYour campfire is here, a welcome respite from the freezing cold. " +
                    "\nThe castle looms in the distance. " +
                    "\nThe drawbridge is closed and you can see the large, wooden lever that would open it. " +
                    "\nNearby lies an old corpse with a tattered leather satchel" +
                    "\n*Home Sweet Tiny-Campfire-In-The-Shadow-Of-A-Spooky-Castle*", drawBridgeEntranceWeaponLoot, drawBridgeEntranceBookLoot, drawBridgeEntranceOtherLoot, false, false, false);

                List<Weapon> mainHallWeaponLoot = new List<Weapon>() { };
                List<Book> mainHallBookLoot = new List<Book>() { };
                List<OtherItem> mainHallOtherLoot = new List<OtherItem>() { };
                Room mainHall = new Room("Main Hall", "" +
                    "\nThe once lavish furnishings of this grand entry hall are now decaying and covered in dust and (frankly, an impressive amount of) cobwebs " +
                    "\nThis room serves to connect residents to many other rooms. " +
                    "\nIt seems some time ago the massive central chandelier broke free and crashed to the floor." +
                    "\n*You should have seen this place in its heyday*", mainHallWeaponLoot, mainHallBookLoot, mainHallOtherLoot, false, false, false); //DEV MODE WEAPON HERE but NOT in loot list

                List<Weapon> diningRoomWeaponLoot = new List<Weapon>() {ornateDagger };
                List<Book> diningRoomBookLoot = new List<Book>() {crumpledParchment };
                List<OtherItem> diningRoomOtherLoot = new List<OtherItem>() {darkRedWine };
                Room diningRoom = new Room("Dining Room", "" +
                    "\nThis large dining room has an arched ceiling adorned by a faded and chipping mural depicting happy little farmers harvesting all manner of crops." +
                    "\nThere are multiple standing cabinets lining the walls that at one time probably held sets of expensive dishware but most" +
                    "\nare currently broken or topped over. A few cabinets still have intact glass and a dusty wine collection is displayed within the largest cabinet." +
                    "\nThe center of the room is inhabited by a massive table that appears to be hewn from a single tree that must have " +
                    "\nbeen massive in its pre-dining-room-table days. The table itself is still set in a manner that suggests a dinner for two but the thick " +
                    "\nlayering of dust and cobwebs reveals that the dishes haven't been touched in years." +
                    "\nOf the table's ten chairs, two are toppled over among the cabinet debris and one has been reduced to splinters near the meal setting for two" +
                    "\nA cabinet here has a crumpled and torn piece of parchment stabbed into it with a decorative dagger" + 
                    "\n*Seems like someone got up and left in the middle of meal... 10 years ago.*", diningRoomWeaponLoot, diningRoomBookLoot, diningRoomOtherLoot, false, true, false);

                List<Weapon> artGalleryWeaponLoot = new List<Weapon>() {fineSteelSword };
                List<Book> artGalleryBookLoot = new List<Book>() {paintingInscription };
                List<OtherItem> artGalleryOtherLoot = new List<OtherItem>() {weddingRing };
                Room artGallery = new Room("Art Gallery", "" +
                "\nThis room is long and narrow, with low ceilings. The walls are filled with alcoves and nearly" +
                "\nhalf of the alcoves have paintings or sculptures displayed within. " +
                "\nThe floor is littered with the tattered remains of several painted canvases and frames as well as the" +
                "\nshards of marble from a toppled over statue." +
                "\n*Everyone's a critic, eh?*" +
                "\nIn the center of room stands an ornate suit of armor sporting the emblem of a holy order from your homeland." +
                "\n(Quite the odd thing for a vampire to have sitting around, perhaps it's a trophy of some defeated foe?)" +
                "\nThe suit of armor has a sheathed sword at its hip and is holding a cushion upon which is set a " +
                "\nthin, golden wedding band.",artGalleryWeaponLoot, artGalleryBookLoot, artGalleryOtherLoot, false, false, false);

                List<Weapon> libraryWeaponLoot = new List<Weapon>() {fineSteelSword };
                List<Book> libraryBookLoot = new List<Book>() {burnedNote, oldPoem };
                List<OtherItem> libraryOtherLoot = new List<OtherItem>() { lantern};
                Room oldLibrary = new Room("Old Library", @"
This room is covered nearly floor to ceiling in thick, dry webbing.
You can see through the webbing at some spots to glimpse the numerous
fully stocked bookshelves underneath. You estimate there must be
well over 1000 books here.
You can see a flickering light emanating from the top of one of the
tallest shelves but the source of the light is hidden from view.
Several dessicated corpses adorn the wall near you, wrapped in webbing.
*Well that's one way to keep warm. Still, I think I'll pass.*", libraryWeaponLoot, libraryBookLoot, libraryOtherLoot, false, false, false);
                
                List<Weapon> cryptWeaponLoot = new List<Weapon>() { };
                List<Book> cryptBookLoot = new List<Book>() { };
                List<OtherItem> cryptOtherLoot = new List<OtherItem>() { };
                Room crypt = new Room("The Crypt", @"
You find yourself in the dimly lit undergound of the castle.
This room is wide and has several columns presumably supporting the castle above.
A single set of smooth stone doors is here. The doors have no handle, lever, knob 
or other clear way of opening them.
Beside the stone doors is an etching in the wall, surrounded by a decorative floral
design.
Adjacent to the eching are 3 oval-shaped alcoves that seem large enough to set
something in.
", cryptWeaponLoot, cryptBookLoot, cryptOtherLoot, false, false, false);

                #endregion
                
                #region Backstory Selection

                //null initializing player's inventory
                List<Weapon> weaponInventory = new List<Weapon>();
                List<Book> bookInventory = new List<Book>();
                List<OtherItem> otherInventory = new List<OtherItem>();

                bool exitBackstorySelection = false;
                PlayerBackstory chosenBackstory = new PlayerBackstory();//Null initialization to be reassigned later
                Weapon backgroundSword = ironSword;
                do
                {
                    Console.Clear();
                    Console.WriteLine(
                        $"Welcome to -{applicationTitle}-, player!  " +
                        "\n\nTo play this game, you select with your number keys ([1], [2], [3], etc.) from a series of choices presented to you. " +
                        "\n\nIn this adventure you take on the role of a character who has sought out the rumored lair of an infamous vampire lord known as ");
                    Formatting.RedText(@"
+++++++++++++++++++
Amadeus The Cruel
+++++++++++++++++++
");
                    Console.WriteLine(
                        "Your objective is to battle and defeat the nefarious undead. " +
                        "\nSurely this task will prove neither simple nor easy, but your motivations for undertaking it are your own." +
                        "\n\nPress any Key to Continue...");
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.WriteLine("\nChoose one of the following backstories to determine your character's history and motivations. " +
                        "\n\nIn other words: Who are you?");
                    Console.WriteLine(@"
+++++++++++++++
|Fortune Seeker:
+++++++++++++++
You grew up a nobody and have always been treated as such. 
That’s about to change. The reign of Amadeus has lasted far 
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
                PlayerClass chosenClass = new PlayerClass();//null initialization to be reassigned later
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
                Console.Write(@"
A great philosopher once said,

+++++++++++++++++++++++++++
""Words may hold meaning
but names hold power"" 
+++++++++++++++++++++++++++

What is your name?: ");
                string chosenName = Console.ReadLine().Trim();
                #endregion

                #region Introduction

                PlayerCharacter hero = new PlayerCharacter(chosenName, 30, 30, 40, 5, chosenBackstory, chosenClass, backgroundSword, weaponInventory, bookInventory, otherInventory);
                
                //Intro Text:
                Console.Clear();//Maybe some ascii art here of a mountain or river?
                Console.WriteLine(@"
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
Your journey to reach the dreaded castle takes just over 2 weeks from the nearest 
town. 
Even after scaling the mountain that the castle is built upon, an unpassably
wide river with a strong current forces you to change course several times. 

The weather shifts from biting cold to dangerously freezing during your last days of travel
and when you finally glimpse the structure's silhouette it's through a sheer curtain of snowfall.
Luckily you packed warm and plenty of extra rations.

This journey was the most arduous one of your life but you finally strike flint on steel
to begin making your camp at the castle's gate.
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

");
                drawBridgeEntrance.IsCurrentRoom = true; //enter into MAIN Game loop with a current room designation

                #endregion

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
                                Formatting.DisplayCastleArt(); //Perhaps a randomized response here?
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
                                        Console.WriteLine("Press any button to begin the fight!");
                                        Console.ReadKey(true);

                                        bool exitFight = false;
                                        do
                                        {
                                            Formatting.DisplayBatSwarm();
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
                                                        Formatting.RedText($"As you flee, the {enemy.Name} attempts to attack!");
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
                                        
                                    }//end bat fight
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You cross the drawbridge and enter the looming castle");
                                    }//end if/else is monsterdead
                                    if (batSwarm.Life <= 0)
                                    {
                                        drawBridgeEntrance.IsMonsterDead = true;
                                        drawBridgeEntrance.IsCurrentRoom = false;
                                        mainHall.IsCurrentRoom = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You flee and return to your camp");
                                    }//end if/else of winning vs fleeing
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
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
You run after him but by the time to reach the stairs, you hear the flapping of small, leathery
wings and can see the form of a bat shrinking in the distance.

Perhaps exploring his castle will help you find a way to defeat the cowardly undead.
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

Press Any Key to Continue...
");
                                Console.ReadKey(true);
                                Console.Clear();
                                HolyWaterAmulet.HasBeenUsed = true;
                                HolyWaterAmulet.Description = "Wearing this seems to stop the vampire from biting you. But he seems plenty able of killing you many other ways."; //item description updated
                                mainHall.IsMonsterDead = true;
                            }//end inventorycontainsamulet if branch
                            else
                            {
                                Console.WriteLine(@"
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
You slowly open the massive, wooden doors to the main hall and take a few 
steps inside while marvelling at what was once very lavish decor.
");
                                Formatting.RedText("Suddenly the hair on your neck stands up as you sense you are being watched by some dark creature. Before you can react, you feel a stabbing pain on the side of your neck and unnaturally strong arms restrain you." +
                                    "\nAfter a moment of struggling to free yourself, your strength has seeped from your body and your eyes begin to close." +
                                    "\nYour body crumples to the floor and that last of your life fades as you glimpse a well-dressed figure wiping the blood from their lips with an embroidered kerchief." +
                                    "\n\nYou have died." +
                                    "\n*While waltzing in the front door unprepared is brave, it seems it was also quite foolish.*");//Kicked the bucket, RIP
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
[6] Cross the Drawbridge to your Camp");
                            ConsoleKey roomMenuChoice = Console.ReadKey(true).Key;

                            switch (roomMenuChoice)
                            {
                                case ConsoleKey.D1://view inventory
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Formatting.ViewHeroInventory(hero);
                                    break;

                                case ConsoleKey.D2://to dining room
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    Console.WriteLine("You walk down a long hallway and under a wide, wooden archway to reach the dining room");
                                    diningRoom.IsCurrentRoom = true;
                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.D3://to art gallery
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    artGallery.IsCurrentRoom = true;
                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.D4://to old library
                                case ConsoleKey.NumPad4:
                                    Console.Clear();
                                    Console.WriteLine("The cobwebs get ever more copious as you approach the library.");
                                    oldLibrary.IsCurrentRoom = true;
                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.D5://to crypt
                                case ConsoleKey.NumPad5:
                                    Console.Clear();
                                    Console.WriteLine("You open a set of heavy wooden doors and descend" +
                                        "\na stone staircase to reach the crypt");
                                    crypt.IsCurrentRoom = true;
                                    mainHall.IsCurrentRoom = false;
                                    break;
                                
                                case ConsoleKey.D6://to camp
                                case ConsoleKey.NumPad6:
                                    Console.Clear();
                                    Console.WriteLine("You return to your camp");
                                    drawBridgeEntrance.IsCurrentRoom = true;
                                    mainHall.IsCurrentRoom = false;
                                    break;

                                case ConsoleKey.Spacebar://dev blade easter egg
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
                        Console.WriteLine(diningRoom);
                        if (!diningRoom.IsPuzzleComplete)
                        {
                            Console.WriteLine(@"
[1] View your inventory
[2] Examine the dagger and parchment
[3] Examine the wine collection
[4] Return to the Main Hall
");
                        }
                        else
                        {
                            Console.WriteLine(@"
[1] View your inventory
(You've taken the dagger and parchment)
[3] Examine the wine collection
[4] Return to the Main Hall
");
                        }
                        ConsoleKey roomMenuChoice = Console.ReadKey(true).Key;
                        switch (roomMenuChoice)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Formatting.ViewHeroInventory(hero);
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Console.WriteLine("You carefully remove the dagger and parchment from the side of the cabinet and examine them.\n");
                                Formatting.ViewRoomWeaponInventory(diningRoom.RoomWeaponLoot, hero.WeaponInventory);
                                Formatting.ViewRoomBookInventory(diningRoom.RoomBookLoot, hero.BookInventory);
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                bool bottleLooted = false;
                                Console.WriteLine("The collection of bottles within the cabinet clink together lightly as you open the glass cabinet doors.");
                                if (!bottleLooted)
                                {

                                    Console.WriteLine(
                                        "\nAside from the extreme age of every bottle here, none are noteworthy aside from one that seems to have fallen down" +
                                        "\nfrom its shelf. When you pick it up, you can tell the viscosity of the liquid within is clearly not that of wine, but " +
                                        "\nof blood." +
                                        "\nDark Red Wine has been added to your inventory.");
                                    hero.OtherInventory.Add(darkRedWine);
                                    diningRoom.RoomOtherLoot.Remove(darkRedWine);
                                    bottleLooted = true;
                                }
                                else
                                {
                                    Console.WriteLine("This is where you picked up the dark red wine bottle.");
                                }
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                Console.WriteLine("You return to the Main Hall");
                                diningRoom.IsCurrentRoom = false;
                                mainHall.IsCurrentRoom = true;
                                break;
                                
                            default:
                                Console.Clear();
                                Console.WriteLine($"{roomMenuChoice} was not a valid option. Select again");
                                break;
                        }//end room choice switch
                        if (hero.BookInventory.Contains(crumpledParchment) && hero.WeaponInventory.Contains(ornateDagger))
                        {
                            diningRoom.IsPuzzleComplete = true;
                            diningRoom.Description = "" +
                    "\nThis large dining room has an arched ceiling adorned by a faded and chipping mural depicting happy little farmers harvesting all manner of crops." +
                    "\nThere are multiple standing cabinets lining the walls that at one time probably held sets of expensive dishware but most" +
                    "\nare currently broken or topped over. A few cabinets still have intact glass and a dusty wine collection is displayed within the largest cabinet." +
                    "\nThe center of the room is inhabited by a massive table that appears to be hewn from a single tree that must have " +
                    "\nbeen massive in its pre-dining-room-table days. The table itself is still set in a manner that suggests a dinner for two but the thick " +
                    "\nlayering of dust and cobwebs reveals that the dishes haven't been touched in years." +
                    "\nOf the table's ten chairs, two are toppled over among the cabinet debris and one has been reduced to splinters near the meal setting for two" +
                    "\n*Seems like someone got up and left in the middle of meal... 10 years ago.*";
                        }
                    }//end diningRoom.iscurrentroom
                    #endregion

                    #region Art Gallery
                    while (artGallery.IsCurrentRoom && !exitApplication)
                    {
                        Console.WriteLine(artGallery);
                        if (!artGallery.IsMonsterDead)
                        {
                            Console.WriteLine("\n" +
                                "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                                "\nAs you take your first steps into the room, the suit of armor draws its sword and attacks!" +
                                "\n*I guess offense really is the best defense*" +
                                "\n\nPress Any Key to begin the fight!" +
                                "\n");
                            Console.ReadKey(true);

                            #region Combat Functionality

                            Monster enemy = armorSuit;

                            bool exitFight = false;
                            do
                            {
                                Formatting.DisplayArmorSuit();
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
                                            artGallery.IsMonsterDead = true;
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
                                            Formatting.RedText($"As you flee, the {enemy.Name} attempts to attack!");
                                            Combat.Attack(enemy, hero);
                                        }
                                        exitFight = true;
                                        artGallery.IsCurrentRoom = false;
                                        mainHall.IsCurrentRoom = true;
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
                                    Console.WriteLine($"You have been slain by the {enemy.Name}.");
                                    exitApplication = true;
                                }

                                if (artGallery.IsMonsterDead)
                                {
                                    artGallery.Description = "" +
                "\nThis room is long and narrow, with low ceilings. The walls are filled with alcoves and nearly" +
                "\nhalf of the alcoves have paintings or sculptures displayed within. " +
                "\nThe floor is littered with the tattered remains of several painted canvases and frames as well as the" +
                "\nshards of marble from a toppled over statue." +
                "\n*Everyone's a critic, eh?*" +
                "\nWhere an ill-tempered suit of armor once stood, there is now only an empty pedastal and scrap metal.";
                                }

                            } while (!exitFight && !exitApplication);

                            #endregion

                        }//end armor suit combat
                        while (artGallery.IsCurrentRoom && !exitApplication)
                        {

                            if (!artGallery.IsPuzzleComplete)
                            {
                                Console.WriteLine(artGallery);
                                Console.WriteLine(@"
[1] View Your Inventory
[2] Search the room 
[3] Examine the Art
[4] Return to Main Hall
");
                            }//end puzzle not complete if
                            else
                            {
                                Console.WriteLine(@"
[1] View Your Inventory
(You've taken the ring and painting scrap)
[3] Examine the Art
[4] Return to Main Hall
");
                            }//end puzzle complete else

                            ConsoleKey roomMenuChoice = Console.ReadKey(true).Key;

                            switch (roomMenuChoice)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Formatting.ViewHeroInventory(hero);
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    Formatting.ViewRoomBookInventory(artGallery.RoomBookLoot, hero.BookInventory);
                                    Formatting.ViewRoomOtherItemInventory(artGallery.RoomOtherLoot, hero.OtherInventory);
                                    if (hero.BookInventory.Contains(paintingInscription) && hero.OtherInventory.Contains(weddingRing))
                                    {
                                        diningRoom.IsPuzzleComplete = true;
                                    }
                                    break;

                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    Console.WriteLine(@"
You take a few moments to apprecaite the art collected here. The more you look, the more it becomes
clear that each piece is by the same artist. A collection of this many pieces must have taken decades
to accrue. One theme unites all the art pieces: the expert contrast of light and dark.
The piece occupying the central alcove is a life-sized portrait of the vampire you just met
in the Main Hall. In the painting he regards the viewer with a kindly smile.
The plaque hanging beneath it bears only one word:

""Amadeus""
");
                                    if (!hero.WeaponInventory.Contains(antiqueSpear))
                                    {
                                        Console.WriteLine("\nIn an alcove displaying several decorative weapons, your eye catches on" +
                                            "\nan aged brass spear of fine craftsmanship that sports a jagged head. You figure " +
                                            "\nthat you might as well save it from an eternity of gathering dust" +
                                            "\nAntique Spear has been added to your inventory");
                                        hero.WeaponInventory.Add(antiqueSpear);
                                    }
                                    else
                                    {
                                        Console.WriteLine("This is where you aquired the Antique Spear");
                                    }
                                    Console.WriteLine("\nPress Any Key to Continue...");
                                    Console.ReadKey(true);
                                    break;

                                case ConsoleKey.D4:
                                case ConsoleKey.NumPad4:
                                    Console.Clear();
                                    Console.WriteLine("You return to the Main Hall");
                                    artGallery.IsCurrentRoom = false;
                                    mainHall.IsCurrentRoom = true;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine($"{roomMenuChoice} was not a valid option. Select again");
                                    break;
                            }//end switch



                        }//end regular (No monster) art gallery loop
                    }//end Art Gallery Room
                    #endregion

                    #region Old Library

                    while (oldLibrary.IsCurrentRoom && !exitApplication)
                    {
                        Console.WriteLine(oldLibrary);
                        if (!oldLibrary.IsMonsterDead)
                        {
                            Console.WriteLine(@"
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
As you make your first footfall in the room, you can visibly watch the intricate
network of webbing reverberate as your presence disturbs a single strand.
A clicking and chittering noise begins to emanate from above you and gets
louder as you see a spider larger than a horse descend on a strand of
webbing thicker than climbing rope.
It does not look happy to see you. In fact it looks rather hungry.");


                            #region Combat Functionality

                            Monster enemy = ancientSpider; //Individualized enemy here
                            Console.WriteLine($"An {enemy.Name} is attacking you! Get ready to fight!"); //Customize per encounter
                            Console.WriteLine("Press any button to begin the fight!");
                            Console.ReadKey(true);

                            bool exitFight = false;
                            do
                            {
                                Formatting.DisplaySpider();//Spider Art Method
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
                                            oldLibrary.IsMonsterDead = true;
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
                                            Formatting.RedText($"As you flee, the {enemy.Name} attempts to attack!");
                                            Combat.Attack(enemy, hero);
                                        }
                                        exitFight = true;
                                        oldLibrary.IsCurrentRoom = false;
                                        mainHall.IsCurrentRoom = true;
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
                                    Console.WriteLine($"You have been slain by the {enemy.Name}.");
                                    exitApplication = true;
                                }

                            } while (!exitFight && !exitApplication);

                            #endregion

                        }//end spider fight
                        while (oldLibrary.IsCurrentRoom && !exitApplication)
                        {
                            Console.WriteLine(oldLibrary);
                            if (!oldLibrary.IsPuzzleComplete)
                            {
                                Console.WriteLine(@"
[1] View your Inventory
[2] Search the Bodies
[3] Find the Source of the Flickering Light
[4] Search for useful books
[5] Return to Main Hall
");
                            }
                            else
                            {
                                Console.WriteLine(@"
[1] View your Inventory
(You have already found everything in this room)
[5] Return to Main Hall
");
                            }

                            ConsoleKey roomMenuChoice = Console.ReadKey(true).Key;

                            switch (roomMenuChoice)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Formatting.ViewHeroInventory(hero);
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    Formatting.ViewRoomWeaponInventory(oldLibrary.RoomWeaponLoot, hero.WeaponInventory);
                                    break;

                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    Console.WriteLine($"You manage to find a set of stairs that are covered in webbing." +
                                        $"\nYou put your {hero.EquippedWeapon.Name} to use and make quick work of the" +
                                        $"\npesky material. As you ascend to a small balcony, you can see that the light is" +
                                        $"\ncoming from a small, wrought iron latern that is perched precariously on the top" +
                                        $"\nof a bookshelf. You have to stretch a bit to reach it, but you manage pick it up." +
                                        $"\nWrought Iron Lantern has been added to your inventory");
                                    hero.OtherInventory.Add(lantern);
                                    artGallery.RoomOtherLoot.Remove(lantern);
                                    break;

                                case ConsoleKey.D4:
                                case ConsoleKey.NumPad4:
                                    Console.Clear();
                                    Formatting.ViewRoomBookInventory(oldLibrary.RoomBookLoot, hero.BookInventory);
                                    break;

                                case ConsoleKey.D5:
                                case ConsoleKey.NumPad5:
                                    Console.Clear();
                                    Console.WriteLine("You return to the Main Hall");
                                    oldLibrary.IsCurrentRoom = false;
                                    mainHall.IsCurrentRoom = true;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine($"{roomMenuChoice} was not a valid option. Select again");
                                    break;
                            }//end room menu switch
                            if (hero.BookInventory.Contains(oldPoem) && hero.BookInventory.Contains(burnedNote) && hero.WeaponInventory.Contains(fineSteelSword) && hero.OtherInventory.Contains(lantern))
                            {
                                oldLibrary.IsPuzzleComplete = true;
                            } 
                        }
                    }//end Library Room

                    #endregion

                    #region Crypt
                    while (crypt.IsCurrentRoom)
                    {
                        Console.WriteLine(crypt);
                        if (!crypt.IsPuzzleComplete)
                        {
                            Console.WriteLine(@"
[1] View your Inventory
[2] Examine the Etching
[3] Attempt to Open the Doors
[4] Return to Main Hall
");
                        }//end puzzle not complete
                        else
                        {
                            Console.WriteLine(@"

[1] View your Inventory
[2] Examine the Etching
[3] Enter the Tomb
[4] Return to Main Hall
");
                        }
                        ConsoleKey roomMenuChoice = Console.ReadKey(true).Key;

                        switch (roomMenuChoice)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Formatting.ViewHeroInventory(hero);
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                bool backToCrypt = false;
                                while (!backToCrypt)
                                {
                                    
                                    Console.WriteLine(@"
You see the following carved into the smooth stone wall 
and inlaid with pearl:

****************************************************
* With this wine, I shall fill thine cup daily.     *      
***                                               ***     
* With this lantern, I light thine way in the dark. *         
***                                               ***          
* With this ring, you shall be mine till death      *    
****************************************************
");
                                    if (hero.OtherInventory.Contains(darkRedWine))
                                    {
                                        Console.WriteLine("[W] Place the Dark Red Wine in an alcove.");
                                    }
                                    if (hero.OtherInventory.Contains(lantern))
                                    {
                                        Console.WriteLine("[L] Place the Wrought Iron Lantern in an alcove.");
                                    }
                                    if (hero.OtherInventory.Contains(weddingRing))
                                    {
                                        Console.WriteLine("[R] Place the Wedding Ring in an alcove.");
                                    } 
                                    if (crypt.RoomOtherLoot.Contains(darkRedWine) && crypt.RoomOtherLoot.Contains(lantern) && crypt.RoomOtherLoot.Contains(weddingRing))
                                    {
                                        Console.WriteLine("All 3 items are in their alcoves. The doors to the Tomb are now open.");
                                        crypt.IsPuzzleComplete = true;
                                    }

                                    Console.WriteLine("[1] Return to the crypt");
                                    ConsoleKey puzzleChoice = Console.ReadKey(true).Key;
                                    Console.Clear();
                                    switch (puzzleChoice)
                                    {
                                        case ConsoleKey.D1:
                                        case ConsoleKey.NumPad1:
                                            Console.WriteLine("You step away from the inscription and alcoves");
                                            backToCrypt = true;
                                            break;

                                        case ConsoleKey.W:
                                            if (hero.OtherInventory.Contains(darkRedWine))
                                            {
                                                hero.OtherInventory.Remove(darkRedWine);
                                                crypt.RoomOtherLoot.Add(darkRedWine);
                                                Console.WriteLine("You place the bottle into an alcove and small draft of air rushes past you");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nice try");
                                            }
                                            break;

                                        case ConsoleKey.L:
                                            if (hero.OtherInventory.Contains(lantern))
                                            {
                                                hero.OtherInventory.Remove(lantern);
                                                crypt.RoomOtherLoot.Add(lantern);
                                                Console.WriteLine("You place the lantern into an alcove and small draft of air rushes past you");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nice try");
                                            }
                                            break;

                                        case ConsoleKey.R:
                                            if (hero.OtherInventory.Contains(weddingRing))
                                            {
                                                hero.OtherInventory.Remove(weddingRing);
                                                crypt.RoomOtherLoot.Add(weddingRing);
                                                Console.WriteLine("You place the ring into an alcove and a small draft of air rushes past you");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nice try");
                                            }
                                            break;

                                        default:
                                            Console.Clear();
                                            Console.WriteLine($"{roomMenuChoice} was not a valid option. Select again");
                                            break;
                                    }//end switch

                                }//end puzzle while loop
                                break; //end item placing in crypt

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                if (!crypt.IsPuzzleComplete)
                                {
                                    Console.WriteLine("You try pushing, pulling, and even prying with your sword blade" +
                                        "\nIt doesn't seem like you're getting in the stone doors this way.");
                                }
                                else
                                {
                                    Console.WriteLine("You step through the open doors into the tomb beyond");
                                    Console.WriteLine("TOMB is WIP, thank you for getting this far!" +
                                        "\nTis a fearful thing: to love that which death can touch");
                                    crypt.IsCurrentRoom = false;
                                    //tomb.IsCurrentRoom = true;
                                }
                                break;

                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                Console.Clear();
                                Console.WriteLine("You ascend the stairs back to the Main Hall");
                                crypt.IsCurrentRoom = false;
                                mainHall.IsCurrentRoom = true;
                                break;
                                

                            default:
                                Console.Clear();
                                Console.WriteLine($"{roomMenuChoice} was not a valid option. Select again");
                                break;
                        }
                        
                    }//end crypt room
                    
                    #endregion

                }//end MAIN GAME loop
                
            } while (!exitApplication);
            //end ENTIRE Game Loop
            
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
