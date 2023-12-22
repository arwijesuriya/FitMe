using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMe
{
    public partial class FitnessResults : Form
    {
        private const int PaddingSize = 10;

        public FitnessResults()
        {
            InitializeComponent();
        }

        Home home = null;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNotes.Text = txtImprovements.Text = txtAero.Text = txtBody.Text = txtBridges.Text = txtClimb.Text = txtCycling.Text = txtJumping.Text = txtLeg.Text = txtLunge.Text
                 = txtPlank.Text = txtPull.Text = txtPunch.Text = txtPush.Text = txtRoll.Text = txtRunning.Text = txtSit.Text = txtSquat.Text = txtSwimming.Text = txtWalking.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create an array to store the data
            string[] data = new string[21]; // Assuming you have 20 textboxes and 1 datetimepicker

            // Assign values from textboxes to array
            data[0] = txtNotes.Text;
            data[1] = txtImprovements.Text;
            data[2] = txtAero.Text;
            data[3] = txtBody.Text;
            data[4] = txtBridges.Text;
            data[5] = txtClimb.Text;
            data[6] = txtCycling.Text;
            data[7] = txtJumping.Text;
            data[8] = txtLeg.Text;
            data[9] = txtLunge.Text;
            data[10] = txtPlank.Text;
            data[11] = txtPull.Text;
            data[12] = txtPunch.Text;
            data[13] = txtPush.Text;
            data[14] = txtRoll.Text;
            data[15] = txtRunning.Text;
            data[16] = txtSit.Text;
            data[17] = txtSquat.Text;
            data[18] = txtSwimming.Text;
            data[19] = txtWalking.Text;
            data[20] = dateStartDate.Value.ToString("yyyy-MM-dd"); // Format the datetime value

            // Save data to CSV file
            SaveDataToCSV("fitness-results.csv", data);
        }

        private void FitnessResults_Load(object sender, EventArgs e)
        {
            string fileName = "fitness-results.csv";

            try
            {
                // Read data from the CSV file
                string[] lines = File.ReadAllLines(fileName);

                if (lines.Length > 0)
                {
                    // Split the first line to get column names
                    string[] headers = lines[0].Split(',');

                    if (headers.Length == 21) // Assuming 20 textboxes and 1 datetimepicker
                    {
                        for (int i = 0; i < headers.Length; i++)
                        {
                            // Skip the header row
                            for (int j = 1; j < lines.Length; j++)
                            {
                                string[] fields = lines[j].Split(',');

                                if (fields.Length == 21) // Assuming 20 textboxes and 1 datetimepicker
                                {
                                    // Assign values to textboxes and datetimepicker
                                    txtNotes.Text = fields[0];
                                    txtImprovements.Text = fields[1];
                                    txtAero.Text = fields[2];
                                    txtBody.Text = fields[3];
                                    txtBridges.Text = fields[4];
                                    txtClimb.Text = fields[5];
                                    txtCycling.Text = fields[6];
                                    txtJumping.Text = fields[7];
                                    txtLeg.Text = fields[8];
                                    txtLunge.Text = fields[9];
                                    txtPlank.Text = fields[10];
                                    txtPull.Text = fields[11];
                                    txtPunch.Text = fields[12];
                                    txtPush.Text = fields[13];
                                    txtRoll.Text = fields[14];
                                    txtRunning.Text = fields[15];
                                    txtSit.Text = fields[16];
                                    txtSquat.Text = fields[17];
                                    txtSwimming.Text = fields[18];
                                    txtWalking.Text = fields[19];
                                    dateStartDate.Value = DateTime.ParseExact(fields[20], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                                }
                            }
                        }
                    }
                }

                //MessageBox.Show("Data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDataToCSV(string fileName, string[] data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    // Write header
                    sw.WriteLine("Notes,Improvements,Aero,Body,Bridges,Climb,Cycling,Jumping,Leg,Lunge,Plank,Pull,Punch,Push,Roll,Running,Sit,Squat,Swimming,Walking,DateStartDate");

                    // Write data
                    sw.WriteLine(string.Join(",", data));
                }

                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (home == null || home.IsDisposed)
            {
                home = new Home();
            }

            home.Show();
            this.Hide();
        }
    }
}

