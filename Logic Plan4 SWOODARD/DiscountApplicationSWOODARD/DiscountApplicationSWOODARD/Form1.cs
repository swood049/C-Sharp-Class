using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountApplicationSWOODARD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declare variables: price, quantity, discRate, amtOfDisc, originalTotal, total
            const decimal price = 99.00m;
            int quantity;
            decimal discRate;
            decimal amtOfDisc;
            decimal originalTotal;
            decimal total;

            //Parse, Obtain quantity from user
            if (int.TryParse(numberTextBox.Text, out quantity))
            {
                //if quantity is less than or equal to 0
                if(quantity <= 0)
                {
                    //prompt user to try again
                    MessageBox.Show("Error, purchase has to be greater than zero. Try again.");
                }
                else
                {//quantity is between 0 and 10
                    if (quantity > 0 && quantity <= 9)
                    {//Assign 0% to discRate
                        discRate = 0.0m;
                    }//quantity is between 9 and 20
                    else if(quantity > 9 && quantity <= 19)
                    {//Assign 0.20 to discRate
                        discRate = 0.2m;
                    }//quantity is between 19 and 50
                    else if (quantity > 19 && quantity <= 49)
                    {//Assign 0.30 to discRate
                        discRate = 0.3m;
                    }//quantity is between 49 and 100
                    else if (quantity > 49 && quantity <= 99)
                    {//Assign 0.40 to discRate
                        discRate = 0.4m;
                    }//quantity is 100 or above
                    else
                    {//Assign 0.50 to discRate
                        discRate = 0.5m;
                    }
                    //calculate original total
                    originalTotal = price * quantity;
                    //calculate amount of discount
                    amtOfDisc = originalTotal * discRate;
                    //calculate total
                    total = originalTotal - amtOfDisc;

                    //output discount rate, amount total discount, and total
                    discountRateLabel.Text = discRate.ToString("p");
                    amountSavedLabel.Text = amtOfDisc.ToString("c");
                    totalLabel.Text = total.ToString("c");

                }
            }
            else
            {//handle garbage
                MessageBox.Show("please input an integer");
            }
            
        }
    }
}
