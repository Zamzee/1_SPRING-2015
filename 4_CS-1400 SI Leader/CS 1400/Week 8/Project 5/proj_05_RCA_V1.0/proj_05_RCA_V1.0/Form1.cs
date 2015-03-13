// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 5 Sales Invoice Calculator
// Date: July 6th, 2014


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_05_RCA_V1._0
{
    public partial class Form1 : Form
    {
        // class level reference to the SalesInvoice class
        private SalesInvoice si = new SalesInvoice();

        public Form1()
        {
            InitializeComponent();
            si.Reset();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell Andlauer\nCS-1400\nProject 5\nSales Invoice Application");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Buy button click event
        // Purpose: Create an invoice message box to display
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            si.SetNumItems(double.Parse(txt_Num_Items.Text));
            si.SetItemPrice(double.Parse(txt_Item_Price.Text));
            double numItems = si.GetNumItems();
            double itemPrice = si.GetItemPrice();
            double netPrice = si.CalcNetPrice();
            double stateTax = si.CalcStateTax();
            double localTax = si.CalcLocalTax();
            double totalPay = si.CalcTotalPay();

            string s0 = "Sales Ticket\n";
            string s1 = string.Format("Number of Items: {0} \n", numItems.ToString());
            string s2 = string.Format("Item Price: ${0} \n", itemPrice.ToString("F2"));
            string s3 = string.Format("Sale Price: ${0} \n", netPrice.ToString("F2"));
            string s4 = string.Format("State Tax: ${0} \n", stateTax.ToString("F2"));
            string s5 = string.Format("Local Tax: ${0} \n", localTax.ToString("F2"));
            string s6 = string.Format("Please pay: ${0} \n", totalPay.ToString("F2"));

            MessageBox.Show(s0 + s1+ s2 +s3 + s4 + s5 + s6);


        }

        // Clear button click event
        // Clear both text boxes and reset the Sales Invoice class
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Item_Price.Text = "";
            txt_Num_Items.Text = "";
            si.Reset();
        }
    }
}
