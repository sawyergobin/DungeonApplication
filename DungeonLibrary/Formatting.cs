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

                        Console.WriteLine($"Item: {item.Name}\n" +
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
                                inputInventory.Remove(item);
                                Console.WriteLine($"{item.Name} added to your inventory.");
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



    //ASCII ART STORAGE

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
