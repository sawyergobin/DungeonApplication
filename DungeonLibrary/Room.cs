using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Room
    {
        //Name, Description, List<items>, isMonsterDead, isPuzzleComplete, 
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> RoomLoot { get; set; }
        public bool IsCurrentRoom { get; set; }
        public bool IsMonsterDead { get; set; }
        public bool IsPuzzleComplete { get; set; }

        public Room(string name, string description, List<Item> roomLoot, bool isCurrentRoom, bool isMonsterDead, bool isPuzzleComplete)
        {
            IsMonsterDead = isMonsterDead;
            IsPuzzleComplete = isPuzzleComplete;
            Name = name;
            Description = description;
            RoomLoot = roomLoot;
            IsCurrentRoom = isCurrentRoom;
        }

        public override string ToString()
        {
            return string.Format($"Room: {Name}" +
                $"\nDescription: {Description}" +
                $"\n");
        }

        

    }
}
