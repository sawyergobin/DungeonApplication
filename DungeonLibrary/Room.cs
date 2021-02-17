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
        public List<Weapon> RoomWeaponLoot { get; set; }
        public List<Book> RoomBookLoot { get; set; }
        public List<OtherItem> RoomOtherLoot { get; set; }
        public bool IsCurrentRoom { get; set; }
        public bool IsMonsterDead { get; set; }
        public bool IsPuzzleComplete { get; set; }

        public Room(string name, string description, List<Weapon> roomWeaponLoot, List<Book> roomBookLoot, List<OtherItem> roomOtherLoot, bool isCurrentRoom, bool isMonsterDead, bool isPuzzleComplete)
        {
            IsMonsterDead = isMonsterDead;
            IsPuzzleComplete = isPuzzleComplete;
            Name = name;
            Description = description;
            RoomWeaponLoot = roomWeaponLoot;
            RoomBookLoot = roomBookLoot;
            RoomOtherLoot = roomOtherLoot;
            IsCurrentRoom = isCurrentRoom;
        }

        public override string ToString()
        {
            return string.Format($"+++++++++++++++++++++++++++++++++++" +
                $"\nRoom: " +
                $"\n{Name}" +
                $"\nDescription: {Description}" +
                $"\n+++++++++++++++++++++++++++++++++++");
        }

        

    }
}
