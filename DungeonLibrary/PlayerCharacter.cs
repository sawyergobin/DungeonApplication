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
        public Weapon EquippedWeapon { get; set; }//create weapon class
        public List<Item> Inventory { get; set; }

        //ctor
        public PlayerCharacter(string name, int life, int maxLife, int accuracy, int defense, PlayerBackstory playerBackstory, PlayerClass playerClass, Weapon equippedWeapon, List<Item> inventory) : base(name, life, maxLife, accuracy, defense)
        {
            PlayerBackstory = playerBackstory;
            PlayerClass = playerClass;
            EquippedWeapon = equippedWeapon;
            Inventory = inventory;
        }

        //Methods
        //TODO ToString override for view self stats

        //TODO calc atk and def methods

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

    }
}
