namespace Lab_17_RCA_V1._0
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_1 = new System.Windows.Forms.RadioButton();
            this.radioBtn_2 = new System.Windows.Forms.RadioButton();
            this.radioBtn_3 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_3);
            this.groupBox1.Controls.Add(this.radioBtn_2);
            this.groupBox1.Controls.Add(this.radioBtn_1);
            this.groupBox1.Location = new System.Drawing.Point(50, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Method";
            // 
            // radioBtn_1
            // 
            this.radioBtn_1.AutoSize = true;
            this.radioBtn_1.Location = new System.Drawing.Point(7, 20);
            this.radioBtn_1.Name = "radioBtn_1";
            this.radioBtn_1.Size = new System.Drawing.Size(68, 17);
            this.radioBtn_1.TabIndex = 0;
            this.radioBtn_1.Text = "Standard";
            this.radioBtn_1.UseVisualStyleBackColor = true;
            this.radioBtn_1.CheckedChanged += new System.EventHandler(this.radioBtn_1_CheckedChanged);
            // 
            // radioBtn_2
            // 
            this.radioBtn_2.AutoSize = true;
            this.radioBtn_2.Location = new System.Drawing.Point(7, 44);
            this.radioBtn_2.Name = "radioBtn_2";
            this.radioBtn_2.Size = new System.Drawing.Size(62, 17);
            this.radioBtn_2.TabIndex = 1;
            this.radioBtn_2.Text = "Express";
            this.radioBtn_2.UseVisualStyleBackColor = true;
            this.radioBtn_2.CheckedChanged += new System.EventHandler(this.radioBtn_2_CheckedChanged);
            // 
            // radioBtn_3
            // 
            this.radioBtn_3.AutoSize = true;
            this.radioBtn_3.Location = new System.Drawing.Point(7, 68);
            this.radioBtn_3.Name = "radioBtn_3";
            this.radioBtn_3.Size = new System.Drawing.Size(74, 17);
            this.radioBtn_3.TabIndex = 2;
            this.radioBtn_3.Text = "Same-Day";
            this.radioBtn_3.UseVisualStyleBackColor = true;
            this.radioBtn_3.CheckedChanged += new System.EventHandler(this.radioBtn_3_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 17";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_3;
        private System.Windows.Forms.RadioButton radioBtn_2;
        private System.Windows.Forms.RadioButton radioBtn_1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

