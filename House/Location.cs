using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    abstract class Location
    {
        public Location(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public Location[] Exits;
        public virtual string Description
        {
            get
            {
                string description = "You are standing in the " + this.Name + ". You see exits to the following places: ";
                for (int i = 0; i < this.Exits.Length; i++)
                {
                    description += " " + this.Exits[i].Name;
                    if (i != this.Exits.Length - 1)
                    {
                        description += ", ";
                    }
                }
                description += ".";
                return description;
            }
        }
    }
}
