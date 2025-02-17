using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Reflection.Emit;
namespace myproject
{
    public partial class Dashboard : Form
    {  // Declare departure and destination locations as class-level variables
        private string departureLocation = "";
        private string destinationLocation = "";
        private readonly string[] stations = { "Uttara","Pallabi", "Mirpur 11","Mirpur 10", "Kazipara","Shewrapara","Tejgaon", "Agargaon","Farmgate", "Karwanbazar", "Motijheel" };

        private List<RadioButton> fixedRadioButtons;
        private List<RadioButton> optionalRadioButtons;
        private Timer timer;
        private int remainingTime = 15;
        public Dashboard(int remainingTime = 15)
        {
            InitializeComponent();
            this.remainingTime = remainingTime;
            InitializeTimer();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
            label7.Enabled = false;
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox1, "Uttara");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox2, "Pallabi");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox3, "Mirpur 11");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox4, "Mirpur 10");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox5, "Kazipara");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox6, "Shewrapara");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox7, "Tejgaon");
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox8, "Agargaon");
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox9, "Framgate");
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox10, "Karwanbazar");
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckBoxChanged(checkBox11, "Motijheel");
        }



        private void EnsureMaxTwoSelections()
        {
            var checkBoxes = new[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8,checkBox9, checkBox10, checkBox11 };
            int checkedCount = 0;
            foreach (var cb in checkBoxes)
            {
                if (cb.Checked)
                    checkedCount++;
            }

            if (checkedCount > 2)
            {
                foreach (var checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                    {
                        checkBox.Checked = false;
                        break;
                    }
                }
            }
        }
        private void HandleCheckBoxChanged(CheckBox checkBox, string location)
        {
            if (checkBox.Checked)
            {
                EnsureMaxTwoSelections();

                if (string.IsNullOrEmpty(departureLocation))
                {
                    departureLocation = location;
                    textBox1.Text = departureLocation;
                }
                else if (string.IsNullOrEmpty(destinationLocation))
                {
                    destinationLocation = location;
                    textBox2.Text = destinationLocation;
                }
            }
            else
            {
                if (departureLocation == location)
                {
                    departureLocation = "";
                    textBox1.Text = "";
                }
                else if (destinationLocation == location)
                {
                    destinationLocation = "";
                    textBox2.Text = "";
                }
            }
            CalculateAndDisplayFare();
        }
        private void CalculateAndDisplayFare()
        {
            if (!string.IsNullOrEmpty(departureLocation) && !string.IsNullOrEmpty(destinationLocation))
            {                                                                                                 
                int departureIndex = Array.IndexOf(stations, departureLocation);
                int destinationIndex = Array.IndexOf(stations, destinationLocation);

                if (departureIndex != -1 && destinationIndex != -1)
                {
                    int distance = Math.Abs(destinationIndex - departureIndex); // Calculate the number of stations
                    int fare = distance * 15; // Each station costs 10 Taka
                    textBox3.Text = $"{fare}" ; //Taka"; // Display the fare
                }
            }
            else
            {
                textBox3.Text = ""; // Clear fare display if selection is incomplete
            }
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }

        private void buttonClass2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Are you sure you want to Cancel?",
             "CONFIRMED",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonClass1_Click(object sender, EventArgs e)
        {
            // Check if both departure and destination locations are selected
            if (string.IsNullOrEmpty(departureLocation) || string.IsNullOrEmpty(destinationLocation))
            {
                MessageBox.Show(
                    "Please select both departure and destination stations before confirming.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Proceed with confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to confirm?",
                "CONFIRMED",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void buttonClass5_Click(object sender, EventArgs e)
        {

        }

        private void buttonClass4_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Travel_Details travelDetails = new Travel_Details(remainingTime);
            travelDetails.Show();
            this.Hide();
            /*
                     SqlConnection con = new SqlConnection("Data Source=SRABON\\SQLEXPRESS;Initial Catalog=TicketInfo;Integrated Security=True;");
                     con.Open();
                     SqlCommand command = new SqlCommand("INSERT INTO ticketinfo ([Name], [ID], [Departure Location], [Destination Location], [Transiction]) VALUES (@Name, @ID, @Departure, @Destination, @Transaction)", con);

                     command.Parameters.AddWithValue("@Name", textBox5.Text);          // Name (nvarchar)
                     command.Parameters.AddWithValue("@ID", int.Parse(textBox4.Text)); // ID (int)
                     command.Parameters.AddWithValue("@Departure", textBox1.Text);     // Departure Location (nvarchar)
                     command.Parameters.AddWithValue("@Destination", textBox2.Text);   // Destination Location (nvarchar)
                     command.Parameters.AddWithValue("@Transaction", int.Parse(textBox3.Text)); // Transaction (int)

                     command.ExecuteNonQuery();
                     MessageBox.Show("Success");
                     con.Close();*/

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += timer1_Tick;
            label7.Text = $"{remainingTime} sec"; // Display the time
            timer.Start(); // Start the countdown
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
                if (remainingTime > 0)
            {
                remainingTime--;
                label7.Text = $"{remainingTime} sec";
            }
            else
            {
                timer.Stop(); // Application.Exit(); Stop when time runs out
            }
        }  

        private void buttonClass6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Stop timer before switching forms

            if (!timer.Enabled) // Check if the timer is stopped
            { 
            
                Application.Exit(); // Close the application
            }
            else
            {
                Travel_Details travelHistory = new Travel_Details(remainingTime); // Pass remaining time
                travelHistory.Show();
                this.Hide();
            }

        }
        private void buttonOpenTravelDetails_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Pause timer before switching
            Travel_Details form2 = new Travel_Details(remainingTime);
            form2.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClass6_Click_1(object sender, EventArgs e)
        {

        }
 

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClass3_Click(object sender, EventArgs e)
        {
            

        }
     

                

            
        
    }
}
