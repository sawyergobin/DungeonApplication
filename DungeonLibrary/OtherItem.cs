using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class OtherItem : Item
    {
        public bool HasBeenUsed { get; set; }

        public OtherItem(string name, string description, bool hasBeenUsed) : base(name, description)
        {
            HasBeenUsed = hasBeenUsed;
        }//end FQCTOR

        public override string ToString()
        {
            return base.ToString();
        }

    }//end class
}
