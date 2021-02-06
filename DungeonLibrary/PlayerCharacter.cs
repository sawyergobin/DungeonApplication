using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class PlayerCharacter : Creature
    {
        public PlayerBackstory PlayerBackstory { get; set; }
        public PlayerClass PlayerClass { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public List<Item> Inventory { get; set; }

        //ctor
        public PlayerCharacter(string name, int life, int maxLife, int accuracy, int defense, PlayerBackstory playerBackstory, PlayerClass playerClass, Weapon equippedWeapon, List<Item> inventory) : base(name, life, maxLife, accuracy, defense)
        {
            PlayerBackstory = playerBackstory;
            PlayerClass = playerClass;
            EquippedWeapon = equippedWeapon;
            Inventory = inventory;
            //TODO Apply backstory and class stat changes as branching logic

            switch (playerClass) //Class stat mods
            {
                case PlayerClass.Warrior:
                    EquippedWeapon.MaxDamage += 2; //will this work with all weapons equipped later? Maybe have this calc in the method or combat.
                    EquippedWeapon.MinDamage += 2;
                    Defense += 10;
                    break;

                case PlayerClass.Thief:
                    Accuracy += 15; //Also large def bonus on dodge //TODO Maybe start with health potion?
                    break;

            }
        }

        //Methods
        

        public override string ToString()
        {
            return string.Format($"Hero Name: {Name}\nClass and Backstory: {PlayerClass}, {PlayerBackstory}\nHealth Remaining: {Life} / Maximum: {MaxLife}\n" +
                $"Accuracy: {CalcAccuracy()}% (Chance to hit)\nDefense: {Defense}% (Chance to block or dodge an enemy attack that would otherwise hit)\n" +
                $"Equipped Weapon: {EquippedWeapon}");
        }


        public override int CalcAccuracy()
        {
            return Accuracy + EquippedWeapon.AccuracyBonus;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

    }
}
