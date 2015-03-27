// File Prologue
// Name: Russell C. Andlauer
// Class: CS-1400
// Project: Project 11
// Date: 8/13/2014


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
using System.IO;

namespace proj_11_RCA_V1._0
{
    public partial class Form1 : Form
    {
        Employee[] employees = new Employee[0];
        int pointer = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell C. Andlauer\nCS-1400\nProject 11");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            if (open.FileName != "")
            {
                StreamReader reader = new StreamReader(open.FileName);

                bool run = true;

                while (run)
                {
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = new Employee();
                    run = employees[employees.Length - 1].Read(ref reader);
                }

                pointer = 0;
                btn_Next.Enabled = true;
                populate();
            }
        }

        private void populate()
        {
            txtBox_Name.Text = employees[pointer].getName();
            txtBox_Address.Text = employees[pointer].getAddress();
            txtBox_Pay.Text = employees[pointer].CalcPay().ToString("C");
            pointer++;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (pointer < employees.Length)
            {
                populate();
            }

            else
            {
                btn_Next.Enabled = false;
            }
        }

    }
}
