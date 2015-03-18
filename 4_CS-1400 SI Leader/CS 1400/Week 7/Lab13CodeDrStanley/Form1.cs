﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


 

namespace Lab25GUITokenMachine
{
    public partial class Form1 : Form
    {
        // a class level refernce to a token machine
        // This creates a Token Machine Object called tm from the class MyTokenMachine
        private MyTokenMachine tm = new MyTokenMachine();

        public Form1()
        {
            InitializeComponent();

            // These statements resets the token machine to the maximum tokens and zero quaters
            // and initializes the txt boxes by getting number of quaters and tokens from the object
            tm.Reset();
            string outStr = string.Format("{0:D}", tm.CountTokens());
            txtTokInMach.Text = outStr;
            outStr = string.Format("{0:D}", tm.CountQuarters());
            txtQuaterInMachine.Text = outStr;
        }

         private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tim Stanley\nCS1400\nLab #25\nToken Machine");
        }

        // Get Token Button push
        //This method calls the GetToken method to decrement tokens and increment quaters in the machine
        private void btnGetToken_Click(object sender, EventArgs e)
        {
            tm.GetToken();
            string outStr = string.Format("{0:D}", tm.CountTokens());
            txtTokInMach.Text = outStr;
            outStr = string.Format("{0:D}", tm.CountQuarters());
            txtQuaterInMachine.Text = outStr;


        }

        //This method resets the token machine on the rest button push
        // It call the token machine reset method to remove quaters and fill with tokens.
        private void btnReset_Click(object sender, EventArgs e)
        {
            tm.Reset();
            string outStr = string.Format("{0:D}", tm.CountTokens());
            txtTokInMach.Text = outStr;
            outStr = string.Format("{0:D}", tm.CountQuarters());
            txtQuaterInMachine.Text = outStr;

        }

        private void txtTokInMach_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}