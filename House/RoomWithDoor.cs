﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration)
        {
            this.doorDescription = doorDescription;
        }

        private Location doorLocation;
        public Location DoorLocation
        {
            get { return this.doorLocation; }
            set { this.doorLocation = value; }
        }

        private string doorDescription;
        public string DoorDescription
        {
            get { throw new NotImplementedException(); }
        }
    }
}
