namespace TokenMachine
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTokens = new System.Windows.Forms.TextBox();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.lblQuarters = new System.Windows.Forms.Label();
            this.lblTokens = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
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
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(122, 135);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(75, 23);
            this.btnGetToken.TabIndex = 1;
            this.btnGetToken.Text = "Get Token";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(122, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTokens
            // 
            this.txtTokens.Location = new System.Drawing.Point(122, 57);
            this.txtTokens.Name = "txtTokens";
            this.txtTokens.Size = new System.Drawing.Size(100, 20);
            this.txtTokens.TabIndex = 3;
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(122, 99);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.Size = new System.Drawing.Size(100, 20);
            this.txtQuarters.TabIndex = 4;
            // 
            // lblQuarters
            // 
            this.lblQuarters.AutoSize = true;
            this.lblQuarters.Location = new System.Drawing.Point(8, 99);
            this.lblQuarters.Name = "lblQuarters";
            this.lblQuarters.Size = new System.Drawing.Size(102, 13);
            this.lblQuarters.TabIndex = 5;
            this.lblQuarters.Text = "Number of Quarters:";
            // 
            // lblTokens
            // 
            this.lblTokens.AutoSize = true;
            this.lblTokens.Location = new System.Drawing.Point(12, 57);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(98, 13);
            this.lblTokens.TabIndex = 6;
            this.lblTokens.Text = "Number of Tokens:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTokens);
            this.Controls.Add(this.lblQuarters);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.txtTokens);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGetToken);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Token Machine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTokens;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.Label lblQuarters;
        private System.Windows.Forms.Label lblTokens;
    }
}

