using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14_RCA_V1._0
{
    public partial class Form1 : Form
    {
        private Wheel_Odometer wd = new Wheel_Odometer();

        public Form1()
        {
            InitializeComponent();
            wd.Reset();
            string revs = String.Format("{0:D}", wd.CalcRevolutions());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Russell Andlauer\nCS-1400\nLab 15");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            wd.CalcCircumference();
            wd.CalcRevolutions();
            string revs = String.Format("{0:D}", wd.CalcRevolutions());
            txt_RevsPerMile.Text = revs;

        }
    }
}
