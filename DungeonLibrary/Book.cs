using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Book : Item
    {
        public string Contents { get; set; }

        public Book(string name, string description, string contents) : base(name, description)
        {
            Contents = contents;
        }//end ctor

        public override string ToString()
        {
            return string.Format(base.ToString());//Doesn't show contents on ToString() to allow viewing the book itself 
        }
        
    }//end class
}//end namespace
