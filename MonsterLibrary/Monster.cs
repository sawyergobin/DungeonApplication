using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Monster : Creature
    {
        public string Description { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        //ctor
        public Monster(string name, int life, int maxLife, int accuracy, int defense, string description, int minDamage, int maxDamage) : base(name, life, maxLife, accuracy, defense)
        {
            Description = description;
            MinDamage = minDamage;
            MaxDamage = maxDamage;

        }

        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}. \n" +
                $"{(Life == MaxLife ? "It is uninjured" : Life >= MaxLife / 2 ? "It is wounded" : "It is gravely wounded.")}");
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage+1);
        }
    }
}
