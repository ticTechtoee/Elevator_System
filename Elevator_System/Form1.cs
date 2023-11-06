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

        private Stopwatch stopwatch = new Stopwatch();
        string stateOfElevator = "";
        string floorStatus = "";


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

            stateOfElevator = "Going Up";
            floorStatus = "First Floor";

            // Start the stopwatch when the button is pressed
            stopwatch.Start();
            tmrTimeDurartion.Enabled = true;
            tmrTimeDurartion.Start();




        }

        private void btnElevatorRequestToGFloor_Click(object sender, EventArgs e)
        {
            // State of the Elevator is going to change from the last stage

            stateOfElevator = "Going Down";
            floorStatus = "Ground Floor";


            // Start the stopwatch when the button is pressed
            stopwatch.Start();
            tmrTimeDurartion.Enabled = true;
            tmrTimeDurartion.Start();

            // Door Closed
            lblDisplayFloorNumberInsideElevator.Text = stateOfElevator;
            lblDisplayFloorNumber.Text = stateOfElevator;
        }

        private void tmrTimeDurartion_Tick(object sender, EventArgs e)
        {
            // Get the elapsed time from the stopwatch
            TimeSpan elapsed = stopwatch.Elapsed;

            // Check if 10 seconds have passed
            if (elapsed.TotalSeconds >= 5)
            {
                // Door Closed
                lblDisplayFloorNumberInsideElevator.Text = "Reached At " + floorStatus;
                lblDisplayFloorNumber.Text = floorStatus;

                // Stop the timer and the stopwatch
                tmrTimeDurartion.Stop();
                stopwatch.Stop();
                stopwatch.Reset();
                tmrTimeDurartion.Enabled = false;

            }
            else
            {
                // State of the Elevator is going to change from the last stage

                // Door Closed
                lblDisplayFloorNumberInsideElevator.Text = stateOfElevator;
                lblDisplayFloorNumber.Text = stateOfElevator;
            }
        }
    }
}
