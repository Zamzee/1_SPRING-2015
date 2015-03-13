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
        /// <summary>THe ToolStripMenuItem2 method
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

        }
    }
}
