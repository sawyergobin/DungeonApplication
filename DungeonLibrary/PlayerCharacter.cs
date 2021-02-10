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
        public List<Weapon> WeaponInventory { get; set; }
        public List<Book> BookInventory { get; set; }
        public List<OtherItem> OtherInventory { get; set; }

        //ctor
        public PlayerCharacter(string name, int life, int maxLife, int accuracy, int defense, PlayerBackstory playerBackstory, PlayerClass playerClass, Weapon equippedWeapon, List<Weapon> weaponInventory, List<Book> bookInventory, List<OtherItem> otherInventory) : base(name, life, maxLife, accuracy, defense)
        {
            PlayerBackstory = playerBackstory;
            PlayerClass = playerClass;
            EquippedWeapon = equippedWeapon;
            WeaponInventory = weaponInventory;
            BookInventory = bookInventory;
            OtherInventory = otherInventory;

            switch (playerClass) //Class stat mods
            {
                case PlayerClass.Warrior:
                    Defense += 10;
                    break;

                case PlayerClass.Thief:
                    Accuracy += 15; //Also large def bonus on dodge
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
            
            if (PlayerClass == PlayerClass.Warrior)
            {
                EquippedWeapon.MinDamage += 2;
                EquippedWeapon.MaxDamage += 2;
                int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
                EquippedWeapon.MinDamage -= 2;
                EquippedWeapon.MaxDamage -= 2;
                return damage;
            }
            else //for thief
            {
                int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
                return damage;
            }//end else
        }//end CalcDamage()

    }//end class
}//end namespace
