using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceTraveled
{
    public partial class Form1 : Form
    {
        int speed = 0;
        int time5 = 5;
        int time8 = 8;
        int time12 = 12;
        int distance = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveHourButton_Click(object sender, EventArgs e)
        {
            speed = int.Parse(speedTextBox.Text);
            distance = speed * time5;
            MessageBox.Show($"You traveled {distance.ToString()} miles on this trip.");
        }

        private void eightHourButton_Click(object sender, EventArgs e)
        {
            speed = int.Parse(speedTextBox.Text);
            distance = speed * time8;
            MessageBox.Show($"You traveled {distance.ToString()} miles on this trip.");
        }

        private void twelveHourButton_Click(object sender, EventArgs e)
        {
            speed = int.Parse(speedTextBox.Text);
            distance = speed * time12;
            MessageBox.Show($"You traveled {distance.ToString()} miles on this trip.");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            speedTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
