using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.OleDb;

using System.IO;
using System.Reflection;
using System.Data.OleDb;

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



        // Functions related to database Operations

        private string ExtractResource(string resourceName, string destinationPath)
        {
            string extractedFilePath = Path.Combine(destinationPath, resourceName);

            if (!File.Exists(extractedFilePath))
            {
                using (Stream input = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                using (Stream output = File.Create(extractedFilePath))
                {
                    input.CopyTo(output);
                }
            }

            return extractedFilePath;
        }

        private void UseDatabase(string databasePath, string value1, string value2)
        {
            try
            {
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();

                string insertQuery = "INSERT INTO logTable (logTime, logDescription) VALUES (@value1, @Value2)";
                OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@value1", value1);
                insertCommand.Parameters.AddWithValue("@Value2", value2);

                insertCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message);
            }
        }


        public void RetrieveData(string databasePath)
        {
            try
            {
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();

                string selectQuery = "SELECT ID, logTime, logDescription FROM logTable";
                OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection);

                OleDbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0); // Adjust data types as needed
                    string logTime = reader.GetString(1);
                    string logDescription = reader.GetString(2);

                    MessageBox.Show(" " + id.ToString() + " " + logTime.ToString() +" " + logDescription.ToString());


                    // Process the retrieved data, e.g., display it in your WinForms application.
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., display an error message or log the error).
                Console.WriteLine("Error: " + ex.Message);
            }
        }
       




        private void btnRequestLog_Click(object sender, EventArgs e)
        {
            try
            {
                string mainPath = Application.StartupPath;
                string databasePath = mainPath + @"\Resources\dbElevatorLog.accdb";

                string formattedDateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                UseDatabase(databasePath, formattedDateTime.ToString(), "YourLogDescription");

                RetrieveData(databasePath);
            }
            catch (Exception exp)
            {
                MessageBox.Show("An Error Occurred: " + exp.Message);
            }
        }

    }
}
