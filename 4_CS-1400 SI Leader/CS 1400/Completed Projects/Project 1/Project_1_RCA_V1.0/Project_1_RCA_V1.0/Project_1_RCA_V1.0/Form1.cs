using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_1_RCA_V1._0
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }
        /// <summary>The ToolStripMenuItem2 method
        /// Purpose: To show an about information window
        /// </summary>
        /// <param name="sender"></param>The object generating the event and the event arguments
        /// <param name="e"></param>
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell C. Andlauer\nCS-1400\nProject 01");
        }
       
        /// <summary> The exitToolStripMenuItem1 method
        /// Purpose: To close the window and terminate the application
        /// </summary>
        /// <param name="sender"></param>The object generating the event and the event arguments
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           /// string NumOne = string.Format("0D", txtNumOne.Text);
           /// int numOne = int.Parse(txtNumOne.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         string NumOne = string.Format("0D", txtNumOne.Text);
         string NumTwo = string.Format("0D", txtNumTwo.Text);
         int numOne = int.Parse(txtNumOne.Text);
         int numTwo = int.Parse(txtNumTwo.Text);
         double sum = numOne + numTwo;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int numOne = int.Parse(txtNumOne.Text);
            int numTwo = int.Parse(txtNumTwo.Text);
            string NumOne = string.Format("0D", txtNumOne.Text);
            string NumTwo = string.Format("0D", txtNumTwo.Text);
            double diff = numOne - numTwo;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int numOne = int.Parse(txtNumOne.Text);
            int numTwo = int.Parse(txtNumTwo.Text);
            string NumOne = string.Format("0D", txtNumOne.Text);
            string NumTwo = string.Format("0D", txtNumTwo.Text);
            double prod = numOne * numTwo;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int numOne = int.Parse(txtNumOne.Text);
            int numTwo = int.Parse(txtNumTwo.Text);
            string NumOne = string.Format("0D", txtNumOne.Text);
            string NumTwo = string.Format("0D", txtNumTwo.Text);
            double quot = numOne / numTwo;
        }

        private void txtNumTwo_TextChanged(object sender, EventArgs e)
        {
          /// string NumTwo = string.Format("0D"), txtNumTwo.Text);
          /// int numTwo = int.Parse(txtNumTwo.Text);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            int numOne = int.Parse(txtNumOne.Text);
            int numTwo = int.Parse(txtNumTwo.Text);
            string NumOne = string.Format("0D", txtNumOne.Text);
            string NumTwo = string.Format("0D", txtNumTwo.Text);
            double quot = numOne / numTwo;
            double prod = numOne * numTwo;
            double diff = numOne - numTwo;
            double sum = numOne + numTwo;
            ///txtTotal= ????;
            ///// I am wondering how I display the answer for the 4 different types of operations that are saved as doubles in the text box
        }
    }
} 