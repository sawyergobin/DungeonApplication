using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Formatting
    {
        public static void Header(string title)
        {
            Console.Title = "o-{====> " + title + " <====}-o";
        }

        //TODO Damage and healing text coloration methods?


        //TODO Vampire / Player Speaking text coloration methods?
        #region ConsoleBeep Themes

        public static void MainTheme()
        {
            Console.Beep(261, 400);
            Console.Beep(293, 400);
            Console.Beep(261, 400);
            Console.Beep(293, 400);
            Console.Beep(311, 400);
            Console.Beep(247, 400);
            Console.Beep(261, 400);

        }

        public static void GameOverTheme()
        {
            Console.Beep(311, 600);
            Console.Beep(267, 600);
            Console.Beep(220, 300);
            Console.Beep(208, 300);
            Console.Beep(185, 600);
        }

        #endregion

        #region Text Coloration Methods

        public static void RedText(string input)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(input);
            Console.ResetColor();

        }

        public static void GreenText(string input)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(input);
            Console.ResetColor();
        }
        #endregion

        #region ViewRoomInventory() (and sub methods)
        //TODO Could use some formatting work
        
        //ViewRoomWeaponInventory()
        public static void ViewRoomWeaponInventory(List<Weapon> inputInventory, List<Weapon> playerInventory)
        {
            bool exitLoop = false;
            do
            {
                Console.WriteLine("You search for any useable items: " +
                    "\n(Items may be equipped, read, or used from your inventory screen)\n");
                List<Weapon> weaponsToRemove = new List<Weapon>();
                foreach (Weapon item in inputInventory)
                {
                    bool exitItemChoice = false;
                    do
                    {

                        Console.WriteLine($"You found: {item.Name}\n" +
                            $"[1] Examine {item.Name}\n" +
                            $"[2] Take {item.Name}\n" +
                            $"[3] Leave {item.Name} where it is");
                        ConsoleKey userChoice = Console.ReadKey(true).Key;

                        switch (userChoice)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Console.WriteLine("You examine the item: " +
                                    $"\n{item.Description}" +
                                    $"\nChoose whether to take or leave it.");
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                playerInventory.Add(item);
                                Console.WriteLine($"{item.Name} added to your inventory.");
                                weaponsToRemove.Add(item);
                                exitItemChoice = true;
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                Console.WriteLine($"You leave the {item.Name} where it is.");
                                exitItemChoice = true;
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine($"{userChoice} was not a valid option, please choose again");
                                break;
                        }//end switch
                        
                    } while (!exitItemChoice);

                }//end foreach item loop
                foreach (Weapon item in weaponsToRemove)
                {
                    inputInventory.Remove(item);
                }//end removal foreach
                exitLoop = true;
            } while (!exitLoop);
        }
        
        //ViewRoomBookInventory()
        public static void ViewRoomBookInventory(List<Book> inputInventory, List<Book> playerInventory)
        {
            bool exitLoop = false;
            do
            {
                Console.WriteLine("You search for any useable items: " +
                    "\n(Items may be equipped, read, or used from your inventory screen)\n");
                List<Book> booksToRemove = new List<Book>();
                foreach (Book item in inputInventory)
                {
                    bool exitItemChoice = false;
                    do
                    {

                        Console.WriteLine($"You found: {item.Name}\n" +
                            $"[1] Examine {item.Name}\n" +
                            $"[2] Take {item.Name}\n" +
                            $"[3] Leave {item.Name} where it is");
                        ConsoleKey userChoice = Console.ReadKey(true).Key;

                        switch (userChoice)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Console.WriteLine("You examine the item: " +
                                    $"\n{item.Description}" +
                                    $"\nChoose whether to take or leave it.");
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                playerInventory.Add(item);
                                Console.WriteLine($"{item.Name} added to your inventory.");
                                booksToRemove.Add(item);
                                exitItemChoice = true;
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                Console.WriteLine($"You leave the {item.Name} where it is.");
                                exitItemChoice = true;
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine($"{userChoice} was not a valid option, please choose again");
                                break;
                        }//end switch

                    } while (!exitItemChoice);
                }//end foreach item loop
                foreach (Book item in booksToRemove)
                {
                    inputInventory.Remove(item);
                }//end removal foreach
                exitLoop = true;
            } while (!exitLoop);
        }

        //ViewRoomOtherItemInventory()
        public static void ViewRoomOtherItemInventory(List<OtherItem> inputInventory, List<OtherItem> playerInventory)
        {
            List<OtherItem> itemsToRemove = new List<OtherItem>();
            bool exitLoop = false;
            do
            {
                Console.WriteLine("You search for any useable items: " +
                    "\n(Items may be equipped, read, or used from your inventory screen)\n");

                foreach (OtherItem item in inputInventory)
                {
                    bool exitItemChoice = false;
                    do
                    {

                        Console.WriteLine($"You found: {item.Name}\n" +
                            $"[1] Examine {item.Name}\n" +
                            $"[2] Take {item.Name}\n" +
                            $"[3] Leave {item.Name} where it is");
                        ConsoleKey userChoice = Console.ReadKey(true).Key;

                        switch (userChoice)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                Console.WriteLine("You examine the item: " +
                                    $"\n{item.Description}" +
                                    $"\nChoose whether to take or leave it.");
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                playerInventory.Add(item);
                                Console.WriteLine($"{item.Name} added to your inventory.");
                                itemsToRemove.Add(item);
                                exitItemChoice = true;
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                Console.WriteLine($"You leave the {item.Name} where it is.");
                                exitItemChoice = true;
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine($"{userChoice} was not a valid option, please choose again");
                                break;
                        }//end switch

                    } while (!exitItemChoice);

                }//end foreach item loop
                foreach (OtherItem item in itemsToRemove)
                {
                    inputInventory.Remove(item);
                }//end removal foreach
                exitLoop = true;
            } while (!exitLoop);
        }

        //All 3 combined to view total room inventory
        public static void ViewRoomInventory(PlayerCharacter hero, Room room)
        {
            List<Weapon> heroWeapons = hero.WeaponInventory;
            List<Book> heroBooks = hero.BookInventory;
            List<OtherItem> heroOtherItems = hero.OtherInventory;
            List<Weapon> roomWeapons = room.RoomWeaponLoot;
            List<Book> roomBooks = room.RoomBookLoot;
            List<OtherItem> roomOtherItems = room.RoomOtherLoot;

            Console.Clear();
            ViewRoomWeaponInventory(roomWeapons, heroWeapons);
            Console.Clear();
            ViewRoomBookInventory(roomBooks, heroBooks);
            Console.Clear();
            ViewRoomOtherItemInventory(roomOtherItems, heroOtherItems);

            Console.WriteLine("\nNo other items here seem particularly useful.\n");

        }//end method

        //Master ViewRoomInventoryMethod

        #endregion

        #region ViewHeroInventory()
        //Needs Formatting Fixes
        //Needs a ternary operator for If weapon is already equipped!

        public static void ViewHeroInventory(PlayerCharacter hero)
        {
            bool exitLoop = false;
            do
            {
                bool viewWeapons = false;
                bool viewBooks = false;
                bool viewOther = false;

                bool exitItemType = false;
                do
                {

                    Console.WriteLine($"You currently have {hero.Life} health out of {hero.MaxLife} maximum." +
                        $"\nYou can always return to your campfire to heal." +
                        "\nYou open your pack to examine your inventory" +
                        "\nHere you can examine your items, equip weapons, and read books you've picked up" +
                        "\nSelect which item type you look at\n" +
                        "[1] Weapons\n" +
                        "[2] Books\n" +
                        "[3] Other Items\n" +
                        "[4] Exit Your Inventory");

                    ConsoleKey itemTypeChoice = Console.ReadKey(true).Key;

                    switch (itemTypeChoice)
                    {
                        case ConsoleKey.D1://weapons
                        case ConsoleKey.NumPad1:
                            Console.Clear();
                            exitItemType = true;
                            viewWeapons = true;
                            break;

                        case ConsoleKey.D2://books
                        case ConsoleKey.NumPad2:
                            Console.Clear();
                            exitItemType = true;
                            viewBooks = true;
                            break;

                        case ConsoleKey.D3://other items
                        case ConsoleKey.NumPad3:
                            Console.Clear();
                            exitItemType = true;
                            viewOther = true;
                            break;

                        case ConsoleKey.D4://exit inventory
                        case ConsoleKey.NumPad4:
                            Console.Clear();
                            Console.WriteLine("You leave your inventory without examining anything further.");
                            exitLoop = true;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine($"{itemTypeChoice} was not a valid option. Select again");
                            break;
                    }//end itemtype select switch

                } while (!exitItemType && !exitLoop); //end item TYPE selection

                //Start Weapon Section
                while (viewWeapons)
                {
                    foreach (Weapon item in hero.WeaponInventory)
                    {
                        bool exitItemChoice = false;
                        do
                        {
                            Console.WriteLine($"You have: {item.Name}\n" +
                                                $"[1] Examine {item.Name}\n" +
                                                $"[2] Equip {item.Name}\n" +
                                                $"[3] Do nothing with {item.Name}");

                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                            switch (userChoice)
                            {
                                case ConsoleKey.D1://examine
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Console.WriteLine("You examine the weapon: " +
                                        $"\n{item}" +
                                        $"\nChoose whether to equip or leave it.");
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    hero.EquippedWeapon = (Weapon)item;
                                    Console.WriteLine($"You take a moment to strap on the {item.Name}");
                                    Console.WriteLine($"{item.Name} is now equipped to be used in combat." +
                                        $"\n+++++++++++++++++++++++");
                                    exitItemChoice = true;
                                    break;

                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    Console.WriteLine($"You leave the {item.Name} in your pack" +
                                        $"\n+++++++++++++++++++++++");
                                    exitItemChoice = true;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine($"{userChoice} was not a valid option, please choose again");
                                    break;
                            }//end switch
                        } while (!exitItemChoice);

                    }//end foreach item loop 
                    viewWeapons = false;
                }//end viewWeapons loop

                while (viewBooks)
                {
                    foreach (Book item in hero.BookInventory)
                    {
                        bool exitItemChoice = false;
                        do
                        {
                            Console.WriteLine($"You have: {item.Name}\n" +
                                                $"[1] Examine {item.Name}\n" +
                                                $"[2] Read the Contents of {item.Name}\n" +
                                                $"[3] Do nothing with {item.Name}");

                            ConsoleKey userChoice = Console.ReadKey(true).Key;

                            switch (userChoice)
                            {
                                case ConsoleKey.D1://examine
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Console.WriteLine($"You examine the {item.Name}: " +
                                        $"\n{item.Description}" +
                                        $"\nChoose whether to read it or leave it be.");
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    Console.WriteLine($"You read contents of the {item.Name} " +
                                        $"\n+++++++++++++++++++++++" +
                                        $"\n{item.Contents}" +
                                        $"\n+++++++++++++++++++++++" +
                                        $"\nPress Any Key to Continue...");
                                    Console.ReadKey(true);
                                    exitItemChoice = true;
                                    break;

                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    Console.WriteLine($"You leave the {item.Name} in your pack" +
                                        $"\n+++++++++++++++++++++++");
                                    exitItemChoice = true;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine($"{userChoice} was not a valid option, please choose again");
                                    break;
                            }//end switch
                        } while (!exitItemChoice);

                    }//end foreach item loop 
                    viewBooks = false;
                }//end viewBooks

                while (viewOther)
                {
                    foreach (OtherItem item in hero.OtherInventory)
                    {
                        bool exitItemChoice = false;
                        do
                        {
                            Console.WriteLine($"You have: {item.Name}\n" +
                                                $"[1] Examine {item.Name}\n" +
                                                $"[2] Do nothing with {item.Name}");

                            ConsoleKey userChoice = Console.ReadKey(true).Key;

                            switch (userChoice)
                            {
                                case ConsoleKey.D1://examine
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Console.WriteLine($"You examine the {item.Name}: " +
                                        $"\n{item.Description}" +
                                        $"\n+++++++++++++++++++++++");
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    Console.WriteLine($"You leave the {item.Name} in your pack" +
                                        $"\n+++++++++++++++++++++++");
                                    exitItemChoice = true;
                                    exitItemChoice = true;
                                    break;
                                    
                                default:
                                    Console.Clear();
                                    Console.WriteLine($"{userChoice} was not a valid option, please choose again");
                                    break;
                            }//end switch
                        } while (!exitItemChoice);

                    }//end foreach item loop 
                    viewOther = false;
                }//end viewother

                exitLoop = true;
            } while (!exitLoop);//exiting entire method
        }//end ViewHeroInventory()


        #endregion

        #region Healing Methods

        public static void FullHeal(Creature creature)
        {
            creature.Life = creature.MaxLife;
        }

        public static void PartialHeal(Creature creature, int healAmount) //Needs testing for overhealing
        {
            creature.Life += healAmount;
        }

        #endregion

        //ASCII ART STORAGE

        public static void DisplayCastleArt()//replace when website works
        {
            string castleArt = @"
                                       /\
                                      /`:\
                                     /`'`:\
                                    /`'`'`:\
                                   /`'`'`'`:\
                                  /`'`'`'`'`:\
                                   |`'`'`'`:|
     _ _  _  _  _                  |] ,-.  :|_  _  _  _
    ||| || || || |                 |  |_| ||| || || || |
    |`' `' `' `'.|                 | _'=' |`' `' `' `'.|
    :          .:;                 |'-'   :          .:;
     \-..____..:/  _  _  _  _  _  _| _  _'-\-..____..:/
      :--------:_,' || || || || || || || `.::--------:
      |]     .:|:.  `' `'_`' `' `' `' `'    | '-'  .:|
      |  ,-. .[|:._     '-' ____     ___    |   ,-.'-|
      |  | | .:|'--'_     ,'____`.  '---'   |   | |.:|
      |  |_| .:|:.'--' ()/,| |`|`.\()   __  |   |_|.:|
      |  '=' .:|:.     |::_|_|_|\|::   '--' |  _'='.:|
      | __   .:|:.     ;||-,-,-,-,|;        | '--' .:|
      |'--'  .:|:. _  ; ||       |:|        |      .:|
      |      .:|:.'-':  ||       |;|     _  |]     _:|
      |      '-|:.   ;  ||       :||    '-' |     '--|
      |  _   .:|].  ;   ||       ;||]       |   _  .:|
      | '-'  .:|:. :   [||      ;|||        |  '-' .:|
  ,', ;._____.::-- ;---->'-,--,:-'<'--------;._____.::.`.
 ((  (          )_;___,' ,' ,  ; //________(          ) ))
  `. _`--------' : -,' ' , ' '; //-       _ `--------' ,'
       __  .--'  ;,' ,'  ,  ': //    -.._    __  _.-  -
   `-   --    _ ;',' ,'  ,' ,;/_  -.       ---    _,
       _,.   /-:,_,_,_,_,_,_(/:-\   ,     ,.    _
     -'   `-'--'-'-'-'-'-'-'-''--'-' `-'`'  `'`' `

";
            Console.WriteLine(castleArt);
            
        }

        #region Moon

        string moon = @"

                                          ,,,,,,,
                                ,╖@╫╢▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╬@╦╓,
                           ┌@╢▒▒▒▒▒▒▒▒▒▒░░░░░░╜▒▒▒▒▒▒▒▒▒▒╢╣▓%╖        `
                       ,╦╣▒▒▒░░░░░░░▒▒▒▒░░░░░░░░░░░▒▒▒░▒▒▒╢╣╫╢▒▓N,
                    ,╗╣▒▒▒▒▒░░░░░░░▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒▒╣╢╢╫╣╫╢▒▒@,
                  ┌╬▒▒▒▒▒▒▒▒▒░░░▒▒╢▒▒▒░░▒░░░░░░░░▒@╣╢▒╫▒▒▒▒╢▒╢▒▒▒╢╢▒▒╣╖
                ┌╣▒▒▒▒▒▒▒▒▒▒▒▒▒▒╢▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒▒▒▒╢╢▒▒╣w
              ,╣▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░▒▒▒▒▒▒▒▒░░░▒░▒▒▒▒▒▒▒▒▒▒▒╣╢╢▒▒▓,
             ╓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒╢▒▒▒▒▒▒▒▒▒▒╢▒▒╢▒╢▒╣@
            ╫▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░▒░▒▒▒▒▒╢╣▒▒▒▒╢▒▒▒▒▒▒╫▒▒▒▒╢▒▒▓
           ╣▒▒▒▒▒▒▒▒▒▒░░░░▒░▒░░░░░░░░░░░░░░░░░░▒▒╢▒▒╣▒▒▒, ╝╣╣▒▒▒╣▒▒▒▒▒▒▒▒▒▒▒▒╢
          Æ╢▒╢╣▒▒▒▒▒▒░▒░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒%ßm╣▒▒╨▒▒▒▒▒▒▒▒▒▒▒▒▒╢
         ╒╣▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒╢╓,`,╓╫▒╫╙`╙╩""]▒▒▒▒▒▒╫
         ╢╢╣╣▒▒░░▒░░░▒░░▒░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒@╗     ╣▒▒▒▒L
        ]▒▒▒▒▒▒░░░░╜(▒▒▒▒░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒╬,┌╓,╙▒▒▒▒▒▒▒▒▒▒▓╣▒╢▒╣▒▒▒▒╫
        ║▒▒▒▒▒▒░░░▒▒`╓╖▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒[]▒▒, ╫╣▓▒╢▒╢▒▒╢▒╢▒▒╢▒
        ▒▒▒▒▒▒▒░░░▒ ╨╥╥'m▒▒░░░░░░░░░░░░░░░░░░▒░░░░▒╜▒""║░▒▒▒▒▒▒▒▒▒╦@╗▓╣╣╢╣▒▒╢╣▒▒╢▒⌐
        ▒▒▒▒▒▒▒▒░░░▒;=""╙ ╓░░░░░▒░░░▒▒▒░░░░░░░░░░░▒∩─┐  ,,,▒▒▒▒░░░░▒▒▒╢╢▒▒╣▒╢╣▒▒▒▒L
        ]▒▒▒▒▒▒░░░░▒▒▒`. └▒░░░░░░░░░░░░░░░░░░░░░`▒░░▒▒▒░░░░░, `' .▒░▒▒▒▒▒▒▒▒▒▒▒▒▒`
         ▒▒▒▒▒▒░░░░▒░░░,  ▒░░░░░░▒`░░░░░░░░░░░ ░. ""▒▒▒░░,──.└░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒
         ▒▒▒▒▒░▒░░░░▒░░░  ░░░░░░░  ░░░░░░░░ ,▒░░░░,─, ,░░░░░ ░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒╜
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
     
";


        #endregion







    }
}
