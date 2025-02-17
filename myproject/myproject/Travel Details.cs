using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace myproject
{
    public partial class Travel_Details : Form
    {
        private Timer timer;
        private int remainingTime;

        public Travel_Details(int timeLeft)
        {
            InitializeComponent();
            remainingTime = timeLeft;
            InitializeTimer();
        }

            private void Travel_Details_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
            label7.Enabled = false;

        }

        private void buttonClass3_Click(object sender, EventArgs e)
        {
            Dashboard form1 = new Dashboard(remainingTime); // Pass updated remaining time
            form1.Show();
            this.Hide();
        }

        private void buttonClass4_Click(object sender, EventArgs e)
        {
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

        private void buttonClass2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel?",
                "CONFIRMED",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Dashboard form1 = new Dashboard(remainingTime); // Pass updated remaining time
                form1.Show();
                this.Hide();
            }

        }

        private void buttonClass6_Click(object sender, EventArgs e)
        {
        }
      
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += timer1_Tick;
            label7.Text = $"{remainingTime} sec"; // Display time
            timer.Start(); // Start countdown // Start the timer automatically when the form loads
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
                timer.Stop(); // Stop when time reaches zero
                Application.Exit();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled) // Check if the timer is stopped
            {
                Application.Exit(); // Close the application
            }
            else
            {
                Dashboard form1 = new Dashboard(remainingTime); // Pass remaining time back to Form1
                form1.Show();
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonReturnToDashboard_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Stop timer before switching
            Dashboard form1 = new Dashboard(remainingTime); // Pass time back
            form1.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }
    }
}
