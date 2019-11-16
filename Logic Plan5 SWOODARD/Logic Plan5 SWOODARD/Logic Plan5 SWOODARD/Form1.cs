//Author: Steven Woodard
//Date: 17-Oct-2019
//Note: was tired when writing this... I'm glad it works.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan5_SWOODARD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {//user presses close
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {//user presses calculate
            //define variables
            int mph;
            int hours;
            int count;
            //parse out the speed, handle the junk
            if (!int.TryParse(speedTextBox.Text, out mph))
            {
                MessageBox.Show("Please enter an integer for the speed");
            }
            //parse out the time, handle the junk
            if(!int.TryParse(hoursTextBox.Text, out hours))
            {
                MessageBox.Show("Please enter an integer for the hours");
            }
            //for each hour show the distance traveled at each hour
            for(count = 1; count <= hours; count++)
            {
                distanceListBox.Items.Add($"After hour {count} the distance is {count * mph}");
            }
        }
    }
}
