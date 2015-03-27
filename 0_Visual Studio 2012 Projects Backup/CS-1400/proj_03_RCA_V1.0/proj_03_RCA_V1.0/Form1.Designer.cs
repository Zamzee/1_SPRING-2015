namespace proj_03_RCA_V1._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox_Old_Depart = new System.Windows.Forms.TextBox();
            this.txtBox_Old_Arrive = new System.Windows.Forms.TextBox();
            this.txtBox_New_Arrive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calculate_New_Arrive = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(284, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtBox_Old_Depart
            // 
            this.txtBox_Old_Depart.Location = new System.Drawing.Point(149, 98);
            this.txtBox_Old_Depart.Name = "txtBox_Old_Depart";
            this.txtBox_Old_Depart.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Old_Depart.TabIndex = 2;
            this.txtBox_Old_Depart.TextChanged += new System.EventHandler(this.txtBox_Old_Depart_TextChanged);
            // 
            // txtBox_Old_Arrive
            // 
            this.txtBox_Old_Arrive.Location = new System.Drawing.Point(149, 144);
            this.txtBox_Old_Arrive.Name = "txtBox_Old_Arrive";
            this.txtBox_Old_Arrive.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Old_Arrive.TabIndex = 3;
            this.txtBox_Old_Arrive.TextChanged += new System.EventHandler(this.txtBox_Old_Arrive_TextChanged);
            // 
            // txtBox_New_Arrive
            // 
            this.txtBox_New_Arrive.Location = new System.Drawing.Point(139, 202);
            this.txtBox_New_Arrive.Name = "txtBox_New_Arrive";
            this.txtBox_New_Arrive.Size = new System.Drawing.Size(100, 20);
            this.txtBox_New_Arrive.TabIndex = 4;
            this.txtBox_New_Arrive.TextChanged += new System.EventHandler(this.txtBox_New_Arrive_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1. Enter old start time: (hhmm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "2. Enter old end time: (hhmm)";
            // 
            // btn_Calculate_New_Arrive
            // 
            this.btn_Calculate_New_Arrive.Location = new System.Drawing.Point(45, 186);
            this.btn_Calculate_New_Arrive.Name = "btn_Calculate_New_Arrive";
            this.btn_Calculate_New_Arrive.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate_New_Arrive.TabIndex = 7;
            this.btn_Calculate_New_Arrive.Text = "Calculate";
            this.btn_Calculate_New_Arrive.UseVisualStyleBackColor = true;
            this.btn_Calculate_New_Arrive.Click += new System.EventHandler(this.btn_Calculate_New_Arrive_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Arrival Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Calculate_New_Arrive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_New_Arrive);
            this.Controls.Add(this.txtBox_Old_Arrive);
            this.Controls.Add(this.txtBox_Old_Depart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project 03";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBox_Old_Depart;
        private System.Windows.Forms.TextBox txtBox_Old_Arrive;
        private System.Windows.Forms.TextBox txtBox_New_Arrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Calculate_New_Arrive;
        private System.Windows.Forms.Label label3;
    }
}

