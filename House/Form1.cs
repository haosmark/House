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
        private Location currentLocation;

        public Form1()
        {
            InitializeComponent();
            createObjects();
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
            RoomWithDoor livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            Room diningRoom = new Room("Dining Room", "crystal chandelier");
            RoomWithDoor kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "screen door");
            OutsideWithDoor frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            OutsideWithDoor backYard = new OutsideWithDoor("Back Yard", true, "screen door");
            Outside garden = new Outside("Garden", false);
        }
    }
}
