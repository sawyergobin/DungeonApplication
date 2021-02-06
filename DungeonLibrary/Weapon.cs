using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon : Item
    {
        public WeaponType WeaponType { get; set; }
        public int AccuracyBonus { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public bool IsBlessed { get; set; }

        //ctor
        public Weapon(string name, string description, WeaponType weaponType, int accuracyBonus, int minDamage, int maxDamage, bool isBlessed) : base(name, description)
        {
            WeaponType = weaponType;
            AccuracyBonus = accuracyBonus;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            IsBlessed = isBlessed;
            
        }

        //ToString()
        public override string ToString()
        {
            return string.Format(base.ToString() + $"\nWeapon Accuracy Bonus: {AccuracyBonus}%\nDamage: {MinDamage} to {MaxDamage} per hit.{(IsBlessed ?"\nThis weapon is blessed and is able to be used effectively against vampires" : "")}");
        }


    }
}
