namespace proj_06_RCA_V1._0
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
            this.cmboBox_ShipMethod = new System.Windows.Forms.ComboBox();
            this.cmboBox_Category = new System.Windows.Forms.ComboBox();
            this.cmboBox_Surcharge = new System.Windows.Forms.ComboBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ship_Cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NumItems = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboBox_ShipMethod
            // 
            this.cmboBox_ShipMethod.FormattingEnabled = true;
            this.cmboBox_ShipMethod.Items.AddRange(new object[] {
            "Standard",
            "Express",
            "Same Day"});
            this.cmboBox_ShipMethod.Location = new System.Drawing.Point(126, 128);
            this.cmboBox_ShipMethod.Name = "cmboBox_ShipMethod";
            this.cmboBox_ShipMethod.Size = new System.Drawing.Size(121, 21);
            this.cmboBox_ShipMethod.TabIndex = 0;
            // 
            // cmboBox_Category
            // 
            this.cmboBox_Category.FormattingEnabled = true;
            this.cmboBox_Category.Items.AddRange(new object[] {
            "by Items",
            "by Weight"});
            this.cmboBox_Category.Location = new System.Drawing.Point(344, 128);
            this.cmboBox_Category.Name = "cmboBox_Category";
            this.cmboBox_Category.Size = new System.Drawing.Size(121, 21);
            this.cmboBox_Category.TabIndex = 1;
            this.cmboBox_Category.SelectedIndexChanged += new System.EventHandler(this.cmboBox_Category_SelectedIndexChanged);
            // 
            // cmboBox_Surcharge
            // 
            this.cmboBox_Surcharge.FormattingEnabled = true;
            this.cmboBox_Surcharge.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmboBox_Surcharge.Location = new System.Drawing.Point(344, 206);
            this.cmboBox_Surcharge.Name = "cmboBox_Surcharge";
            this.cmboBox_Surcharge.Size = new System.Drawing.Size(121, 21);
            this.cmboBox_Surcharge.TabIndex = 3;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(126, 306);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(95, 49);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "Calculate Shipping";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shipping Cost";
            // 
            // txt_Ship_Cost
            // 
            this.txt_Ship_Cost.Location = new System.Drawing.Point(365, 335);
            this.txt_Ship_Cost.Name = "txt_Ship_Cost";
            this.txt_Ship_Cost.ReadOnly = true;
            this.txt_Ship_Cost.Size = new System.Drawing.Size(100, 20);
            this.txt_Ship_Cost.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shipping Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Surcharge (HI or AK)";
            // 
            // txt_NumItems
            // 
            this.txt_NumItems.Location = new System.Drawing.Point(147, 207);
            this.txt_NumItems.Name = "txt_NumItems";
            this.txt_NumItems.Size = new System.Drawing.Size(100, 20);
            this.txt_NumItems.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(442, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Red Fern Online Electronics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Shipping Calculator";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
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
            this.ClientSize = new System.Drawing.Size(546, 446);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_NumItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ship_Cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.cmboBox_Surcharge);
            this.Controls.Add(this.cmboBox_Category);
            this.Controls.Add(this.cmboBox_ShipMethod);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project 6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBox_ShipMethod;
        private System.Windows.Forms.ComboBox cmboBox_Category;
        private System.Windows.Forms.ComboBox cmboBox_Surcharge;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ship_Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NumItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

