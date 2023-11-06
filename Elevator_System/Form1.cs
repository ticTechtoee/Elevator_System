using System;
using System.Diagnostics;
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

        private Stopwatch stopwatch = new Stopwatch();

        private void btnElevatorRequestToFFloor_Click(object sender, EventArgs e)
        {
            // State of the Elevator is going to change from the last stage

            // Start the stopwatch when the button is pressed
            stopwatch.Start();
            tmrTimeDurartion.Enabled = true;
            tmrTimeDurartion.Start();




        }

        private void btnElevatorRequestToGFloor_Click(object sender, EventArgs e)
        {
            // State of the Elevator is going to change from the last stage

            // Door Closed
            lblDisplayFloorNumberInsideElevator.Text = "Going Down";
            lblDisplayFloorNumber.Text = "Going Down";
        }

        private void tmrTimeDurartion_Tick(object sender, EventArgs e)
        {
            // Get the elapsed time from the stopwatch
            TimeSpan elapsed = stopwatch.Elapsed;

            // Check if 10 seconds have passed
            if (elapsed.TotalSeconds >= 5)
            {
                // Door Closed
                lblDisplayFloorNumberInsideElevator.Text = "Reached At First Floor";
                lblDisplayFloorNumber.Text = "1st Floor";

                // Stop the timer and the stopwatch
                tmrTimeDurartion.Stop();
                stopwatch.Stop();
            }
            else
            {
                // State of the Elevator is going to change from the last stage

                // Door Closed
                lblDisplayFloorNumberInsideElevator.Text = "Going Up";
                lblDisplayFloorNumber.Text = "Going Up";
            }
        }
    }
}
