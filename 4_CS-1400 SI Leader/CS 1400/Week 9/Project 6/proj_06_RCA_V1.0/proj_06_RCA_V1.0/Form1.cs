// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: 6
// Date: 7/11/2014


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.
// Received help from the tutoring lab

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_06_RCA_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate the shipping cost given the selected shipping options upon button click
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            ShippingCalculator myCalc = new ShippingCalculator();
            myCalc.setShippingType(cmboBox_ShipMethod.SelectedIndex);
            myCalc.setCategory(cmboBox_Category.SelectedIndex);
            myCalc.setCount(int.Parse(txt_NumItems.Text));
            myCalc.setSurcharge(Convert.ToBoolean(cmboBox_Surcharge.SelectedIndex));
            txt_Ship_Cost.Text = myCalc.Calculate().ToString("C");  
        }

        // Change the label for the quantity text box for an accurate description when the category of shipment is changed
        private void cmboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBox_Category.SelectedIndex == 0)
            {
                label4.Text = "Number of Items";
            }
            else if (cmboBox_Category.SelectedIndex == 1)
            {
                label4.Text = "Number of Pounds";
            }

        }
        // Display the About message box when the About menu item is clicked
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell Andlauer\nCS-1400\nProject # 6");
        }

        // Close the program when the Exit menu item is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
