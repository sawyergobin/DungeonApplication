using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //FQctor
        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        //ToString() Override
        public override string ToString()
        {
            return String.Format($"Item: {Name}\nDescription: {Description}");
        }

    }
}
