namespace proj_02_RCA_V1._0
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
            this.TxtBox_WheelDiam = new System.Windows.Forms.TextBox();
            this.TxtBox_TurnNum = new System.Windows.Forms.TextBox();
            this.Lbl_WheelDiam = new System.Windows.Forms.Label();
            this.Lbl_Turns_per_Mile = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBox_WheelDiam
            // 
            this.TxtBox_WheelDiam.Location = new System.Drawing.Point(156, 98);
            this.TxtBox_WheelDiam.Name = "TxtBox_WheelDiam";
            this.TxtBox_WheelDiam.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_WheelDiam.TabIndex = 0;
            this.TxtBox_WheelDiam.TextChanged += new System.EventHandler(this.TxtBox_WheelDiam_TextChanged);
            this.TxtBox_WheelDiam.Leave += new System.EventHandler(this.TxtBox_WheelDiam_Leave);
            // 
            // TxtBox_TurnNum
            // 
            this.TxtBox_TurnNum.Location = new System.Drawing.Point(156, 155);
            this.TxtBox_TurnNum.Name = "TxtBox_TurnNum";
            this.TxtBox_TurnNum.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_TurnNum.TabIndex = 1;
            // 
            // Lbl_WheelDiam
            // 
            this.Lbl_WheelDiam.AutoSize = true;
            this.Lbl_WheelDiam.Location = new System.Drawing.Point(11, 105);
            this.Lbl_WheelDiam.Name = "Lbl_WheelDiam";
            this.Lbl_WheelDiam.Size = new System.Drawing.Size(139, 13);
            this.Lbl_WheelDiam.TabIndex = 2;
            this.Lbl_WheelDiam.Text = "Diameter of Wheel (Inches):";
            // 
            // Lbl_Turns_per_Mile
            // 
            this.Lbl_Turns_per_Mile.AutoSize = true;
            this.Lbl_Turns_per_Mile.Location = new System.Drawing.Point(70, 158);
            this.Lbl_Turns_per_Mile.Name = "Lbl_Turns_per_Mile";
            this.Lbl_Turns_per_Mile.Size = new System.Drawing.Size(80, 13);
            this.Lbl_Turns_per_Mile.TabIndex = 3;
            this.Lbl_Turns_per_Mile.Text = "Turns per Mile :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Lbl_Turns_per_Mile);
            this.Controls.Add(this.Lbl_WheelDiam);
            this.Controls.Add(this.TxtBox_TurnNum);
            this.Controls.Add(this.TxtBox_WheelDiam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project Two";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_WheelDiam;
        private System.Windows.Forms.TextBox TxtBox_TurnNum;
        private System.Windows.Forms.Label Lbl_WheelDiam;
        private System.Windows.Forms.Label Lbl_Turns_per_Mile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

