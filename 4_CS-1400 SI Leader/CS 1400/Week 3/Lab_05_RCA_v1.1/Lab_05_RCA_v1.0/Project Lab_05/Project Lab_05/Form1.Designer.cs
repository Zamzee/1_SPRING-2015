namespace Project_Lab_04
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
            this.MSpMain = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.TxtOut = new System.Windows.Forms.TextBox();
            this.TxtIn = new System.Windows.Forms.TextBox();
            this.MSpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSpMain
            // 
            this.MSpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.MSpMain.Location = new System.Drawing.Point(0, 0);
            this.MSpMain.Name = "MSpMain";
            this.MSpMain.Size = new System.Drawing.Size(284, 24);
            this.MSpMain.TabIndex = 0;
            this.MSpMain.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(59, 84);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(34, 13);
            this.Input.TabIndex = 2;
            this.Input.Text = "Input:";
            this.Input.Click += new System.EventHandler(this.label1_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(59, 129);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(42, 13);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output:";
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(119, 122);
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(100, 20);
            this.TxtOut.TabIndex = 4;
            // 
            // TxtIn
            // 
            this.TxtIn.Location = new System.Drawing.Point(119, 77);
            this.TxtIn.Name = "TxtIn";
            this.TxtIn.Size = new System.Drawing.Size(100, 20);
            this.TxtIn.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TxtIn);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MSpMain);
            this.MainMenuStrip = this.MSpMain;
            this.Name = "Form1";
            this.Text = "CS1400 Lab #5";
            this.MSpMain.ResumeLayout(false);
            this.MSpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSpMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.TextBox TxtIn;
    }
}

