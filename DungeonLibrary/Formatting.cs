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

        #region Room ViewInventory()

        public static void ViewInventory(List<Item> inputInventory, List<Item> playerInventory) //might be better as an instance method? how to do?
        {
            bool exitLoop = false;
            do
            {
                Console.WriteLine("You search for any useable items: (Items must be added to inventory to be used)");

                foreach (Item item in inputInventory)
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
                                //inputInventory.Remove(item); TODO figure out how to remove items without RT error?
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
                exitLoop = true;
            } while (!exitLoop);
        }//end ViewInventory()

        #endregion

        #region ViewHeroInventory()
        //DO NOT USE! STILL WIP!
        //Each version should probably be its own method unless I can perform branching logic between item types (.GetType()???)
        public static void ViewHeroInventory(List<Item> heroInventory) 
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

                    Console.WriteLine("You open your pack to examine your inventory" +
                        "\nSelect which item type you look at" +
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

                            viewWeapons = true;
                            break;

                        case ConsoleKey.D2://books
                        case ConsoleKey.NumPad2:
                            Console.Clear();

                            viewBooks = true;
                            break;

                        case ConsoleKey.D3://other items
                        case ConsoleKey.NumPad3:
                            Console.Clear();

                            viewOther = true;
                            break;

                        case ConsoleKey.D4://exit inventory
                        case ConsoleKey.NumPad4:
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
                    foreach (Weapon item in heroInventory)
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
                                        $"\n{item.Description}" +
                                        $"\nChoose whether to equip or leave it.");
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    //TODO figure this out. Mentoring help??
                                    Console.WriteLine($"{item.Name} is equipped to be used in combat.");
                                    exitItemChoice = true;
                                    break;

                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    Console.WriteLine($"You leave the {item.Name} in your pack");
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
                    foreach (Book item in heroInventory)
                    {
                        bool exitItemChoice = false;
                        do
                        {
                            Console.WriteLine($"You have: {item.Name}\n" +
                                                $"[1] Examine {item.Name}\n" +
                                                $"[2] Read {item.Name}\n" +
                                                $"[3] Do nothing with {item.Name}");

                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                            //NOTHING PAST THIS IS MODIFIED,
                            switch (userChoice)
                            {
                                case ConsoleKey.D1://examine
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Console.WriteLine("You examine the book: " +
                                        $"\n{item.Description}" +
                                        $"\nChoose whether to read it or leave it be.");
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    Console.WriteLine(item.Contents);
                                    exitItemChoice = true;
                                    break;

                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    Console.WriteLine($"You leave the {item.Name} in your pack");
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
                    //WARNING THIS IS JUST A COPY FROM BOOKS! NOT DONE
                    foreach (Item item in heroInventory)
                    {
                        bool exitItemChoice = false;
                        do
                        {
                            Console.WriteLine($"You have: {item.Name}\n" +
                                                $"[1] Examine {item.Name}\n" +
                                                $"[2] Read {item.Name}\n" +
                                                $"[3] Do nothing with {item.Name}");

                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                            switch (userChoice)
                            {
                                case ConsoleKey.D1://examine
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    Console.WriteLine("You examine the item: " +
                                        $"\n{item.Description}");
                                    break;
                                    
                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    Console.WriteLine($"You leave the {item.Name} in your pack");
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









    }
}
