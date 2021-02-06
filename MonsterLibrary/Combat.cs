using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Combat
    {
        public static void Attack(Creature attacker, Creature defender)
        {
            Random diceRoll = new Random();
            int result = diceRoll.Next(1, 101);
            //Sleep to allow random results
            System.Threading.Thread.Sleep(35);

            if (result <= attacker.CalcAccuracy() - defender.CalcDefense())
            {
                int damageDealt = attacker.CalcDamage(); //Might need ternary operator for future weapons for warrior class
                defender.Life -= damageDealt;
                Formatting.RedText($"{attacker.Name} hit {defender.Name} for {damageDealt} points of damage.");
            }//end if
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end attack

        public static void Battle(PlayerCharacter hero, Monster monster)
        {
            Attack(hero, monster);
            if (monster.Life > 0)
            {
                Attack(monster, hero);
            }//end reply attack
        }//end battle



    }
}
