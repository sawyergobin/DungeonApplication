using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Creature
    {
        private string _name;
        private int _life;

        public int MaxLife { get; set; }
        public int Accuracy { get; set; }
        public int Defense { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value.Trim(); }
        }//end Name

        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= MaxLife ? value : MaxLife;
            }//end set
        }//end Life

        public Creature(string name, int life, int maxLife, int accuracy, int defense)
        {
            MaxLife = maxLife; //Needs to go first from business rules
            Name = name;
            Life = life;
            Accuracy = accuracy;
            Defense = defense;
        }//end FQCTOR
        
        //virtual option allows modification in derived classes 
        public virtual int CalcDefense()
        {
            return Defense;
        }

        public virtual int CalcAccuracy()
        {
            return Accuracy;
        }

        //abstract method forces definition to be given in derived classes
        public abstract int CalcDamage();

        //TODO Create virtual TOSTRING() override

    }//end class
}//end namespace
