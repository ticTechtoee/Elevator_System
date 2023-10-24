using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On Start, elevator is at the Ground Floor that is 0 on our case

            // Gate of the elevator in the Ground Floor is Open for Users
            lblDisplayFloorNumberInsideElevator.Text = "0";
            lblDisplayFloorNumber.Text = "0";
        }

        private void btnElevatorRequestToFFloor_Click(object sender, EventArgs e)
        {
            // State of the Elevator is going to change from the last stage

            // Door Closed
            lblDisplayFloorNumberInsideElevator.Text = "Going Up";
            lblDisplayFloorNumber.Text = "Going Up";
            

        }
    }
}
