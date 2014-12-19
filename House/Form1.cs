using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1()
        {
            InitializeComponent();
            createObjects();
            currentLocation = frontYard;
        }

        private void moveToANewLocation(Location location)
        {
            currentLocation = location;
            exitsComboBox.Items.Clear();
            // add new exits (available)

            descriptionTxt.Text += currentLocation.Description;
        }

        private void createObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "screen door");
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "screen door");
            garden = new Outside("Garden", false);

            frontYard.Exits = new Location[2] { livingRoom, garden };
            livingRoom.Exits = new Location[2] { frontYard, diningRoom };
            diningRoom.Exits = new Location[2] { livingRoom, kitchen };
            kitchen.Exits = new Location[2] { diningRoom, backYard };
            backYard.Exits = new Location[2] { kitchen, garden };
            garden.Exits = new Location[2] { frontYard, backYard };
        }
    }
}
