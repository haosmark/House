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

        }
    }
}
