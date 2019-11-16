//Author: Steven Woodard with help drawn from B. Clay Shannon's post with subsequent reviewers: https://stackoverflow.com/questions/12808943/how-can-i-get-all-labels-on-a-form-and-set-the-text-property-of-those-with-a-par
//Also taken from Starting Out with Visual C# by Tony Gaddis.
//Date: 11/2/2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            //declare number of lottery numbers as the same as the number of labels available
            //find all of the controls marked as "labels" on the scope, which are not "sumTotalLabel" and make a 'label' array
            Label[] labels = Controls.OfType<Label>().Where<Label>(eachLabel => eachLabel.Name != "sumTotalLabel").ToArray();
            int numOfLotteryNums = labels.Length;
            //create array for lottery numbers
            int[] lotteryNumbers = CreateArrayForLotteryNumbers(numOfLotteryNums);
            //store random numbers in array
            PutRandomNumsInLottery(ref lotteryNumbers);
            //Display the lottery numbers
            DisplayLotteryNumbers(lotteryNumbers, labels);

        }
        private int[] CreateArrayForLotteryNumbers(int numOfLotteryNumbers = 5)
        {
            //return an array with the default number of numbers being 5.
            return new int[numOfLotteryNumbers];
        }
        private void PutRandomNumsInLottery(ref int[] lotteryNumbers)
        {
            //accumulator
            int myAccum = 0;
            //take in a reference to the variable inside the external scope
            //Create a random object for generating random numbers
            Random rand = new Random();
            //iterate through the array assigning the lottery numbers with the random object
            for(int i = 0; i < lotteryNumbers.Length; i++)
            {
                lotteryNumbers[i] = rand.Next(100);
                // display the total of the lottery numbers
                myAccum += lotteryNumbers[i];
            }
            sumTotalLabel.Text = myAccum.ToString();

        }
        public void DisplayLotteryNumbers(int[] lotteryNumbers, Label[] labels)
        {
            //take in the int array and the Label array
            
            //iterate through the array and change the text of the labels to the lottery numbers
            for(int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = lotteryNumbers[i].ToString();
            }
            
        }

    }

}
