//Author: Steven Woodard inspiration take from Michael Jacoby for modularizing the parsing and error checking. The idea was his, the code is mine.
//Date: 10/30/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Plan6_SWOODARD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {//exit button close program
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declare variables to store user input
            decimal wholeSale, markUpPercent;
            //Parse user input into variables, and check for errors
            GetValidUserInput(out wholeSale, out markUpPercent);
            //Get the retail price and display to the user
            retailPriceTextBox.Text = CalculateRetailPrice(wholeSale, markUpPercent).ToString("c");
        }
        private void GetValidUserInput(out decimal wholeSale, out decimal markUpPercent)
        {
            //assign variables to safe value for compiler to be happy
            wholeSale = 0;
            markUpPercent = 0;
            //Look for errors in the following code
            try
            {
                //parse user input
                wholeSale = decimal.Parse(wholesaleTextBox.Text);
                markUpPercent = decimal.Parse(markupPercentTextBox.Text);
                //If wholeSale or markUpPercent is negative
                if (wholeSale < 0 || markUpPercent < 0)
                {
                    //complain
                    throw new Exception("Please put in positive numbers");
                }
            }
            catch(Exception ex)
            {
                //if there is any error, 
                //Put variables into 'safe state'
                wholeSale = 0;
                markUpPercent = 0;
                //send messages to user.
                wholesaleTextBox.Text = "ERROR";
                markupPercentTextBox.Text = "ERROR";
                MessageBox.Show(ex.Message);
            }
            
        }
        private decimal CalculateRetailPrice(decimal wholeSale, decimal markUpPercent)
        {
            //calculate the price
            //markUpPercent = markUpPercent / 100;
            markUpPercent = decimal.Divide( markUpPercent, 100m);
            //Return the result of calculating the retail value
            return wholeSale * (1 + markUpPercent);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            wholesaleTextBox.Text = "";
            markupPercentTextBox.Text = "";
            retailPriceTextBox.Text = "";
        }
    }
}
